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
        }

        private void AddMode()
        {
            this.Text = "Add New Rental Plan";
            lblTitle.Text = "Add New Rental Plan";
            btnSaveRentalPlan.Text = "Save";

            UIHelper.SetPlaceholder(
                txtPlanName,
                "Input Plan Name",
                Color.Gray,
                new Font("Segoe UI", 12, FontStyle.Italic),
                Color.Black,
                new Font("Segoe UI", 12, FontStyle.Regular)
            );

            UIHelper.SetPlaceholder(
                txtDailyRate,
                "Input Daily Rate",
                Color.Gray,
                new Font("Segoe UI", 12, FontStyle.Italic),
                Color.Black,
                new Font("Segoe UI", 12, FontStyle.Regular)
            );

            UIHelper.SetPlaceholder(
                txtMileageLimit,
                "No limit if left blank...",
                Color.Gray,
                new Font("Segoe UI", 12, FontStyle.Italic),
                Color.Black,
                new Font("Segoe UI", 12, FontStyle.Regular)
            );

            UIHelper.SetPlaceholder(
                txtDescription,
                "Optional Description",
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
                pnlAddEditRentalPlan,
                pnlDailyRate,
                pnlDescription,
                pnlMileageLimit,
                pnlPlanName
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
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
            Validator.RequireNotEmpty(txtMileageLimit.Text, "Mileage Limit");
            Validator.RequireNotEmpty(txtDailyRate.Text, "Daily Rate");
            Validator.RequireNotEmpty(txtExcessLimit.Text, "Excess Fee Per Limit");

            // Integer
            Validator.ValidatePositiveInteger(txtMileageLimit.Text, "Mileage Limit");

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
                        MessageBox.Show("This plan name is already taken. Please choose another.",
                                        "Duplicate Plan Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var rentalPlan = new RentalPlan
                    {
                        PlanName = txtPlanName.Text.Trim(),
                        DailyRate = decimal.Parse(txtDailyRate.Text.Trim()),
                        MileageLimitPerDay = string.IsNullOrWhiteSpace(txtMileageLimit.Text) ? (int?)null : int.Parse(txtMileageLimit.Text.Trim()),
                        Description = txtDescription.Text.Trim(),
                        ExcessFeePerKm = decimal.Parse(txtExcessLimit.Text.Trim())
                    };

                    rentalPlanFactory.Add(rentalPlan);
                }

                else
                {

                }
            }

            catch
            {

            }
        }
    }
}
