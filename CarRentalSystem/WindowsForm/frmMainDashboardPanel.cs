using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmMainDashboardPanel : Form
    {
        CarFactory carFactory = new CarFactory();
        ContractFactory contractFactory = new ContractFactory();
        BillingLogFactory billingLogFactory = new BillingLogFactory();

        private DataTable activeRentalTable;

        public frmMainDashboardPanel()
        {
            InitializeComponent();
            LoginAccess();
            LoadData();
            LoadPanels();
            Timer();
        }

        private void LoginAccess()
        {
            var loggedInEmployee = SessionManager.LoggedInEmployee;
            AccessManager.ApplyAccessRules(this, loggedInEmployee);

            if (SessionManager.IsLoggedIn)
            {
                var emp = SessionManager.LoggedInEmployee;
                lblUserName.Text = emp.Username;
                lblRole.Text = emp.Role;
            }
        }

        private void Timer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, e) =>
            {
                lblTodayDate.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, hh:mm tt");
            };
            timer.Start();
        }

        private void LoadData()
        {

            lblAvailableCars.Text = carFactory.GetCountAvailableCars().ToString("N0");
            lblRentalsDueToday.Text = contractFactory.GetRentalsDueToday().ToString();
            lblReturnsDueToday.Text = contractFactory.GetReturnsDueToday().ToString();
            lblOverdueVehicles.Text = contractFactory.GetOverdueVehicles().ToString();

            decimal utilization = carFactory.GetFleetUtilization();
            lblFleetUtilization.Text = $"{utilization:0.00} %";

            LoadRevenueAndAvgRate();

            var rentals = contractFactory.GetActiveRentalsSimple();

            dgvActiveRentals.AllowUserToAddRows = false;
            dgvActiveRentals.AllowUserToAddRows = false;
            dgvActiveRentals.RowHeadersVisible = false;
            dgvActiveRentals.AllowUserToResizeRows = false;

            activeRentalTable = new DataTable();
            activeRentalTable.Columns.Add("ContractNum", typeof(long));
            activeRentalTable.Columns.Add("CarNo", typeof(long));
            activeRentalTable.Columns.Add("CustomerName");
            activeRentalTable.Columns.Add("ReturnDate");

            foreach (var r in rentals)
            {
                var row = activeRentalTable.NewRow();
                row["ContractNum"] = r.ContractID;
                row["CarNo"] = r.CarID;
                row["CustomerName"] = r.CustomerName;
                row["ReturnDate"] = r.ReturnDate;
                activeRentalTable.Rows.Add(row);
            }

            dgvActiveRentals.DataSource = activeRentalTable;

            dgvActiveRentals.Columns["ContractNum"].HeaderText = "No.";
            dgvActiveRentals.Columns["CarNo"].HeaderText = "Car no.";
            dgvActiveRentals.Columns["CustomerName"].HeaderText = "Renter";
            dgvActiveRentals.Columns["ReturnDate"].HeaderText = "Return Date";

            dgvActiveRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvActiveRentals.Columns["ContractNum"].FillWeight = 15;
            dgvActiveRentals.Columns["CarNo"].FillWeight = 15;
            dgvActiveRentals.Columns["CustomerName"].FillWeight = 40;
            dgvActiveRentals.Columns["ReturnDate"].FillWeight = 30;

            dgvActiveRentals.ReadOnly = true;

            dgvActiveRentals.Refresh();
        }

        private void LoadRevenueAndAvgRate()
        {
            try
            {
                decimal revenueMTD = billingLogFactory.GetRevenueMTD();
                decimal avgDailyRate = billingLogFactory.GetAvgDailyRate();

                lblRevenueMTD.Text = revenueMTD.ToString("N2");     // Format as currency
                lblDailyAvgRate.Text = avgDailyRate.ToString("N2"); // Format as currency
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load revenue data: " + ex.Message);
                lblRevenueMTD.Text = "0.00";
                lblDailyAvgRate.Text = "0.00";
            }
        }

        private void LoadPanels()
        {
            var panels = new List<Panel>
            {
                pnlQuickActions,
                pnlOverView,
                pnlAdminOverview,
                pnlAvgDailyRate,
                pnlFleetUtilization,
                pnlOverviewVehicles,
                pnlRentalsDue,
                pnlReturnsDueToday,
                pnlRevenue,
                pnlVehiclesAvailable,
                pnlSearchActiveRentals,
            };

            UIHelper.ApplyRoundedPanels(panels, 8, false);
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            using (var CreateContract = new modal_CreateContract())
            {
                CreateContract.ShowDialog();
            }
        }

        private void dgvActiveRentals_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnProcessContract_Click(object sender, EventArgs e)
        {
            using (var ProcessContract = new modal_ProcessReturn())
            {
                ProcessContract.ShowDialog();
            }
        }

        private void txtSearchActiveRentals_TextChanged(object sender, EventArgs e)
        {
            if (activeRentalTable == null) return;

            string filterText = txtSearchActiveRentals.Text.Trim().Replace("'", "''");
            DataView dv = activeRentalTable.DefaultView;

            if (string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = ""; 
            }
            else
            {
                dv.RowFilter = $"CustomerName LIKE '%{filterText}%'";
            }

            dgvActiveRentals.DataSource = dv;
        }
    }
}
