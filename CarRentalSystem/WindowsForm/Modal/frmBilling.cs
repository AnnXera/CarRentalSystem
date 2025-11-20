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
        BillingFactory billingFactory = new BillingFactory();

        private DataTable billingTable;

        public frmBilling()
        {
            InitializeComponent();
            ClearBillingLabels();
            LoadBillingTable();

            btnPayment.Enabled = false;
            btnPayment.ForeColor = Color.Gray;
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

            dgvBilling.AllowUserToAddRows = false;
            dgvBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBilling.RowHeadersVisible = false;
            dgvBilling.AllowUserToResizeRows = false;

            billingTable = new DataTable();
            billingTable.Columns.Add("BillingID", typeof(long));
            billingTable.Columns.Add("ContractID", typeof(long));
            billingTable.Columns.Add("CustomerName");
            billingTable.Columns.Add("CarName");
            billingTable.Columns.Add("BaseRate", typeof(decimal));
            billingTable.Columns.Add("TotalCharges", typeof(decimal));
            billingTable.Columns.Add("SecurityDepUsed", typeof(decimal));
            billingTable.Columns.Add("TotalAmount", typeof(decimal));
            billingTable.Columns.Add("AmountPaid", typeof (decimal));
            billingTable.Columns.Add("RemainingBalance", typeof(decimal));
            billingTable.Columns.Add("PaymentStatus");
            billingTable.Columns.Add("BillingDate", typeof(DateTime));
            billingTable.Columns.Add("Remarks");

            foreach (var b in billings)
            {
                var row = billingTable.NewRow();
                row["BillingID"] = b.BillingId;
                row["ContractID"] = b.ContractId;
                row["CustomerName"] = b.CustomerName;
                row["CarName"] = b.CarName;
                row["BaseRate"] = b.BaseRate;
                row["TotalCharges"] = b.TotalCharges ?? (object)DBNull.Value;
                row["SecurityDepUsed"] = b.SecurityDepUsed ?? (object)DBNull.Value;
                row["TotalAmount"] = b.TotalAmount;
                row["AmountPaid"] = b.AmountPaid;
                row["RemainingBalance"] = b.RemainingBalance;
                row["PaymentStatus"] = b.PaymentStatus;
                row["BillingDate"] = b.BillingDate;
                row["Remarks"] = b.Remarks ?? string.Empty;
                billingTable.Rows.Add(row);
            }

            dgvBilling.DataSource = billingTable;

            dgvBilling.Columns["ContractID"].Visible = false;
            dgvBilling.Columns["CarName"].Visible = false;

            DataView dv = billingTable.DefaultView;
            dv.Sort = "BillingID DESC";

            dgvBilling.DataSource = dv;

            dgvBilling.DefaultCellStyle.NullValue = "NULL";

            dgvBilling.Columns["BaseRate"].DefaultCellStyle.Format = "N2";
            dgvBilling.Columns["TotalCharges"].DefaultCellStyle.Format = "N2";
            dgvBilling.Columns["SecurityDepUsed"].DefaultCellStyle.Format = "N2";
            dgvBilling.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
            dgvBilling.Columns["AmountPaid"].DefaultCellStyle.Format = "N2";
            dgvBilling.Columns["RemainingBalance"].DefaultCellStyle.Format = "N2";

            dgvBilling.Columns["BillingID"].HeaderText = "Billing ID";
            dgvBilling.Columns["CustomerName"].HeaderText = "Customer Name";
            dgvBilling.Columns["BaseRate"].HeaderText = "Base Rate";
            dgvBilling.Columns["TotalCharges"].HeaderText = "Total Charges";
            dgvBilling.Columns["SecurityDepUsed"].HeaderText = "Security Dep Used";
            dgvBilling.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgvBilling.Columns["AmountPaid"].HeaderText = "Amount Paid";
            dgvBilling.Columns["RemainingBalance"].HeaderText = "Remainig Balance";
            dgvBilling.Columns["PaymentStatus"].HeaderText = "Payment Status";
            dgvBilling.Columns["BillingDate"].HeaderText = "Billing Date";
            dgvBilling.Columns["Remarks"].HeaderText = "Remarks";

            dgvBilling.ReadOnly = true;

            dgvBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBilling.Refresh();
        }

        private void DisplayBillingDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;


            lblCustomerName.Text = selectedRow.Cells["CustomerName"].Value?.ToString();
            lblBillingID.Text = selectedRow.Cells["BillingID"].Value?.ToString();

            decimal baseRate = selectedRow.Cells["BaseRate"].Value != DBNull.Value
                ? Convert.ToDecimal(selectedRow.Cells["BaseRate"].Value)
                : 0m;
            lblBaseRate.Text = baseRate.ToString("N2");

            decimal remainingBalance = selectedRow.Cells["RemainingBalance"].Value != DBNull.Value
                ? Convert.ToDecimal(selectedRow.Cells["RemainingBalance"].Value)
                : 0m;
            lblRemainingBalance.Text = remainingBalance.ToString("N2");

            decimal totalAmount = selectedRow.Cells["TotalAmount"].Value != DBNull.Value
                ? Convert.ToDecimal(selectedRow.Cells["TotalAmount"].Value)
                : 0m;
            lblTotalAmount.Text = totalAmount.ToString("N2");

            decimal totalCharges = selectedRow.Cells["TotalCharges"].Value != DBNull.Value
                ? Convert.ToDecimal(selectedRow.Cells["TotalCharges"].Value)
                : 0m;
            lblTotalCharges.Text = totalCharges.ToString("N2");

            lblStatus.Text = selectedRow.Cells["PaymentStatus"].Value?.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvBilling.SelectedRows.Count == 0) return;

            var selectedRow = dgvBilling.SelectedRows[0];

            var billing = new Billing
            {
                BillingId = Convert.ToInt64(selectedRow.Cells["BillingID"].Value),
                ContractId = Convert.ToInt64(selectedRow.Cells["ContractID"].Value),
                CustomerName = selectedRow.Cells["CustomerName"].Value?.ToString() ?? "",
                CarName = selectedRow.Cells["CarName"].Value?.ToString() ?? "",
                BaseRate = Convert.ToDecimal(selectedRow.Cells["BaseRate"].Value),
                TotalCharges = selectedRow.Cells["TotalCharges"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(selectedRow.Cells["TotalCharges"].Value),
                SecurityDepUsed = selectedRow.Cells["SecurityDepUsed"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(selectedRow.Cells["SecurityDepUsed"].Value),
                TotalAmount = Convert.ToDecimal(selectedRow.Cells["TotalAmount"].Value),
                AmountPaid = Convert.ToDecimal(selectedRow.Cells["AmountPaid"].Value),
                RemainingBalance = Convert.ToDecimal(selectedRow.Cells["RemainingBalance"].Value),
                PaymentStatus = selectedRow.Cells["PaymentStatus"].Value?.ToString()
            };

            using (var modalPayment = new modal_Payment(billing))
            {
                var result = modalPayment.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadBillingTable(); // Refresh grid after successful payment
                }
            }
        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header clicks
            {
                DataGridViewRow selectedRow = dgvBilling.Rows[e.RowIndex];
                DisplayBillingDetails(selectedRow);

                btnPayment.Enabled = true;
                btnPayment.ForeColor = Color.FromArgb(4, 126, 175);
            }
        }
    }
}
