using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_CreateContract : Form
    {
        private Cars selectedCar;
        private RentalPlan selectedRentalPlan;

        public modal_CreateContract()
        {
            InitializeComponent();
            LoadPanles();
            LoadComboBox();
            ClearLabel();
            EventChanges();
        }

        private void LoadPanles() 
        {
            var panels = new List<Panel> 
            { 
                pnlContractDetails,
                pnlCustomer,
                pnlRentalPlanVehicle
            };
            UIHelper.ApplyRoundedPanels(panels, 8);

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlSearch,
                pnlReturnDate,
                pnlSecurityDeposit,
                pnlStartDate
            });
        }

        private void ClearLabel()
        {
            lblCustomerID.Text = "";
            lblFullName.Text = "";
            lblGender.Text = "";
            lblPhoneNumber.Text = "";
            lblAddress.Text = "";
            Image defaultImg = Properties.Resources.user_image_mockup;
            picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);

            lblRentalPlan.Text = "";
            lblCarName.Text = "";
            lblPlateNumber.Text = "";
            lblSeats.Text = "";
            lblTransmission.Text = "";
            lblFuelType.Text = "";
            lblCarNo.Text = "";
            Image defaultCarImg = Properties.Resources.CarSamplePic;
            picCar.Image = ImageHelper.ResizeImage(defaultCarImg, 429, 276);

            lblDays.Text = "0";
            lblBaseRate.Text = "0.00";
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
                lblAddress.Text = selectedCustomer.Address;

                if (selectedCustomer.Picture != null && selectedCustomer.Picture.Length > 0)
                {
                    using (var ms = new MemoryStream(selectedCustomer.Picture))
                    {
                        Image img = Image.FromStream(ms);
                        picCustomer.Image = ImageHelper.ResizeImage(img, 240, 152);
                    }
                }
                else
                {
                    Image defaultImg = Properties.Resources.user_image_mockup; 
                    picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);
                }

                picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                lblCustomerID.Text = "";
                lblFullName.Text = "";
                lblGender.Text = "";
                lblPhoneNumber.Text = "";
                lblAddress.Text = "";

                Image defaultImg = Properties.Resources.user_image_mockup;
                picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);
            }
        }

        private void EventChanges()
        {
            cbxSearch.SelectedIndexChanged += (s, e) => SelectedCustomer();
            dtpStartDate.ValueChanged += (s, e) => UpdateTotalCost();
            dtpReturnDate.ValueChanged += (s, e) => UpdateTotalCost();
            txtSecurityDeposit.TextChanged += (s, e) => UpdateTotalDue();
        }

        private void UpdateTotalCost()
        {
            if (selectedRentalPlan == null) return;

            int days = (dtpReturnDate.Value.Date - dtpStartDate.Value.Date).Days + 1;
            if (days < 1) days = 1;

            lblDays.Text = $"{days}";

            decimal totalBase = selectedRentalPlan.DailyRate * days;
            lblBaseRate.Text = $"{totalBase:C}";

            UpdateTotalDue();
        }

        private void UpdateTotalDue()
        {
            decimal baseRate = 0;
            decimal securityDeposit = 0;

            // Parse base rate from label (remove currency symbol)
            if (!string.IsNullOrEmpty(lblBaseRate.Text))
            {
                decimal.TryParse(lblBaseRate.Text, System.Globalization.NumberStyles.Currency, null, out baseRate);
            }

            // Parse security deposit from textbox
            if (!string.IsNullOrEmpty(txtSecurityDeposit.Text))
            {
                decimal.TryParse(txtSecurityDeposit.Text, out securityDeposit);
            }

            decimal total = baseRate + securityDeposit;
            lblTotalDue.Text = total.ToString("C"); // show as currency
        }

        private void btnSelectVehicle_Click(object sender, EventArgs e)
        {
            using (var selectCarModal = new modal_SelectRentalAndCar())
            {
                if (selectCarModal.ShowDialog() == DialogResult.OK)
                {
                    selectedCar = selectCarModal.SelectedCar;

                    if (selectedCar != null)
                    {
                        // Update car labels
                        lblCarName.Text = selectedCar.CarDescription;
                        lblCarNo.Text = $"{selectedCar.CarID}";
                        lblPlateNumber.Text = selectedCar.PlateNumber;
                        lblSeats.Text = $"{selectedCar.Seats}";
                        lblTransmission.Text = $"{selectedCar.Transmission}";
                        lblRentalPlan.Text = $"{selectedCar.PlanName}";
                        lblFuelType.Text = $"{selectedCar.FuelType}";

                        // Show car picture
                        if (selectedCar.CarPicture != null && selectedCar.CarPicture.Length > 0)
                        {
                            using (var ms = new MemoryStream(selectedCar.CarPicture))
                            {
                                picCar.Image = Image.FromStream(ms);
                                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }

                        // Update Base Rate based on selected car's rental plan
                        var planRepo = new RentalPlanRepository();
                        selectedRentalPlan = planRepo.GetAllPlans()
                                                     .FirstOrDefault(p => p.PlanID == selectedCar.PlanID);

                        if (selectedRentalPlan != null)
                        {
                            lblBaseRate.Text = $"{selectedRentalPlan.DailyRate:C}";
                            UpdateTotalCost(); 
                        }
                    }
                }
            }
        }

        private void btnCreateContractPayment_Click(object sender, EventArgs e)
        {
            //Validation
            if (selectedCar == null)
            {
                MessageBox.Show("Please select a vehicle first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(lblCustomerID.Text))
            {
                MessageBox.Show("Please select a customer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!SessionManager.IsLoggedIn)
            {
                MessageBox.Show("No employee is logged in.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Gather data
            long custId = long.Parse(lblCustomerID.Text);
            long carId = selectedCar.CarID;
            long empId = SessionManager.LoggedInEmployee.EmpID;

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime returnDate = dtpReturnDate.Value.Date;
            int daysRented = (returnDate - startDate).Days + 1;
            if (daysRented < 1) daysRented = 1;

            long startMileage = (long)selectedCar.CurrentMileage;

            decimal securityDepositAmount = 0;
            decimal.TryParse(txtSecurityDeposit.Text, out securityDepositAmount);

            //Create contract object
            var newContract = new Contracts
            {
                CustID = custId,
                EmpID = empId,
                CarID = carId,
                StartDate = startDate,
                ReturnDate = returnDate,
                DaysRented = daysRented,
                StartMileage = startMileage,
                Status = "Pending"
            };

            //Save Contract using Factory (returns inserted ID)
            var contractFactory = new ContractFactory();
            long contractId = contractFactory.Add(newContract); // Add() now returns ID
            if (contractId <= 0)
            {
                MessageBox.Show("Failed to create contract.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Save Security Deposit with DepositDate
            var depositRepo = new SecurityDepositRepository();
            var deposit = new SecurityDeposit
            {
                ContractID = contractId,
                Amount = securityDepositAmount,
                Status = "Held",
                DepositDate = DateTime.Now.Date
            };
            long depositId = depositRepo.AddSecurityDeposit(deposit); // returns ID
            if (depositId <= 0)
            {
                MessageBox.Show("Failed to add security deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Update car status to "Rented"
            var carFactory = new CarFactory();
            carFactory.UpdateStatus(selectedCar.CarID, "Rented");

            //Success message
            MessageBox.Show($"Contract created successfully!\nContract ID: {contractId}\nDeposit ID: {depositId}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
