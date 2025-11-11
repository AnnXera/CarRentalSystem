using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_CreateContract : Form
    {
        public modal_CreateContract()
        {
            InitializeComponent();
            LoadPanles();
            LoadComboBox();

            cbxSearch.SelectedIndexChanged += (s, e) => SelectedCustomer();
        }

        private void LoadPanles() 
        {
            var panels = new List<Panel> 
            { 
                pnlContractDetails,
                pnlCustomer,
                pnlRentalPlanVehicle
            };
            UIHelper.ApplyRoundedPanels(panels, 10);

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlSearch,
                pnlReturnDate,
                pnlSecurityDeposit,
                pnlStartDate
            });
        }

        private void LoadComboBox()
        {
            //Customer ComboBox
            var factory = new CustomerFactory();
            var customers = factory.ViewAll();

            cbxSearch.DataSource = customers;
            cbxSearch.DisplayMember = "FullName"; 
            cbxSearch.ValueMember = "CustID";     
            cbxSearch.SelectedIndex = -1;
            
            cbxSearch.DropDownStyle = ComboBoxStyle.DropDown;
            cbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SelectedCustomer()
        {
            if (cbxSearch.SelectedItem is Customer selectedCustomer)
            {
                lblCustomerID.Text = selectedCustomer.CustID.ToString();
                lblFullName.Text = selectedCustomer.FullName;
                lblGender.Text = selectedCustomer.Gender;
                lblPhoneNumber.Text = selectedCustomer.PhoneNumber;
                lblDriversLicense.Text = selectedCustomer.DriversLicense;
                lblAddress.Text = selectedCustomer.Address;

                if (selectedCustomer.Picture != null && selectedCustomer.Picture.Length > 0)
                {
                    using (var ms = new MemoryStream(selectedCustomer.Picture))
                    {
                        Image img = Image.FromStream(ms);
                        picCustomer.Image = ImageHelper.ResizeImage(img, 160, 160);
                    }
                }
                else
                {
                    Image defaultImg = Properties.Resources.user_image_mockup; 
                    picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 160, 160);
                }

                picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                lblCustomerID.Text = "";
                lblFullName.Text = "";
                lblGender.Text = "";
                lblPhoneNumber.Text = "";
                lblDriversLicense.Text = "";
                lblAddress.Text = "";

                Image defaultImg = Properties.Resources.user_image_mockup;
                picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 160, 160);
            }
        }


        private void btnSelectVehicle_Click(object sender, EventArgs e)
        {
            var modalSelectRentalAndCar = new modal_SelectRentalAndCar();
            modalSelectRentalAndCar.ShowDialog();
        }
    }
}
