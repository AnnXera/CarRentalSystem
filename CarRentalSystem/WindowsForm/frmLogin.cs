using CarRentalSystem.Code;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void pnlBorderPassword_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawBorderInside((Control)sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawBorderInside((Control)sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = new Employee().Login(username, password);

            if (emp != null)
            {
                SessionManager.StartSession(emp);

                MessageBox.Show($"Welcome, {emp.FullName}!");

                this.Hide();
                new frmDashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
