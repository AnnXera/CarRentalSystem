using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.AdminForms;
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

            LoadButtons();

            if (sidebarButtons == null) return;
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnDashboard, Properties.Resources.Icon___Dashboard___Active);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btnDashboard.Text = "";
            btnCustomer.Text = "";
            btnFleet.Text = "";
            btnTransactions.Text = "";
            btnReport.Text = "";
            btnSystemLog.Text = "";
            btnRentalPlans.Text = "";
            btnEmployeeManagement.Text = "";

            frmMainDashboardPanel dashboardPanel = new frmMainDashboardPanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Add the form to your main container panel
            pnlMainDashboard.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();
            dashboardPanel.Show();
        }

        private void LoadButtons()
        {
            sidebarButtons = new List<UIHelper.SidebarButtonConfig>
            {
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnDashboard,
                    ActiveIcon = Properties.Resources.Icon___Dashboard___Active,
                    InactiveIcon = Properties.Resources.Icon___Dashboard___Default,
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnCustomer,
                    ActiveIcon = Properties.Resources.Icon___Customer___Active,
                    InactiveIcon = Properties.Resources.Icon___Customers__Default
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnFleet,
                    ActiveIcon = Properties.Resources.Icon___Cars__Active,
                    InactiveIcon = Properties.Resources.Icon___Cars___Default
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnTransactions,
                    ActiveIcon = Properties.Resources.Icon___Transaction___Active,
                    InactiveIcon = Properties.Resources.Icon___Transaction___Default
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnReport,
                    ActiveIcon = Properties.Resources.Icon___Reports___Active,
                    InactiveIcon = Properties.Resources.Icon___Reports___Default
                },
                new UIHelper.SidebarButtonConfig
                { 
                    Button = btnEmployeeManagement,
                    ActiveIcon = Properties.Resources.Icon___UserManagement___Active,
                    InactiveIcon = Properties.Resources.Icon___UserManagement___Default
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnSystemLog,
                    ActiveIcon = Properties.Resources.Icon___SystemLog___Active,
                    InactiveIcon = Properties.Resources.Icon___SystemLog___Default
                },
                new UIHelper.SidebarButtonConfig
                {
                    Button = btnRentalPlans,
                    ActiveIcon = Properties.Resources.Icon___RentalPlans___Active,
                    InactiveIcon = Properties.Resources.Icon___RentalPlans___Default
                }
            };

            btnTransactions.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnTransactions, Properties.Resources.Icon___Transaction___Active);

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
            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnFleet, Properties.Resources.Icon___Cars__Active);

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
            // Reset and highlight active button
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnCustomer, Properties.Resources.Icon___Customer___Active);

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
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnDashboard, Properties.Resources.Icon___Dashboard___Default);

            // Remove any subforms like customer management
            pnlMainDashboard.Controls
                .OfType<frmMainDashboardPanel>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            frmMainDashboardPanel dashboardPanel = new frmMainDashboardPanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Show the dashboard panels again
            pnlMainDashboard.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();
            dashboardPanel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = SessionManager.LoggedInEmployee;
                if (emp != null)
                {
                    // Log logout action
                    SystemLogger.Log(
                        "Logout",
                        $"{emp.FullName} logged out.",
                        emp.EmpID
                    );
                }
            }
            catch (Exception ex)
            {
                // Optional: handle logging errors
                MessageBox.Show($"Failed to log logout action: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Exit the application
                Application.Exit();
            }
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnEmployeeManagement, Properties.Resources.Icon___UserManagement___Active);

            pnlMainDashboard.Controls
                .OfType<frmEmployeeManagement>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add Employee Management form
            frmEmployeeManagement employeeForm = new frmEmployeeManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(employeeForm);
            employeeForm.BringToFront();
            employeeForm.Show();
        }

        private void btnRentalPlans_Click(object sender, EventArgs e)
        {
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnRentalPlans, Properties.Resources.Icon___RentalPlans___Active);

            pnlMainDashboard.Controls
                .OfType<frmRentalPlanManagement>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add Rental Plan Management form
            frmRentalPlanManagement rentalPlanForm = new frmRentalPlanManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(rentalPlanForm);
            rentalPlanForm.BringToFront();
            rentalPlanForm.Show();
        }

        private void btnSystemLog_Click(object sender, EventArgs e)
        {
            UIHelper.ResetSidebarButtons(sidebarButtons);
            UIHelper.SetActiveButton(btnSystemLog, Properties.Resources.Icon___SystemLog___Active);

            pnlMainDashboard.Controls
                .OfType<frmSystemLog>()
                .ToList()
                .ForEach(f => pnlMainDashboard.Controls.Remove(f));

            // Add System Log form
            frmSystemLog systemLogForm = new frmSystemLog
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMainDashboard.Controls.Add(systemLogForm);
            systemLogForm.BringToFront();
            systemLogForm.Show();
        }
    }
}
