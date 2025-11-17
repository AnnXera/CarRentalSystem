using CarRentalSystem.Code;
using CarRentalSystem.Database;
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
using static CarRentalSystem.Code.Enum.enum_Car;

namespace CarRentalSystem.WindowsForm.AdminForms.Modals
{
    public partial class modal_AddEditRentalPlan : Form
    {
        private RentalPlan _isEditMode;
        public modal_AddEditRentalPlan()
        {
            InitializeComponent();
            LoadDesign();
            AddMode();
            KeyHandlers();
        }

        public modal_AddEditRentalPlan(RentalPlan rentalPlan) : this()
        {
            _isEditMode = rentalPlan;

            this.Text = "Edit Rental Plan";
            lblTitle.Text = "Edit Rental Plan";
            btnSaveRentalPlan.Text = "Update";

            LoadRentalPlanData();
        }

        private void AddMode()
        {
            this.Text = "Add New Rental Plan";
            lblTitle.Text = "Add New Rental Plan";
            btnSaveRentalPlan.Text = "Save";
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlAddEditRentalPlan,
                pnlDailyRate,
                pnlDescription,
                pnlMileageLimit,
                pnlPlanName,
                pnlExcessFee
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void LoadRentalPlanData()
        {
            if (_isEditMode == null) return;

            txtPlanName.Text = _isEditMode.PlanName;
            txtDailyRate.Text = _isEditMode.DailyRate.ToString();
            txtMileageLimit.Text = _isEditMode.MileageLimitPerDay?.ToString() ?? string.Empty;
            txtDescription.Text = _isEditMode.Description;
            txtExcessLimit.Text = _isEditMode.ExcessFeePerKm.ToString();
        }

        private void KeyHandlers()
        {
            txtPlanName.KeyPress += (s, e) => InputHandler.AllowLettersOnly(e);
            txtMileageLimit.KeyPress += (s, e) => InputHandler.AllowOnlyInteger(e);
            txtDailyRate.KeyPress += (s, e) => InputHandler.AllowDecimal(e, txtDailyRate);
            txtExcessLimit.KeyPress += (s, e) => InputHandler.AllowDecimal(e, txtExcessLimit);
        }

        private void Validators()
        {
            // Not Empty
            Validator.RequireNotEmpty(txtPlanName.Text, "Plan Name");
            Validator.RequireNotEmpty(txtDailyRate.Text, "Daily Rate");
            Validator.RequireNotEmpty(txtExcessLimit.Text, "Excess Fee Per Limit");

            //Integer with Decimal
            Validator.ValidateDecimal(txtDailyRate.Text, "Daily Rate");
            Validator.ValidateDecimal(txtExcessLimit.Text, "Excess Fee Per Limit");

            //Letters Only
            Validator.ValidateLettersOnly(txtPlanName.Text, "Plan Name");
        }

        private void btnSaveRentalPlan_Click(object sender, EventArgs e)
        {
            try
            {
                Validators();

                var currentEmp = SessionManager.LoggedInEmployee;
                if (currentEmp == null)
                    throw new Exception("No logged-in employee detected. Please log in again.");

                var rentalPlanFactory = new RentalPlanFactory();

                //Add Mode
                if (_isEditMode == null)
                {
                    if (rentalPlanFactory.CheckPlanName(txtPlanName.Text.Trim()))
                    {
                        MessageBox.Show("This plan name is already taken.", "Duplicate Plan Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var rentalPlan = new RentalPlan
                    {
                        PlanName = txtPlanName.Text.Trim(),
                        DailyRate = decimal.Parse(txtDailyRate.Text),
                        MileageLimitPerDay = string.IsNullOrWhiteSpace(txtMileageLimit.Text) ? (long?)null : long.Parse(txtMileageLimit.Text),
                        Description = txtDescription.Text.Trim(),
                        ExcessFeePerKm = decimal.Parse(txtExcessLimit.Text)
                    };

                    rentalPlanFactory.Add(rentalPlan);

                    SystemLogger.Log("Add Rental Plan",
                             $"{currentEmp.FullName} created a Rental Plan '{rentalPlan.PlanName}'.",
                             currentEmp.EmpID);

                    MessageBox.Show("Rental Plan added successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    if (rentalPlanFactory.CheckPlanName(txtPlanName.Text.Trim(), _isEditMode.PlanID))
                    {
                        MessageBox.Show("This plan name is already taken.", "Duplicate Plan Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _isEditMode.PlanName = txtPlanName.Text.Trim();
                    _isEditMode.DailyRate = decimal.Parse(txtDailyRate.Text);
                    _isEditMode.MileageLimitPerDay = string.IsNullOrWhiteSpace(txtMileageLimit.Text) ? (long?)null : long.Parse(txtMileageLimit.Text);
                    _isEditMode.Description = txtDescription.Text.Trim();
                    _isEditMode.ExcessFeePerKm = decimal.Parse(txtExcessLimit.Text);

                    rentalPlanFactory.Edit(_isEditMode);

                    SystemLogger.Log("Edit Rental Plan",
                             $"{currentEmp.FullName} edited the Rental Plan '{_isEditMode.PlanName}'.",
                             currentEmp.EmpID);

                    MessageBox.Show("Rental Plan updated successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

            }

            catch
            {
                MessageBox.Show("Failed to save Rental Plan. Please check your inputs and try again.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
