using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_Car;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_AddEditCar : Form
    {
        
        private long _carId;
        private bool _isEditMode;

        public modal_AddEditCar(long carId = 0, bool isEditMode = false)
        {
            InitializeComponent();
            _carId = carId;
            _isEditMode = isEditMode;

            LoadComboBoxes();

            SetupDgvCarParts();
            LoadRentalPlans();
            KeyHandlers();

            if (_isEditMode)
            {
                LoadCarData(); // Load existing car info
                btnSave.Text = "Update";
                this.Text = "Edit Car";
            }
            else
            {
                ClearForm();
                btnSave.Text = "Add";
                this.Text = "Add New Car";
            }
        }

        private void KeyHandlers()
        {
            txtYear.KeyPress += (s, e) => InputHandler.AllowIntegerWithLimit(e, txtYear, 4);
            txtReplacementValue.KeyPress += (s, e) => InputHandler.AllowDecimal(e, txtReplacementValue);
            cbxBrand.KeyPress += (s, e) => InputHandler.AllowLettersOnly(e);
            txtVIN.KeyPress += (s, e) => InputHandler.AllowVIN(e, txtVIN);
            txtPlateNumber.KeyPress += (s, e) => InputHandler.AllowPlateNumber(e, txtPlateNumber);
        }

        private void LoadComboBoxes()
        {
            cbxBrand.DataSource = Enum.GetValues(typeof(CarBrand));
            cbxBrand.SelectedIndex = -1;

            cbxBrand.DropDownStyle = ComboBoxStyle.DropDown;
            cbxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));
            cbxFuelType.DataSource = Enum.GetValues(typeof(FuelType));
            cbxStatus.DataSource = Enum.GetValues(typeof(CarStatus));
        }

        private void ValidateCarForm()
        {
            try
            {
                // Required text fields
                Validator.RequireNotEmpty(txtModel.Text, "Model");
                Validator.RequireNotEmpty(txtYear.Text, "Year");
                Validator.RequireNotEmpty(cbxSeats.Text, "Seats");
                Validator.RequireNotEmpty(txtPlateNumber.Text, "Plate Number");
                Validator.RequireNotEmpty(txtVIN.Text, "VIN");
                Validator.RequireNotEmpty(txtReplacementValue.Text, "Replacement Value");
                Validator.RequireNotEmpty(txtEngineType.Text, "Engine Type");

                // Nullable/enum comboboxes
                Validator.RequireComboBoxSelected(cbxBrand, "Brand");
                Validator.RequireComboBoxSelected(cbxTransmission, "Transmission");
                Validator.RequireComboBoxSelected(cbxFuelType, "Fuel Type");
                Validator.RequireComboBoxSelected(cbxStatus, "Status");
                Validator.RequireComboBoxSelected(cbxRentalPlan, "Rental Plan");

                // Numeric validations
                Validator.ValidateYear(txtYear.Text);
                Validator.ValidatePositiveInteger(cbxSeats.Text, "Seats");
                Validator.ValidatePositiveDecimal(txtReplacementValue.Text, "Replacement Value");

                // VIN & Plate validations
                Validator.ValidateVIN(txtVIN.Text);
                Validator.ValidatePlateNumber(txtPlateNumber.Text);

                // Image
                Validator.RequirePictureSelected(picCar, "Car Image");

            }
            catch (Exception ex)
            {
                throw new Exception($"Validation Error: {ex.Message}");
            }
        }

        private void SetupDgvCarParts()
        {
            dgvCarParts.Columns.Clear();
            dgvCarParts.AutoGenerateColumns = false;
            dgvCarParts.AllowUserToAddRows = false;
            dgvCarParts.RowHeadersVisible = false;

            // hidden PartID
            var colPartID = new DataGridViewTextBoxColumn
            {
                Name = "PartID",
                HeaderText = "ID",
                Visible = false
            };
            dgvCarParts.Columns.Add(colPartID);

            // visible columns
            dgvCarParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartName",
                HeaderText = "Part Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCarParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReplacementCost",
                HeaderText = "Cost",
                Width = 120
            });

            dgvCarParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                Width = 150
            });

            // edit icon
            var editCol = new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.EditIcon,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40
            };
            dgvCarParts.Columns.Add(editCol);

            dgvCarParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvCarParts.AllowUserToResizeColumns = false;
            dgvCarParts.AllowUserToResizeRows = false;

            dgvCarParts.ReadOnly = true;
        }

        private void LoadCarData()
        {
            try
            {
                var repo = new CarRepository();
                var car = repo.GetCarById(_carId);

                cbxBrand.DataSource = Enum.GetValues(typeof(CarBrand));
                cbxTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));
                cbxFuelType.DataSource = Enum.GetValues(typeof(FuelType));
                cbxStatus.DataSource = Enum.GetValues(typeof(CarStatus));

                if (car == null)
                {
                    MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cbxBrand.Text = car.Brand;
                txtModel.Text = car.Model;
                txtYear.Text = car.Year.ToString();
                cbxSeats.Text = car.Seats.ToString();
                txtPlateNumber.Text = car.PlateNumber;
                txtVIN.Text = car.VIN;
                txtReplacementValue.Text = car.ReplacementValue.ToString("N2");
                txtEngineType.Text = car.EngineType;
                cbxStatus.Text = car.Status;
                
                cbxRentalPlan.SelectedValue = car.PlanID;

                if (car.CarPicture != null)
                    picCar.Image = ImageHelper.ByteArrayToImage(car.CarPicture);

                
                LoadCarParts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car data: " + ex.Message);
            }
        }
        
        private void LoadCarParts()
        {
            try
            {
                var partsFactory = new CarPartsFactory();
                var parts = partsFactory.ViewByCar(_carId);

                dgvCarParts.Rows.Clear();

                foreach (var part in parts)
                {
                    int index = dgvCarParts.Rows.Add();
                    dgvCarParts.Rows[index].Cells["PartID"].Value = part.PartID;
                    dgvCarParts.Rows[index].Cells["PartName"].Value = part.PartName;
                    dgvCarParts.Rows[index].Cells["ReplacementCost"].Value = part.ReplacementCost;
                    dgvCarParts.Rows[index].Cells["Status"].Value = part.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car parts: " + ex.Message);
            }
        }

        public void ClearForm()
        {
            cbxBrand.SelectedIndex = -1;
            txtModel.Clear();
            txtYear.Clear();
            cbxSeats.SelectedIndex = -1;
            txtPlateNumber.Clear();
            txtVIN.Clear();
            txtReplacementValue.Clear();
            txtEngineType.Clear();
            cbxFuelType.SelectedIndex = -1;
            cbxTransmission.SelectedIndex = -1;
            cbxRentalPlan.SelectedIndex = -1;
            picCar.Image = null;
            dgvCarParts.Rows.Clear();
        }

        private void LoadRentalPlans()
        {
            try
            {
                var repo = new RentalPlanRepository();
                var plans = repo.GetAllPlans();

                cbxRentalPlan.DataSource = plans;
                cbxRentalPlan.DisplayMember = "PlanName";
                cbxRentalPlan.ValueMember = "PlanID";
                cbxRentalPlan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load rental plans.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Customer Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picCar.Image = Image.FromFile(ofd.FileName);
                    picCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnAddCarParts_Click(object sender, EventArgs e)
        {
            using (var partsForm = new modal_AddEditCarParts())
            {
                if (partsForm.ShowDialog() == DialogResult.OK)
                {
                    var newPart = partsForm.NewPart;

                    int index = dgvCarParts.Rows.Add();
                    dgvCarParts.Rows[index].Cells["PartID"].Value = 0; // 0 means new
                    dgvCarParts.Rows[index].Cells["PartName"].Value = newPart.PartName;
                    dgvCarParts.Rows[index].Cells["ReplacementCost"].Value = newPart.ReplacementCost;
                    dgvCarParts.Rows[index].Cells["Status"].Value = newPart.Status;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate form
                ValidateCarForm();

                // 2. Prepare car object
                var car = new Cars
                {
                    CarID = _carId,
                    Model = txtModel.Text.Trim(),
                    Year = int.Parse(txtYear.Text),
                    Seats = int.Parse(cbxSeats.Text),
                    PlateNumber = txtPlateNumber.Text.Trim(),
                    VIN = txtVIN.Text.Trim(),
                    ReplacementValue = decimal.Parse(txtReplacementValue.Text),
                    EngineType = txtEngineType.Text.Trim(),
                    PlanID = (long)cbxRentalPlan.SelectedValue,
                    CurrentMileage = 0,
                    CarPicture = ImageHelper.ImageToByteArray(picCar.Image),
                    Transmission = cbxTransmission.SelectedItem.ToString(),
                    FuelType = cbxFuelType.SelectedItem.ToString(),
                    Status = cbxStatus.SelectedItem.ToString(),
                    Brand = cbxBrand.SelectedItem.ToString()
                };

                var carFactory = new CarFactory();
                long carId;

                // 3. Add or Update car
                if (_isEditMode)
                {
                    carFactory.Edit(car);
                    carId = _carId;

                    // Log edit action
                    SystemLogger.Log(
                        "Edit Car",
                        $"{SessionManager.LoggedInEmployee.FullName} edited car {car.Brand} {car.Model} (ID: {car.CarID})",
                        SessionManager.LoggedInEmployee.EmpID
                    );
                }
                else
                {
                    carId = carFactory.Add(car);

                    // Log add action
                    SystemLogger.Log(
                        "Add Car",
                        $"{SessionManager.LoggedInEmployee.FullName} added new car {car.Brand} {car.Model} (ID: {carId})",
                        SessionManager.LoggedInEmployee.EmpID
                    );
                }

                // 4. Handle car parts (existing code)
                var partsFactory = new CarPartsFactory();
                var existingParts = partsFactory.ViewByCar(carId);
                var currentParts = new List<CarParts>();

                foreach (DataGridViewRow row in dgvCarParts.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["PartName"].Value == null || row.Cells["ReplacementCost"].Value == null)
                        continue;

                    long partId = 0;
                    if (row.Cells["PartID"].Value != null && long.TryParse(row.Cells["PartID"].Value.ToString(), out long parsedId))
                        partId = parsedId;

                    var part = new CarParts
                    {
                        PartID = partId,
                        CarID = carId,
                        PartName = row.Cells["PartName"].Value.ToString(),
                        ReplacementCost = Convert.ToDecimal(row.Cells["ReplacementCost"].Value),
                        Status = row.Cells["Status"].Value?.ToString() ?? "Good"
                    };
                    currentParts.Add(part);
                }

                foreach (var part in currentParts)
                {
                    if (part.PartID > 0)
                        partsFactory.Edit(part);
                    else
                        partsFactory.Add(part);
                }

                MessageBox.Show(_isEditMode ? "Car updated successfully!" : "Car added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            // Check if edit icon column clicked
            if (dgvCarParts.Columns[e.ColumnIndex].Name == "Edit")
            {
                var row = dgvCarParts.Rows[e.RowIndex];

                var part = new CarParts
                {
                    PartName = row.Cells["PartName"].Value.ToString(),
                    ReplacementCost = Convert.ToDecimal(row.Cells["ReplacementCost"].Value),
                    Status = row.Cells["Status"].Value.ToString()
                };

                // Open edit modal
                using (var editForm = new modal_AddEditCarParts(isEditMode: true))
                {
                    // Populate existing values
                    editForm.NewPart = part;
                    editForm.LoadExistingPart(); 

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        var updatedPart = editForm.NewPart;

                        // Update row
                        row.Cells["PartName"].Value = updatedPart.PartName;
                        row.Cells["ReplacementCost"].Value = updatedPart.ReplacementCost;
                        row.Cells["Status"].Value = updatedPart.Status;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
