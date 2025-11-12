using CarRentalSystem.Utils;
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
    public partial class frmDashboard : Form
    {
        private List<UIHelper.SidebarButtonConfig> sidebarButtons;

        public frmDashboard()
        {
            InitializeComponent();

            var loggedInEmployee = SessionManager.LoggedInEmployee;
            AccessManager.ApplyAccessRules(this, loggedInEmployee);

            if (SessionManager.IsLoggedIn)
            {
                var emp = SessionManager.LoggedInEmployee;
                lblUserName.Text = emp.Username;
                lblRole.Text = emp.Role;
            }

            sidebarButtons = new List<UIHelper.SidebarButtonConfig>
            {
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnDashboard,
                    ActiveIcon = Properties.Resources.Icon___Dashboard___Default,
                    InactiveIcon = Properties.Resources.Icon___Dashboard___Active
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnCustomer,
                    ActiveIcon = Properties.Resources.Icon___Customer___Default,
                    InactiveIcon = Properties.Resources.Icon___Customer___Active
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnFleet,
                    ActiveIcon = Properties.Resources.Icon___Cars___Default,
                    InactiveIcon = Properties.Resources.Icon___Cars__Active
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnTransactions,
                    ActiveIcon = Properties.Resources.Icon_Contract___Active,
                    InactiveIcon = Properties.Resources.Icon_Contract___Inactive
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnReport,
                    ActiveIcon = Properties.Resources.Icon___Reports___Active,
                    InactiveIcon = Properties.Resources.Icon___Reports___Inactive
                }
            };

            // highlight Dashboard as active on startup
            if (sidebarButtons == null) return;
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnDashboard, Properties.Resources.Icon___Dashboard___Default);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btnDashboard.Text = "";
            btnCustomer.Text = "";
            btnFleet.Text = "";
            btnTransactions.Text = "";
            btnReport.Text = "";

            lblDashboard.Text = "Dashboard";

            // Group all dashboard panels and apply design at once
            var panels = new List<Panel>
            {
                pnlMainDashboard,
                pnlFleetOverView,
                pnlAdmin,
                pnlAverageDailyRate,
                pnlFleetOverView,
                pnlFleetUtilization,
                pnlOverdueVehicles,
                pnlRentalsDueToday,
                pnlReturnsDueToday,
                pnlRevenue,
                pnlVehiclesAvailable
            };

            UIHelper.ApplyRoundedPanels(panels, 15, false);
        }

        private void ShowDashboardPanels(bool visible)
        {
            pnlAdmin.Visible = visible;
            pnlFleetOverView.Visible = visible;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = "Contracts";

            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnTransactions, Properties.Resources.Icon_Contract___Active);

            // Hide existing dashboard panels
            ShowDashboardPanels(false);

            pnlMainDashboard.Controls
                .OfType<frmContractsManagement>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add Contracts form
            frmContractsManagement contractsForm = new frmContractsManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(contractsForm);
            contractsForm.BringToFront();
            contractsForm.Show();

        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = "Car Management";

            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnFleet, Properties.Resources.Icon___Cars___Default);

            // Hide existing dashboard panels
            ShowDashboardPanels(false);

            // If there's already a fleet form, remove it to avoid duplicates
            pnlMainDashboard.Controls
                .OfType<frmFleetManagement>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add Fleet form
            frmFleetManagement fleetForm = new frmFleetManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(fleetForm);
            fleetForm.BringToFront();
            fleetForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = "Customer Management";

            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnCustomer, Properties.Resources.Icon___Customer___Default);

            // Hide existing dashboard panels
            ShowDashboardPanels(false);

            // If there's already a customer form, remove it to avoid duplicates
            pnlMainDashboard.Controls
                .OfType<frmCustomerManagement>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add Customer form
            frmCustomerManagement customerForm = new frmCustomerManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(customerForm);
            customerForm.BringToFront();
            customerForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = "Dashboard";

            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnDashboard, Properties.Resources.Icon___Dashboard___Default);

            // Remove any subforms like customer management
            pnlMainDashboard.Controls
                .OfType<Form>()
                .Where(f => f.Name != "pnlAdmin" && f.Name != "pnlFleetOverView")
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Show the dashboard panels again
            ShowDashboardPanels(true);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
