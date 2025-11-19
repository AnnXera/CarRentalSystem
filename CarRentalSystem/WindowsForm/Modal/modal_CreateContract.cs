using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.PDF;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_Payment;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_CreateContract : Form
    {
        private Cars selectedCar;
        private RentalPlan selectedRentalPlan;

        public modal_CreateContract()
        {
            InitializeComponent();
            LoadDesigns();
            LoadComboBox();
            ClearLabel();
            EventChanges();

            KeyHandlers();

            this.Text = "Create New Contract";
        }

        private void LoadDesigns()
        {
            var panels = new List<Panel>
            {
                pnlContractDetails,
                pnlCustomer,
                pnlRentalPlanVehicle,
                pnlSearch,
                pnlPaymentMethod,
                pnlReturnDate,
                pnlSecurityDeposit,
                pnlStartDate
            };
            UIHelper.ApplyRoundedPanels(panels, 8);

            var dtpStartDate = UIHelper.CreateBorderlessDatePicker();
        }

        private void ClearLabel()
        {
            lblCustomerID.Text = "";
            lblFullName.Text = "";
            lblGender.Text = "";
            lblPhoneNumber.Text = "";
            lblAddress.Text = "";
            Image defaultImg = Properties.Resources.SampleDriver_s_License;
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

        private void KeyHandlers()
        {
            txtSecurityDeposit.KeyPress += (s, e) => InputHandler.AllowDecimal(e, txtSecurityDeposit);
        }

        private void ValidateFields()
        {
            Validator.RequireComboBoxSelected(cbxSearch, "Customer");
            Validator.ValidatePositiveDecimal(txtSecurityDeposit.Text, "Security Deposit");
            Validator.ValidateMinimumSecurityDeposit(txtSecurityDeposit.Text);
            Validator.ValidateNotPastDate(dtpStartDate.Value, "Start Date");
            Validator.ValidateReturnDateAfterStart(dtpStartDate.Value, dtpReturnDate.Value);
            Validator.RequireComboBoxSelected(cbxPaymentMethod, "Payment Method");
        }

        private void LoadComboBox()
        {
            // Get all customers
            var customerFactory = new CustomerFactory();
            var allCustomers = customerFactory.ViewAll();

            // Get all contracts that are pending or active
            var contractFactory = new ContractFactory();
            var activeContracts = contractFactory.ViewAll()
                                                 .Where(c => c.Status == "Pending" || c.Status == "Active")
                                                 .Select(c => c.CustID)
                                                 .ToList();

            // Filter out customers with pending/active contracts
            var availableCustomers = allCustomers
                                     .Where(c => !activeContracts.Contains(c.CustID))
                                     .ToList();

            // Bind filtered list to ComboBox
            cbxSearch.DataSource = availableCustomers;
            cbxSearch.DisplayMember = "FullName";
            cbxSearch.ValueMember = "CustID";
            cbxSearch.SelectedIndex = -1;

            cbxSearch.DropDownStyle = ComboBoxStyle.DropDown;
            cbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Payment Method ComboBox
            cbxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            cbxPaymentMethod.SelectedIndex = -1; // No default selected
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
                    Image defaultImg = Properties.Resources.SampleDriver_s_License; 
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

                Image defaultImg = Properties.Resources.SampleDriver_s_License;
                picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);
            }
        }

        private void EventChanges()
        {
            cbxSearch.SelectedIndexChanged += (s, e) => SelectedCustomer();
            txtSecurityDeposit.TextChanged += (s, e) => UpdateTotalDue();
            dtpStartDate.ValueChanged += (s, e) => UpdateTotalCost();
            dtpReturnDate.ValueChanged += (s, e) => UpdateTotalCost();
        }

        private void UpdateTotalCost()
        {
            if (selectedRentalPlan == null) return;

            int days = (dtpReturnDate.Value.Date - dtpStartDate.Value.Date).Days + 1;
            if (days < 1) days = 1;

            lblDays.Text = days.ToString();

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
            try
            {
                ValidateFields();

                if (string.IsNullOrWhiteSpace(lblCustomerID.Text))
                    throw new Exception("Please select a customer.");

                if (!SessionManager.IsLoggedIn)
                    throw new Exception("No employee is logged in.");

                long custId = long.Parse(lblCustomerID.Text);
                long carId = long.Parse(lblCarNo.Text);
                long empId = SessionManager.LoggedInEmployee.EmpID;

                DateTime startDate = dtpStartDate.Value.Date;
                DateTime returnDate = dtpReturnDate.Value.Date;

                int daysRented = (returnDate - startDate).Days + 1;
                if (daysRented < 1) daysRented = 1;

                decimal securityDepositAmount = decimal.Parse(txtSecurityDeposit.Text);
                decimal baseRate = 0;
                decimal.TryParse(lblBaseRate.Text, System.Globalization.NumberStyles.Currency, null, out baseRate);

                // Create contract object
                var contract = new Contracts
                {
                    CustID = custId,
                    EmpID = empId,
                    CarID = carId,
                    StartDate = startDate,
                    ReturnDate = returnDate,
                    DaysRented = daysRented,
                    StartMileage = selectedCar.CurrentMileage,
                    Status = "Pending"
                };

                // Create deposit object
                var deposit = new SecurityDeposit
                {
                    Amount = securityDepositAmount,
                    Status = "Held",
                    DepositDate = DateTime.Now.Date
                };

                string paymentMethod = cbxPaymentMethod.SelectedItem?.ToString() ?? "Cash";
                string customerName = lblFullName.Text;

                // Call ContractFactory to insert
                var factory = new ContractFactory();
                long newContractID = factory.Add(contract, deposit, baseRate, paymentMethod, customerName);

                // Log contract creation
                SystemLogger.Log(
                    "Create Contract",
                    $"{SessionManager.LoggedInEmployee.FullName} created a contract for customer {customerName}.",
                    SessionManager.LoggedInEmployee.EmpID
                );

                // Base folder for all contracts
                string baseFolder = @"C:\Users\ASUS\Documents\CarRentalContracts";

                // Create a subfolder for today's date
                string dateFolder = Path.Combine(baseFolder, DateTime.Now.ToString("yyyy-MM-dd"));

                // Ensure the folder exists
                if (!Directory.Exists(dateFolder))
                {
                    Directory.CreateDirectory(dateFolder);
                }

                // Full PDF file path
                string pdfPath = Path.Combine(dateFolder, $"Contract_{newContractID}.pdf");

                // Generate the PDF
                var pdf = new pdf_Contract();
                pdf.GenerateContract(
                    pdfPath,
                    lblFullName.Text,
                    lblCustomerID.Text,
                    lblAddress.Text,
                    lblPhoneNumber.Text,
                    selectedCar,
                    selectedRentalPlan,
                    dtpStartDate.Value,
                    dtpReturnDate.Value,
                    int.Parse(lblDays.Text),
                    decimal.Parse(lblBaseRate.Text, System.Globalization.NumberStyles.Currency),
                    decimal.Parse(txtSecurityDeposit.Text),
                    cbxPaymentMethod.SelectedItem.ToString(),
                    lblTotalDue.Text,
                    SessionManager.LoggedInEmployee.FullName,
                    SessionManager.LoggedInEmployee.EmpID.ToString(),
                    newContractID
                );

                MessageBox.Show($"Contract created successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
