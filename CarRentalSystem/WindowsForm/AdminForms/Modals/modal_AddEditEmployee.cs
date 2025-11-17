using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms.Modals
{
    public partial class modal_AddEditEmployee : Form
    {
        private Employee _isEditMode;

        private string _tempPasswordHash = null;

        public modal_AddEditEmployee()
        {
            InitializeComponent();
            LoadDesign();
            EventChange();
            SetupForNewEmployee();
            KeyHandlers();

            this.Text = "Add New Employee";
            btnSave.Text = "Save";
            btnSetPassword.Enabled = false;
        }

        public modal_AddEditEmployee(Employee editingEmployee) : this()
        {
            _isEditMode = editingEmployee;
            this.Text = "Edit Employee";
            btnSave.Text = "Update";
            btnSetPassword.Enabled = true;

            txtPassword.ReadOnly = true;

            LoadEmployeeData();
        }

        private void EventChange()
        {
            txtFullName.TextChanged += (s, e) =>
            {
                lblEmployeeName.Text = string.IsNullOrWhiteSpace(txtFullName.Text)
                    ? "New Employee"
                    : txtFullName.Text.Trim();
            };
        }

        private void SetupForNewEmployee()
        {
            try
            {
                var empFactory = new EmployeeFactory();
                long nextId = empFactory.EmployeeIDNext();

                lblEmployeeName.Text = "New Customer";
                lblEmployeeID.Text = nextId.ToString();
            }
            catch (Exception ex)
            {
                lblEmployeeName.Text = "New Customer";
                lblEmployeeID.Text = "N/A";
                MessageBox.Show($"Unable to retrieve next Customer ID.\n\nDetails: {ex.Message}",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadEmployeeData()
        {
            if (_isEditMode == null) return;

            lblEmployeeName.Text = _isEditMode.FullName;
            lblEmployeeID.Text = _isEditMode.EmpID.ToString();

            txtFullName.Text = _isEditMode.FullName;
            txtUsername.Text = _isEditMode.Username;
            rdoAdmin.Checked = _isEditMode.Role == "Admin";
            rdoStaff.Checked = _isEditMode.Role == "Staff";

            txtPassword.ReadOnly = true;

            UIHelper.SetPlaceholder(
                txtPassword,
                "Leave blank if no change password...",
                Color.Gray,
                new Font("Segoe UI", 12, FontStyle.Italic),
                Color.Black,
                new Font("Segoe UI", 12, FontStyle.Regular)
            );
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlAddEditEmployee,
                pnlFullName,
                pnlUsername,
                pnlPassword
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void Validators()
        {
            Validator.RequireNotEmpty(txtFullName.Text, "Full Name");
            Validator.ValidateLettersOnly(txtFullName.Text, "Full Name");
            Validator.RequireNotEmpty(txtUsername.Text, "Username");
            Validator.RequireRadioSelected(
                new List<RadioButton> { rdoAdmin, rdoStaff },
                "role"
            );
        }

        private void KeyHandlers()
        {
            txtFullName.KeyPress += (s, e) => InputHandler.AllowLettersOnly(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validators();

                var currentEmp = SessionManager.LoggedInEmployee;
                if (currentEmp == null)
                    throw new Exception("No logged-in employee detected. Please log in again.");

                var empFactory = new EmployeeFactory();
                var empRepo = new EmployeeRepository();

                // Add Mode
                if (_isEditMode == null)
                {

                    if (empRepo.IsUsernameTaken(txtUsername.Text.Trim()))
                    {
                        MessageBox.Show("This username is already taken. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    var newEmployee = new Employee
                    {
                        FullName = txtFullName.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        Password = SecurityHelper.HashPassword(txtPassword.Text),
                        Role = rdoAdmin.Checked ? "Admin" : "Staff"
                    };

                    empFactory.Add(newEmployee);

                    SystemLogger.Log("Add Employee",
                             $"{currentEmp.FullName} updated employee {newEmployee.FullName}.",
                             currentEmp.EmpID);

                    MessageBox.Show($"Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Edit Mode
                else
                {
                    if (empRepo.IsUsernameTaken(txtUsername.Text.Trim(), _isEditMode.EmpID))
                    {
                        MessageBox.Show("This username is already taken. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // stop saving
                    }

                    _isEditMode.FullName = txtFullName.Text.Trim();
                    _isEditMode.Username = txtUsername.Text.Trim();

                    if (_tempPasswordHash != null)
                    {
                        _isEditMode.Password = _tempPasswordHash;
                    }

                    _isEditMode.Role = rdoAdmin.Checked ? "Admin" : "Staff";

                    empFactory.Edit(_isEditMode);

                    SystemLogger.Log("Edit Employee",
                             $"{currentEmp.FullName} updated employee {_isEditMode.FullName}.",
                             currentEmp.EmpID);

                    MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }

            catch
            {
                MessageBox.Show(
                    "An error occurred while saving the employee data",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            using (var resetForm = new modal_ResetPassword())
            {
                if (resetForm.ShowDialog() == DialogResult.OK)
                {
                    _tempPasswordHash = SecurityHelper.HashPassword(resetForm.NewPassword);

                    txtPassword.ReadOnly = true;
                    txtPassword.Text = "Password has been reset";
                    txtPassword.ForeColor = Color.Green;
                    txtPassword.Font = new Font("Segoe UI", 12, FontStyle.Italic);

                    MessageBox.Show("Password updated! Remember to click Save.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
