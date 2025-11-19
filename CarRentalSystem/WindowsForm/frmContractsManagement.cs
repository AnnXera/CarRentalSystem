using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using CarRentalSystem.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_Contracts;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmContractsManagement : Form
    {

        private DataTable contractTable;

        public frmContractsManagement()
        {
            InitializeComponent();
            LoadDesign();
            LoadContracts();
            EventHandlers();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlContractDetails,
                pnlContractsOverview,
                pnlSearch,
                pnlComboBox
            };

            UIHelper.ApplyRoundedPanels(panels, 8);

            cbxStatus.DataSource = Enum.GetValues(typeof(ContractStatus));
            cbxStatus.SelectedIndex = -1;
        }

        private void EventHandlers()
        {
            dgvContracts.ShowCellToolTips = true;

            dgvContracts.CellMouseEnter += dgvContracts_CellMouseEnter;
            dgvContracts.CellMouseLeave += dgvContracts_CellMouseLeave;
            dgvContracts.CellToolTipTextNeeded += dgvContracts_CellToolTipTextNeeded;
            dgvContracts.CellClick += dgvContracts_CellClick;
        }

        private void dgvContracts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvContracts.Columns[e.ColumnIndex].Name;

                if (colName == "Activate" || colName == "Cancel")
                {
                    dgvContracts.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgvContracts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvContracts.Cursor = Cursors.Default;
        }

        private void dgvContracts_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvContracts.Columns[e.ColumnIndex].Name;

                if (colName == "Activate")
                {
                    e.ToolTipText = "Activate";
                }
                else if (colName == "Cancel")
                {
                    e.ToolTipText = "Cancel";
                }
            }
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = dgvContracts.Rows[e.RowIndex].Cells["Status"].Value?.ToString() ?? string.Empty;
            if (status != "Pending") return;

            long contractID = Convert.ToInt64(dgvContracts.Rows[e.RowIndex].Cells["ContractID"].Value);
            var factory = new ContractFactory();

            if (dgvContracts.Columns[e.ColumnIndex].Name == "Activate")
            {
                if (MessageBox.Show("Are you sure you want to activate this contract?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    factory.Edit(contractID, "Active");
                    LoadContracts();
                }
            }
            else if (dgvContracts.Columns[e.ColumnIndex].Name == "Cancel")
            {
                if (MessageBox.Show("Are you sure you want to cancel this contract?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    factory.CancelContract(contractID);
                    LoadContracts();
                }
            }
        }

        private void LoadContracts()
        {
            var factory = new ContractFactory();
            var contracts = factory.ViewAll();

            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContracts.RowHeadersVisible = false;
            dgvContracts.AllowUserToResizeRows = false;

            contractTable = new DataTable();
            contractTable.Columns.Add("ContractID", typeof(long));
            contractTable.Columns.Add("CustomerName");
            contractTable.Columns.Add("EmployeeName");
            contractTable.Columns.Add("CarName");
            contractTable.Columns.Add("StartDate", typeof(DateTime));
            contractTable.Columns.Add("ReturnDate", typeof(DateTime));
            contractTable.Columns.Add("DaysRented", typeof(int));
            contractTable.Columns.Add("StartMileage", typeof(int));
            contractTable.Columns.Add("EndMileage", typeof(long));
            contractTable.Columns.Add("DateProcessed", typeof(DateTime));
            contractTable.Columns.Add("IsOverdue", typeof(bool));
            contractTable.Columns.Add("Status");

            foreach (var c in contracts)
            {
                var row = contractTable.NewRow();
                row["ContractID"] = c.ContractID;
                row["CustomerName"] = c.CustomerName ?? string.Empty;
                row["EmployeeName"] = c.EmployeeName ?? string.Empty;
                row["CarName"] = c.CarName ?? string.Empty;
                row["StartDate"] = c.StartDate;
                row["ReturnDate"] = c.ReturnDate;
                row["DaysRented"] = c.DaysRented;
                row["StartMileage"] = c.StartMileage;
                row["EndMileage"] = c.EndMileage ?? (object)DBNull.Value;
                row["DateProcessed"] = c.DateProcessed ?? (object)DBNull.Value;
                row["IsOverdue"] = c.IsOverdue;
                row["Status"] = c.Status ?? string.Empty;
                contractTable.Rows.Add(row);
            }

            dgvContracts.DataSource = contractTable;

            // ✔ Only ONE DataView declaration
            DataView dv = contractTable.DefaultView;
            dv.Sort = "StartDate DESC";

            dgvContracts.DataSource = dv;

            dgvContracts.DefaultCellStyle.NullValue = "NULL";

            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
            {
                Name = "IsOverdue",
                HeaderText = "Is Overdue?",
                DataPropertyName = "IsOverdue",
                ReadOnly = true
            };

            int index = dgvContracts.Columns["IsOverdue"].Index;
            dgvContracts.Columns.Remove("IsOverdue");
            dgvContracts.Columns.Insert(index, chkCol);

            // Rename columns
            dgvContracts.Columns["ContractID"].HeaderText = "Contract ID";
            dgvContracts.Columns["CustomerName"].HeaderText = "Customer Name";
            dgvContracts.Columns["EmployeeName"].HeaderText = "Created By";
            dgvContracts.Columns["CarName"].HeaderText = "Car Name";
            dgvContracts.Columns["StartDate"].HeaderText = "Start Date";
            dgvContracts.Columns["ReturnDate"].HeaderText = "Return Date";
            dgvContracts.Columns["DaysRented"].HeaderText = "Days Rented";
            dgvContracts.Columns["StartMileage"].HeaderText = "Start Mileage";
            dgvContracts.Columns["EndMileage"].HeaderText = "End Mileage";
            dgvContracts.Columns["DateProcessed"].HeaderText = "Date Processed";
            dgvContracts.Columns["IsOverdue"].HeaderText = "Is Overdue?";
            dgvContracts.Columns["Status"].HeaderText = "Status";

            if (dgvContracts.Columns.Contains("Activate"))
                dgvContracts.Columns.Remove("Activate");

            if (dgvContracts.Columns.Contains("Cancel"))
                dgvContracts.Columns.Remove("Cancel");

            var activateColumn = new DataGridViewImageColumn
            {
                Name = "Activate",
                HeaderText = "",
                Image = Properties.Resources.CheckIcon,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40,
                ToolTipText = "Activate Contract"
            };

            var cancelColumn = new DataGridViewImageColumn
            {
                Name = "Cancel",
                HeaderText = "",
                Image = Properties.Resources.XIcon,
                Width = 40,
                ToolTipText = "Cancel Contract"
            };

            dgvContracts.Columns.Insert(0, cancelColumn);
            dgvContracts.Columns.Insert(0, activateColumn);

            foreach (DataGridViewRow row in dgvContracts.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? string.Empty;

                if (status != "Pending")
                {
                    // Gray out icons
                    row.Cells["Activate"].Value = Properties.Resources.CheckIcon___Disabled;
                    row.Cells["Cancel"].Value = Properties.Resources.XIcon___Disabled;

                    // Make them read-only
                    row.Cells["Activate"].ReadOnly = true;
                    row.Cells["Cancel"].ReadOnly = true;

                    // Optional: show tooltip
                    row.Cells["Activate"].ToolTipText = "Cannot activate (status is not pending)";
                    row.Cells["Cancel"].ToolTipText = "Cannot cancel (status is not pending)";
                }
                else
                {
                    // Set normal icons
                    row.Cells["Activate"].Value = Properties.Resources.CheckIcon;
                    row.Cells["Cancel"].Value = Properties.Resources.XIcon;
                    row.Cells["Activate"].ReadOnly = false;
                    row.Cells["Cancel"].ReadOnly = false;
                    row.Cells["Activate"].ToolTipText = "Activate this contract";
                    row.Cells["Cancel"].ToolTipText = "Cancel this contract";
                }
            }

            dgvContracts.ReadOnly = true;

            dgvContracts.Refresh();
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            using (var CreateContract = new modal_CreateContract())
            {
                CreateContract.ShowDialog();
                LoadContracts();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            using (var Payment = new modal_Payment())
            {
                Payment.ShowDialog();
            }
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            using (var ReturnProcess = new modal_ProcessReturn())
            {
                ReturnProcess.ShowDialog();
                LoadContracts();
            }
        }

        private void dgvContracts_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }
    }
}
