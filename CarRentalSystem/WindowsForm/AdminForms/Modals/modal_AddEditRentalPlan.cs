using System;
using System.Collections.Generic;
using CarRentalSystem.Utils;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms.Modals
{
    public partial class modal_AddEditRentalPlan : Form
    {
        public modal_AddEditRentalPlan()
        {
            InitializeComponent();
            LoadDesign();
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
    }
}
