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
    public partial class frmMainDashboardPanel : Form
    {
        public frmMainDashboardPanel()
        {
            InitializeComponent();
            LoginAccess();
            LoadPanels();
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

        private void LoadPanels()
        {
            var panels = new List<Panel> 
            { 
                pnlQuickActions
            };

            UIHelper.ApplyRoundedPanels(panels, 8, false);
        }

        private void btnCustomerAddEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
