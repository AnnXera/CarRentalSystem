using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.AdminForms.Modals;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();

            LoadDesign();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlEmployeeView,
                pnlSearch
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void dgvEmployees_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var addEmployeeModal = new modal_AddEditEmployee())
            {
                addEmployeeModal.ShowDialog();
            }
        }
    }
}
