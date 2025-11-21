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
        BillingFactory billingFactory = new BillingFactory();

        private Billing _billing;

        decimal amountReceived;
        decimal amountToApply;
        decimal change;
        long empId;

        public modal_Payment(Billing billing)
        {
            InitializeComponent();

            _billing = billing;

            ClearLabels();
            LoadComboBoxes();
            LoadBillingDetails();
            KeyHandlers();
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
        }

        private void ValidatePaymentForm()
        {
            try
            {
                Validator.RequireComboBoxSelected(cbxPaymentMethod, "Payment Method");
                Validator.ValidateLettersOnly(cbxPaymentMethod.Text, "Payment Method");

                Validator.RequireNotEmpty(txtAmountReceived.Text, "Amount");
                Validator.ValidateInteger(txtAmountReceived.Text, "Amount");

            }
            catch (Exception ex)
            {
                throw new Exception($"Validation Error: {ex.Message}");
            }
        }

        private void KeyHandlers()
        {
            txtAmountReceived.KeyPress += (s, e) => InputHandler.AllowDecimal(e, txtAmountReceived);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (_billing == null) return;

            try
            {
                if (!SessionManager.IsLoggedIn)
                    throw new Exception("No employee is logged in.");

                empId = SessionManager.LoggedInEmployee.EmpID;

                // 1. Validate form
                ValidatePaymentForm();

                // 2. Parse amount received
                decimal amountReceived = decimal.Parse(txtAmountReceived.Text);

                // 3. Calculate amount to apply (cannot exceed remaining balance)
                decimal amountToApply = Math.Min(amountReceived, _billing.RemainingBalance);

                // 4. Update billing via repository/factory
                var billingFactory = new BillingFactory();
                billingFactory.Edit(_billing, cbxPaymentMethod.SelectedItem.ToString(), amountToApply);

                // 5. Calculate change to give back
                change = amountReceived - amountToApply;
                if (change > 0)
                {
                    MessageBox.Show($"Change to return: {change:N2}", "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SystemLogger.Log(
                    "Process Payment",
                    $"{SessionManager.LoggedInEmployee.FullName} processed payment of {_billing.CustomerName}.",
                    SessionManager.LoggedInEmployee.EmpID
                );

                // 6. Close modal
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            if (_billing == null) return;

            decimal amountReceived = 0;
            decimal.TryParse(txtAmountReceived.Text, out amountReceived);

            decimal remainingBalance = _billing.RemainingBalance - amountReceived;

            if (remainingBalance < 0)
            {
                lblBalance.Text = "Change:";
                lblTextChangeRemainingBalance.Text = Math.Abs(remainingBalance).ToString("N2");
            }
            else
            {
                lblBalance.Text = "Remaining:";
                lblTextChangeRemainingBalance.Text = remainingBalance.ToString("N2");
            }
        }
    }
}
