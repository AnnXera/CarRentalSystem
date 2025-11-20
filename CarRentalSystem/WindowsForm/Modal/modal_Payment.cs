using CarRentalSystem.Code;
using CarRentalSystem.Code.Enum;
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
        private readonly Billing _billing;
        private readonly BillingFactory _billingFactory;

        public modal_Payment(Billing billing)
        {
            InitializeComponent();
            _billing = billing ?? throw new ArgumentNullException(nameof(billing));

            _billingFactory = new BillingFactory();
            _billingFactory.SetCurrentBilling(_billing);

            LoadComboBoxes();
            LoadBillingDetails();
        }

        private void LoadBillingDetails()
        {
            if (_billing == null) return;

            lblContractNo.Text = _billing.ContractId.ToString();
            lblCustomerName.Text = _billing.CustomerName ?? "N/A";
            lblCarName.Text = _billing.CarName ?? "N/A";

            lblBillNo.Text = _billing.BillingId.ToString();
            lblBaseRate.Text = _billing.BaseRate.ToString("N2");

            var repo = new AdditionalChargesRepository();
            var charges = repo.GetChargeBreakdown(_billing.ContractId);

            lblCarPartsCharges.Text = charges.PartsTotal.ToString("N2");
            lblLateFee.Text = charges.LateFeeTotal.ToString("N2");
            lblMileageFee.Text = charges.MileageTotal.ToString("N2");
            lblLost.Text = charges.LostTotal.ToString("N2");
            lblTotalChargeFee.Text = (charges.PartsTotal + charges.LostTotal + charges.MileageTotal + charges.LateFeeTotal).ToString("N2");

            lblSecurityDepUsed.Text = (_billing.SecurityDepUsed ?? 0).ToString("N2");
            lblTotalAmount.Text = _billing.TotalAmount.ToString("N2");
            lblPrevAmountPaid.Text = _billing.AmountPaid.ToString("N2");

            lblCurrentAmountDue.Text = _billing.RemainingBalance.ToString("N2");
            lblTextChangeRemainingBalance.Text = _billing.RemainingBalance.ToString("N2"); 

            txtAmountReceived.Focus();
            txtAmountReceived.Select();
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
            try
            {
                ValidatePaymentForm();

                if (!decimal.TryParse(txtAmountReceived.Text, out decimal amountReceived) || amountReceived <= 0)
                    throw new Exception("Please enter a valid amount greater than zero.");

                if (amountReceived > _billing.RemainingBalance)
                {
                    var result = MessageBox.Show(
                        $"Customer paid {amountReceived:N2}, but only {_billing.RemainingBalance:N2} is due.\n\n" +
                        "Accept overpayment and issue change?",
                        "Overpayment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No) return;
                }

                var billing = new Billing
                {
                    BillingId = _billing.BillingId,
                    ContractId = _billing.ContractId,
                    AmountPaid = amountReceived,
                    PaymentMethod = (enum_Payment.PaymentMethod)cbxPaymentMethod.SelectedValue,
                    BillingDate = DateTime.Now,
                    //emarks = txtRemarks?.Text.Trim() ?? ""
                };

                bool success = _billingFactory.RecordPayment(billing);

                if (success)
                {
                    MessageBox.Show("Payment recorded successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to record payment. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modal_Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
