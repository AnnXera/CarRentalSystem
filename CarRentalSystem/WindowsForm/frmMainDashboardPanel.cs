using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmMainDashboardPanel : Form
    {
        public frmMainDashboardPanel()
        {
            InitializeComponent();
            LoginAccess();
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
    }
}
