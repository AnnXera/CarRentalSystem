using CarRentalSystem.Code;
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

        private void LoadCustomerDropdown()
        {
            var factory = new ContractFactory();
            var activeContracts = factory.GetActiveContracts();

            cbxSearch.DataSource = activeContracts;
            cbxSearch.DisplayMember = "CustomerName";
            cbxSearch.ValueMember = "ContractID";
            cbxSearch.SelectedIndex = -1;

            cbxSearch.DropDownStyle = ComboBoxStyle.DropDown;
            cbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnFinalizePayment_Click(object sender, EventArgs e)
        {
            var paymentModal = new modal_Payment();
            paymentModal.ShowDialog();
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedItem is Contracts selected)
            {
                lblFullName.Text = selected.CustomerName;
                lblCarName.Text = selected.CarName;
                lblRegisteredEmployee.Text = selected.EmployeeName;
                lblSecurityDeposit.Text = selected.DepositAmount.ToString("N2");
                lblBaseRate.Text = (selected.BaseRate ?? 0).ToString("N2");
            }
        }
    }
}
