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
using static CarRentalSystem.Code.Enum.enum_Contracts;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmContractsManagement : Form
    {
        public frmContractsManagement()
        {
            InitializeComponent();
            LoadDesign();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlContractDetails,
                pnlContractsOverview,
                pnlSearch,
                pnlComboBox
            };

            UIHelper.ApplyRoundedPanels(panels, 8);

            UIHelper.SetPlaceholder(
                txtSearch,
                "Type search...",
                Color.Gray,                                       // Placeholder text color
                new Font("Segoe UI", 12, FontStyle.Italic),          // Placeholder font
                Color.Black,                                      // Typing color
                new Font("Segoe UI", 12, FontStyle.Regular)       // Typing font
            );

            cbxStatus.DataSource = Enum.GetValues(typeof(ContractStatus));
            cbxStatus.SelectedIndex = -1;
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            using (var Payment = new modal_Payment())
            {
                Payment.ShowDialog();
            }
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            using (var ReturnProcess = new modal_ProcessReturn())
            {
                ReturnProcess.ShowDialog();
            }
        }
    }
}
