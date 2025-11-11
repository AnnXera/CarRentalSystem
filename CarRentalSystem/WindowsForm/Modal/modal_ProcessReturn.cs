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
    public partial class modal_ProcessReturn : Form
    {
        public modal_ProcessReturn()
        {
            InitializeComponent();
            LoadPanels();
        }

        private void LoadPanels()
        {
            var panels = new List<Panel>
            {
                pnlCustomer,
                pnlCharges,
                pnlBilling
            };
            UIHelper.ApplyRoundedPanels(panels, 10);

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlSearch,
                pnlCarPartsSearch,
                pnlMileage,
                pnlSecurityDeposit,
                pnlCarPartsSearch
            });
        }

        private void btnFinalizePayment_Click(object sender, EventArgs e)
        {
            var paymentModal = new modal_Payment();
            paymentModal.ShowDialog();
        }
    }
}
