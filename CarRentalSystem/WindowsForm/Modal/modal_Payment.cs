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
using static CarRentalSystem.Code.Enum.enum_Car;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_Payment : Form
    {
        public modal_Payment(int selectedContractId)
        {
            InitializeComponent();

            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cbxPaymentMethod.DataSource = Enum.GetValues(typeof(Code.Enum.enum_Payment.PaymentMethod));
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
