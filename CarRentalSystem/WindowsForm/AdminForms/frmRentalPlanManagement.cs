using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmRentalPlanManagement : Form
    {
        public frmRentalPlanManagement()
        {
            InitializeComponent();
            LoadDesign();
            LoadRentalPlans();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlRentalPlanView,
                pnlSearch
            };
            Utils.UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void dgvRentalPlan_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void LoadRentalPlans()
        {
            try
            {
                var repo = new RentalPlanRepository();
                var plans = repo.GetAllPlans();

                cbxRentalPlan.DataSource = plans;
                cbxRentalPlan.DisplayMember = "PlanName";
                cbxRentalPlan.ValueMember = "PlanID";
                cbxRentalPlan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load rental plans.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRentalPlan_Click(object sender, System.EventArgs e)
        {
            using (var addRentalPlanModal = new Modals.modal_AddEditRentalPlan())
            {
                addRentalPlanModal.ShowDialog();
            }
        }
    }
}
