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
    public partial class modal_AddEditEmployee : Form
    {
        public modal_AddEditEmployee()
        {
            InitializeComponent();

            LoadDesign();
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
    }
}
