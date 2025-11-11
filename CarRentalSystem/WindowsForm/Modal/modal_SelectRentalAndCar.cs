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

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_SelectRentalAndCar : Form
    {
        public modal_SelectRentalAndCar()
        {
            InitializeComponent();
            LoadRentalPlans();

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlAvailableCar,
                pnlRentalPlan,
                pnlSearch,
                pnlSeats,
                pnlTransmission
            });
        }
        private void LoadComboboxes()
        {
            // This method can be used to load other comboboxes if needed in the future
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
    }
}
