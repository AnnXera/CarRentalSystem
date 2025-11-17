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
                lblFullName.Text = selected.CustomerName;
                lblCarName.Text = selected.CarName;
                lblRegisteredEmployee.Text = selected.EmployeeName;
                lblSecurityDeposit.Text = selected.DepositAmount.ToString("N2");
                lblBaseRate.Text = (selected.BaseRate ?? 0).ToString("N2");

                // Display customer driver license
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

                // Display car image
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
            }

            else
            {
                // Reset to defaults if nothing selected
                lblFullName.Text = "";
                lblCarName.Text = "";
                lblRegisteredEmployee.Text = "";
                lblSecurityDeposit.Text = "0.00";
                lblBaseRate.Text = "0.00";

                Image defaultDriver = Properties.Resources.SampleDriver_s_License;
                picCustomer.Image = ImageHelper.ResizeImage(defaultDriver, 240, 152);
                picCustomer.SizeMode = PictureBoxSizeMode.Zoom;

                Image defaultCar = Properties.Resources.CarSamplePic;
                picCar.Image = ImageHelper.ResizeImage(defaultCar, 429, 276);
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
