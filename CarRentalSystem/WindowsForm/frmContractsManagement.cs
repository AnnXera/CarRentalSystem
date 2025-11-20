using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using CarRentalSystem.Code;
using System;
using System.Collections.Generic;
using System.Data;
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
            ClearLabels();
            LoadDesign();
            EventHandlers();
            LoadContracts();
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

            dgvContracts.DataBindingComplete += dgvContracts_DataBindingComplete;
            dgvContracts.CellMouseEnter += dgvContracts_CellMouseEnter;
            dgvContracts.CellMouseLeave += dgvContracts_CellMouseLeave;
            dgvContracts.CellToolTipTextNeeded += dgvContracts_CellToolTipTextNeeded;
            dgvContracts.CellClick += dgvContracts_CellClick;
            txtSearch.TextChanged += FilterContracts;
            cbxStatus.SelectedIndexChanged += FilterContracts;
        }

        private void ClearLabels()
        {
            lblCar.Text = "";
            lblDaysRented.Text = "";
            lblRentalPlanName.Text = "";
            lblReturnDate.Text = "";
            lblStarDate.Text = "";
            lblStatus.Text = "";
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
                Width = 40
            };

            var cancelColumn = new DataGridViewImageColumn
            {
                Name = "Cancel",
                HeaderText = "",
                Image = Properties.Resources.XIcon,
                Width = 40
            };

            dgvContracts.Columns.Insert(0, cancelColumn);
            dgvContracts.Columns.Insert(0, activateColumn);

            dgvContracts.DataSource = contractTable;

            DataView dv = contractTable.DefaultView;
            dv.Sort = "ContractID DESC";

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

            dgvContracts.Columns["EmployeeName"].Visible = false;
            dgvContracts.Columns["StartMileage"].Visible = false;

            dgvContracts.ReadOnly = true;

            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvContracts.Refresh();
        }

        private void dgvContracts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvContracts.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? string.Empty;

                if (status != "Pending")
                {
                    row.Cells["Activate"].Value = Properties.Resources.CheckIcon___Disabled;
                    row.Cells["Cancel"].Value = Properties.Resources.XIcon___Disabled;
                    row.Cells["Activate"].ReadOnly = true;
                    row.Cells["Cancel"].ReadOnly = true;
                }
                else
                {
                    row.Cells["Activate"].Value = Properties.Resources.CheckIcon;
                    row.Cells["Cancel"].Value = Properties.Resources.XIcon;
                    row.Cells["Activate"].ReadOnly = false;
                    row.Cells["Cancel"].ReadOnly = false;
                }
            }
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

            var row = dgvContracts.Rows[e.RowIndex];

            lblCar.Text = row.Cells["CarName"].Value?.ToString() ?? "";
            lblDaysRented.Text = row.Cells["DaysRented"].Value?.ToString() ?? "";
            lblRentalPlanName.Text = row.Cells["EmployeeName"].Value?.ToString() ?? ""; // Adjust if needed
            lblReturnDate.Text = row.Cells["ReturnDate"].Value != DBNull.Value
                ? Convert.ToDateTime(row.Cells["ReturnDate"].Value).ToString("yyyy-MM-dd")
                : "";
            lblStarDate.Text = row.Cells["StartDate"].Value != DBNull.Value
                ? Convert.ToDateTime(row.Cells["StartDate"].Value).ToString("yyyy-MM-dd")
                : "";
            lblStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";

            string status = row.Cells["Status"].Value?.ToString() ?? string.Empty;

            // Only allow actions on pending contracts
            if (status != "Pending") return;

            long contractID = Convert.ToInt64(row.Cells["ContractID"].Value);
            string customerName = row.Cells["CustomerName"].Value?.ToString() ?? "Unknown";
            string carName = row.Cells["CarName"].Value?.ToString() ?? "Unknown";

            var factory = new ContractFactory();

            if (dgvContracts.Columns[e.ColumnIndex].Name == "Activate")
            {
                if (MessageBox.Show("Are you sure you want to activate this contract?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    factory.Edit(contractID, "Active");
                    LoadContracts();

                    SystemLogger.Log(
                        "Activate Contract",
                        $"{SessionManager.LoggedInEmployee.FullName} activated contract {contractID} for {customerName} ({carName})",
                        SessionManager.LoggedInEmployee.EmpID
                    );
                }
            }
            else if (dgvContracts.Columns[e.ColumnIndex].Name == "Cancel")
            {
                if (MessageBox.Show("Are you sure you want to cancel this contract?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    factory.CancelContract(contractID);
                    LoadContracts();

                    SystemLogger.Log(
                        "Cancel Contract",
                        $"{SessionManager.LoggedInEmployee.FullName} canceled contract {contractID} for {customerName} ({carName})",
                        SessionManager.LoggedInEmployee.EmpID
                    );
                }
            }
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            using (var CreateContract = new modal_CreateContract())
            {
                CreateContract.ShowDialog();
                LoadContracts();
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

        private void FilterContracts(object sender, EventArgs e)
        {
            if (contractTable == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string status = cbxStatus.SelectedItem?.ToString() ?? "";

            List<string> filters = new List<string>();

            // Search filter (Customer, Car, ContractID)
            if (!string.IsNullOrEmpty(search))
            {
                filters.Add($@"
                    CustomerName LIKE '%{search}%'
                ");
            }

            // Status filter
            if (!string.IsNullOrEmpty(status))
            {
                filters.Add($"Status = '{status}'");
            }

            string finalFilter = string.Join(" AND ", filters);

            (dgvContracts.DataSource as DataView).RowFilter = finalFilter;
        }


    }
}
