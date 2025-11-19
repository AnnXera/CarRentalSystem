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
        private Contracts _selectedContract;

        public modal_ProcessReturn()
        {
            InitializeComponent();
            LoadPanels();
            LoadCustomerDropdown();
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
                _selectedContract = selected;

                lblFullName.Text = selected.CustomerName;
                lblCarName.Text = selected.CarName;
                lblRegisteredEmployee.Text = selected.EmployeeName;
                lblSecurityDeposit.Text = selected.DepositAmount.ToString("N2");
                lblBaseRate.Text = (selected.BaseRate ?? 0).ToString("N2");
                lblRentalPlan.Text = selected.PlanName;
                lblMileageLimit.Text = selected.MileageLimitPerDay.ToString("N0") + " km/day";
                lblBaseRate.Text = $"₱{(selected.BaseRate ?? 0):N2}";
                lblDueDate.Text = selected.ReturnDate.ToString("MMMM dd, yyyy");
                lblRate.Text = $"₱{selected.ExcessFeePerKm:N2}";

                if (selected.DriversLicensePic != null && selected.DriversLicensePic.Length > 0)
                {
                    Image driverImg = ImageHelper.ByteArrayToImage(selected.DriversLicensePic);
                    picCustomer.Image = ImageHelper.ResizeImage(driverImg, 240, 152);
                    picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    Image defaultImg = Properties.Resources.SampleDriver_s_License;
                    picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);
                    picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
                }

                if (selected.CarPicture != null && selected.CarPicture.Length > 0)
                {
                    Image carImg = ImageHelper.ByteArrayToImage(selected.CarPicture);
                    picCar.Image = ImageHelper.ResizeImage(carImg, 429, 276);
                    picCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    Image defaultCarImg = Properties.Resources.CarSamplePic;
                    picCar.Image = ImageHelper.ResizeImage(defaultCarImg, 429, 276);
                    picCar.SizeMode = PictureBoxSizeMode.Zoom;
                }

                txtEndMileage.Clear();
                txtEndMileage.Focus();
                lblMileageFee.Text = "₱0.00";
            }

            else
            {
                lblFullName.Text = "";
                lblCarName.Text = "";
                lblRegisteredEmployee.Text = "";
                lblSecurityDeposit.Text = "0.00";
                lblBaseRate.Text = "0.00";
                lblRate.Text = "0.00";
                lblRentalPlan.Text = "";
                lblMileageLimit.Text = "0 km/day";
                lblDueDate.Text = "";

                Image defaultDriver = Properties.Resources.SampleDriver_s_License;
                picCustomer.Image = ImageHelper.ResizeImage(defaultDriver, 240, 152);
                picCustomer.SizeMode = PictureBoxSizeMode.Zoom;

                Image defaultCar = Properties.Resources.CarSamplePic;
                picCar.Image = ImageHelper.ResizeImage(defaultCar, 429, 276);
                picCar.SizeMode = PictureBoxSizeMode.Zoom;

                _selectedContract = null;
            }
        }

        private void CalculateMileageFee()
        {
            if (_selectedContract == null)
            {
                lblMileageFee.Text = "₱0.00";
                return;
            }

            if (!long.TryParse(txtEndMileage.Text, out long endMileage) ||
                endMileage < _selectedContract.StartMileage)
            {
                lblMileageFee.Text = "₱0.00";
                UpdateBillingSummary();
                return;
            }

            long totalAllowedKm = _selectedContract.MileageLimitPerDay * _selectedContract.DaysRented;
            long drivenKm = endMileage - _selectedContract.StartMileage;
            long excessKm = Math.Max(0, drivenKm - totalAllowedKm);
            decimal mileageFee = excessKm * _selectedContract.ExcessFeePerKm;

            lblMileageFee.Text = $"₱{mileageFee:N2}";
            lblMileageFee.ForeColor = excessKm > 0 ? Color.Red : Color.Green;

            UpdateBillingSummary();
            UpdateFinalAmountDue();
        }
        // CheckBox and DateTimePicker reset
        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (chbxLateReturn.Checked)
            {
                CalculateLateFee();
                UpdateBillingSummary();
            }
        }
        private void UpdateBillingSummary()
        {
            if (_selectedContract == null) return;

            decimal baseRate = _selectedContract.BaseRate ?? 0m;

            decimal carParts = decimal.TryParse(txtPartsSearch?.Text, out decimal cp) ? cp : 0m;
            decimal lostItems = decimal.TryParse(chbxLost?.Text, out decimal lost) ? lost : 0m;
            decimal lateFee = decimal.TryParse(lblLateFee?.Text.Replace("₱", "").Replace(",", ""), out decimal lf) ? lf : 0m;
            decimal mileageFee = decimal.TryParse(lblMileageLimit?.Text.Replace("₱", "").Replace(",", ""), out decimal mf) ? mf : 0m;
            decimal totalAdditional = carParts + lateFee + mileageFee + lostItems;

            blCarPartsCharges.Text = $"₱{carParts:N2}";
            lblLateFee.Text = $"₱{lateFee:N2}";
            lblLost.Text = $"₱{lostItems:N2}";
            lblTotalFee.Text = $"₱{totalAdditional:N2}";

            decimal subtotal = baseRate + totalAdditional;
            lblSubTotal.Text = $"₱{subtotal:N2}";
            lblTotalFee.Text = $"₱{totalAdditional:N2}";

            txtSecurityDeposit.Text = $"₱{_selectedContract.DepositAmount:N2}";

            UpdateFinalAmountDue();
        }
        private void UpdateFinalAmountDue()
        {
            if (_selectedContract == null) return;

            decimal subtotal = 0m;
            if (!decimal.TryParse(lblSubTotal.Text.Replace("₱", "").Replace(",", ""), out subtotal))
                subtotal = 0m;

            decimal depositUsed = 0m;
            if (!decimal.TryParse(txtSecurityDeposit.Text.Replace("₱", "").Replace(",", ""), out depositUsed))
                depositUsed = 0m;

            depositUsed = Math.Min(depositUsed, _selectedContract.DepositAmount);
            decimal amountDue = Math.Max(0, subtotal - depositUsed);

            txtSecurityDeposit.Text = $"₱{depositUsed:N2}";
            lblTotalAmount.Text = $"₱{amountDue:N2}";

            lblTotalAmount.ForeColor = amountDue > 0 ? Color.Red : Color.Green;
            lblTotalAmount.Font = new Font(lblTotalAmount.Font, amountDue > 0 ? FontStyle.Bold : FontStyle.Regular);
        }
        private void CalculateLateFee()
        {
            if (_selectedContract == null)
            {
                lblLateFee.Text = "₱0.00";
                return;
            }

            if (!chbxLateReturn.Checked)
            {
                lblLateFee.Text = "₱0.00";
                return;
            }
        }

        private void txtPartsSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }

        private void chbxLost_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }
        private void txtSecurityDepositUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtSecurityDeposit.Text.Contains('.'))
                e.Handled = true;
        }

        private void chbxLateReturn_CheckedChanged(object sender, EventArgs e)
        {
            CalculateLateFee();
            UpdateBillingSummary();
        }

        private void txtEndMileage_TextChanged_1(object sender, EventArgs e)
        {
            CalculateMileageFee();
        }

        private void txtEndMileage_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSecurityDeposit_TextChanged(object sender, EventArgs e)
        {
            UpdateFinalAmountDue();
        }
    }
}
