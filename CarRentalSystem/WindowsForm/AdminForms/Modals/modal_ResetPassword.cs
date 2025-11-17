using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Utils;

namespace CarRentalSystem.WindowsForm.AdminForms.Modals
{
    public partial class modal_ResetPassword : Form
    {
        public string NewPassword { get; private set; }

        public modal_ResetPassword()
        {
            InitializeComponent();

            LoadDesign();
            LoadDefaults();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlResetPassword,
                pnlNewPassword,
                pnlConfirmPassword
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void LoadDefaults()
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            chbxShowPassword.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            NewPassword = txtNewPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chbxShowPassword.Checked;

            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
