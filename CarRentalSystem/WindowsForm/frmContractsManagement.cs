using CarRentalSystem.Utils;
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

namespace CarRentalSystem.WindowsForm
{
    public partial class frmContractsManagement : Form
    {
        public frmContractsManagement()
        {
            InitializeComponent();
            buttonProcessDisabled();

            var panels = new List<Panel> 
            { 
                pnlContractDetails
            };

            UIHelper.ApplyRoundedPanels(panels, 10);
        }

        private void buttonProcessDisabled()
        {
            btnProcessReturn.Enabled = false;
            btnProcessReturn.ForeColor = Color.Gray;
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 10);
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            using (var CreateContract = new modal_CreateContract())
            {
                CreateContract.ShowDialog();
            }
        }
    }
}
