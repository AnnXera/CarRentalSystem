using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using Org.BouncyCastle.Asn1.Cmp;
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

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_Payment : Form
    {
        private Billing _billing;

        public modal_Payment(Billing billing)
        {
            InitializeComponent();
            _billing = billing;
            LoadComboBoxes();
            LoadBillingDetails();
        }
        private void LoadBillingDetails()
        {
            if (_billing == null) return;

            lblBillNo.Text = _billing.BillingId.ToString();
            lblContractNo.Text = _billing.ContractId.ToString();
            lblCustomerName.Text = _billing.CustomerName;
            lblCarName.Text = _billing.CarName;
            lblBaseRate.Text = _billing.BaseRate.ToString("N2");
            lblTotalAmount.Text = _billing.TotalAmount.ToString("N2");
            lblTotalChargeFee.Text = (_billing.TotalCharges ?? 0).ToString("N2");
            lblSecurityDepUsed.Text = (_billing.SecurityDepUsed ?? 0).ToString("N2");
            lblPrevAmountPaid.Text = _billing.AmountPaid.ToString("N2");
            lblCurrentAmountDue.Text = _billing.RemainingBalance.ToString("N2");
            lblTextChangeRemainingBalance.Text = _billing.RemainingBalance.ToString("N2");

            var repo = new AdditionalChargesRepository();

            var charges = repo.GetChargeBreakdown(_billing.ContractId);

            lblCarPartsCharges.Text = charges.PartsTotal.ToString("N2");
            lblLost.Text = charges.LostTotal.ToString("N2");
            lblMileageFee.Text = charges.MileageTotal.ToString("N2");
            lblLateFee.Text = charges.LateFeeTotal.ToString("N2");

        }

        private void LoadComboBoxes()
        {
            cbxPaymentMethod.DataSource = Enum.GetValues(typeof(Code.Enum.enum_Payment.PaymentMethod));
            cbxPaymentMethod.SelectedIndex = -1;
        }

        private void ClearLabels()
        {
            lblContractNo.Text = "";
            lblCustomerName.Text = "";
            lblCarName.Text = "";
            lblBillNo.Text = "";
            lblBaseRate.Text = "";
            lblCarPartsCharges.Text = "";
            lblLateFee.Text = "";
            lblMileageFee.Text = "";
            lblLost.Text = "";
            lblSecurityDepUsed.Text = "";
            lblTotalAmount.Text = "";
            lblPrevAmountPaid.Text = "";
            lblCurrentAmountDue.Text = "";
            lblTextChangeRemainingBalance.Text = "";
        }

        private void ValidatePaymentForm()
        {
            try
            {
                //Validator.RequireNotEmpty(cbxBrand.Text, "Brand");
                Validator.RequireComboBoxSelected(cbxPaymentMethod, "Payment Method");

                Validator.RequireNotEmpty(txtAmountReceived.Text, "Amount");

            }
            catch (Exception ex)
            {
                throw new Exception($"Validation Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            ValidatePaymentForm();
        }
    }
}
