using CarRentalSystem.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class frmBilling : Form
    {
        private readonly BillingFactory billingFactory = new BillingFactory();
        private DataTable billingTable;

        public frmBilling()
        {
            InitializeComponent();
            ClearBillingLabels();
            LoadBillingTable();
            UpdatePaymentButton();
        }

        private void LoadPanel()
        {

        }

        private void ClearBillingLabels()
        {
            lblBillingID.Text = "";
            lblBaseRate.Text = "";
            lblRemainingBalance.Text = "";
            lblTotalAmount.Text = "";
            lblTotalCharges.Text = "";
            lblStatus.Text = "";
        }


        private void LoadBillingTable()
        {
            var billings = billingFactory.ViewAll();
            billingTable = new DataTable();

            // Add columns
            billingTable.Columns.Add("BillingID", typeof(long));
            billingTable.Columns.Add("ContractID", typeof(long));
            billingTable.Columns.Add("CustomerName", typeof(string));
            billingTable.Columns.Add("CarName", typeof(string));
            billingTable.Columns.Add("BaseRate", typeof(decimal));
            billingTable.Columns.Add("TotalCharges", typeof(decimal));
            billingTable.Columns.Add("SecurityDepUsed", typeof(decimal));
            billingTable.Columns.Add("TotalAmount", typeof(decimal));
            billingTable.Columns.Add("AmountPaid", typeof(decimal));
            billingTable.Columns.Add("RemainingBalance", typeof(decimal));
            billingTable.Columns.Add("PaymentStatus", typeof(string));
            billingTable.Columns.Add("BillingDate", typeof(DateTime));
            billingTable.Columns.Add("Remarks", typeof(string));

            foreach (var b in billings)
            {
                billingTable.Rows.Add(
                    b.BillingId,
                    b.ContractId,
                    b.CustomerName ?? "",
                    b.CarName ?? "",
                    b.BaseRate,
                    b.TotalCharges ?? 0m,
                    b.SecurityDepUsed ?? 0m,
                    b.TotalAmount,
                    b.AmountPaid,
                    b.RemainingBalance,
                    b.PaymentStatus ?? "Pending",
                    b.BillingDate,
                    b.Remarks ?? ""
                );
            }

            var view = billingTable.DefaultView;
            view.Sort = "BillingID DESC";
            dgvBilling.DataSource = view;

            // Format
            dgvBilling.Columns["ContractID"].Visible = false;
            dgvBilling.Columns["CarName"].Visible = false;
            foreach (DataGridViewColumn col in dgvBilling.Columns)
            {
                if (col.ValueType == typeof(decimal))
                    col.DefaultCellStyle.Format = "N2";
            }

            dgvBilling.Columns["BillingID"].HeaderText = "Billing ID";
            dgvBilling.Columns["CustomerName"].HeaderText = "Customer";
            dgvBilling.Columns["RemainingBalance"].HeaderText = "Balance";
            dgvBilling.Columns["PaymentStatus"].HeaderText = "Status";

            dgvBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBilling.ReadOnly = true;
        }

        private void DisplayBillingDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;

            lblCustomerName.Text = selectedRow.Cells["CustomerName"].Value?.ToString() ?? "";
            lblBillingID.Text = selectedRow.Cells["BillingID"].Value?.ToString() ?? "";
            lblBaseRate.Text = Convert.ToDecimal(selectedRow.Cells["BaseRate"].Value).ToString("N2");
            lblTotalAmount.Text = Convert.ToDecimal(selectedRow.Cells["TotalAmount"].Value).ToString("N2");

            // Handle possible DBNull for TotalCharges
            var totalChargesCell = selectedRow.Cells["TotalCharges"].Value;
            lblTotalCharges.Text = (totalChargesCell == null || totalChargesCell == DBNull.Value)
                ? "0.00"
                : Convert.ToDecimal(totalChargesCell).ToString("N2");

            lblRemainingBalance.Text = Convert.ToDecimal(selectedRow.Cells["RemainingBalance"].Value).ToString("N2");
            lblStatus.Text = selectedRow.Cells["PaymentStatus"].Value?.ToString() ?? "Pending";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvBilling.SelectedRows.Count == 0) return;

            var row = dgvBilling.SelectedRows[0];
            long billingId = Convert.ToInt64(row.Cells["BillingID"].Value);

            var billing = new Billing
            {
                BillingId = billingId,
                ContractId = Convert.ToInt64(row.Cells["ContractID"].Value),
                CustomerName = row.Cells["CustomerName"].Value?.ToString(),
                CarName = row.Cells["CarName"].Value?.ToString(),
                BaseRate = Convert.ToDecimal(row.Cells["BaseRate"].Value),
                TotalCharges = row.Cells["TotalCharges"].Value == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row.Cells["TotalCharges"].Value),
                SecurityDepUsed = row.Cells["SecurityDepUsed"].Value == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row.Cells["SecurityDepUsed"].Value),
                TotalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value),
                AmountPaid = Convert.ToDecimal(row.Cells["AmountPaid"].Value),
                RemainingBalance = Convert.ToDecimal(row.Cells["RemainingBalance"].Value),
                PaymentStatus = row.Cells["PaymentStatus"].Value?.ToString()
            };

            using (var modal = new modal_Payment(billing))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    LoadBillingTable();
                    ReselectRow(billingId);
                }
            }
        }
        private void ReselectRow(long billingId)
        {
            foreach (DataGridViewRow row in dgvBilling.Rows)
            {
                if (Convert.ToInt64(row.Cells["BillingID"].Value) == billingId)
                {
                    dgvBilling.ClearSelection();
                    row.Selected = true;
                    dgvBilling.CurrentCell = row.Cells[0];
                    DisplayBillingDetails(row);
                    UpdatePaymentButton();
                    break;
                }
            }
        }
        private void frmBilling_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgvBilling.Rows[e.RowIndex];
                DisplayBillingDetails(selectedRow);

                btnPayment.Enabled = true;
                btnPayment.ForeColor = Color.FromArgb(4, 126, 175);
            }
        }
        private void dgvBilling_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBilling.SelectedRows.Count > 0)
            {
                DisplayBillingDetails(dgvBilling.SelectedRows[0]);
                UpdatePaymentButton();
            }
        }
        private void dgvBilling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            return;
        }

        private void UpdatePaymentButton()
        {
            if (dgvBilling.SelectedRows.Count == 0)
            {
                btnPayment.Enabled = false;
                btnPayment.Text = "Payment";
                return;
            }

            string status = dgvBilling.SelectedRows[0].Cells["PaymentStatus"].Value?.ToString() ?? "";
            bool isPaid = status.Equals("Paid", StringComparison.OrdinalIgnoreCase);

            btnPayment.Enabled = !isPaid;
            btnPayment.Text = isPaid ? "Already Paid" : "Payment";
        }

        private void frmBilling_Load_1(object sender, EventArgs e)
        {
            LoadBillingTable();
            UpdatePaymentButton();
        }
    }
}
