using CarRentalSystem.Code;
using CarRentalSystem.Database;
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
using static CarRentalSystem.Code.Enum.enum_Car;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_SelectRentalAndCar : Form
    {
        public Cars SelectedCar { get; private set; }
        private RentalPlan selectedRentalPlan;

        private DataTable _carTable;
        private DataView _carView;

        public modal_SelectRentalAndCar()
        {
            InitializeComponent();
            LoadRentalPlans();
            LoadComboboxes();
            LoadCars();
            EventChanges();

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlAvailableCar,
                pnlRentalPlan,
                pnlSearch,
                pnlSeats,
                pnlTransmission
            });
        }

        private void EventChanges()
        {
            txtSearch.TextChanged += (s, e) => ApplyCarFilters();
            cbxTransmission.SelectedIndexChanged += (s, e) => ApplyCarFilters();
            cbxSeats.SelectedIndexChanged += (s, e) => ApplyCarFilters();
            cbxRentalPlan.SelectedIndexChanged += (s, e) => ApplyCarFilters();
            dgvCars.CellClick += dgvCars_CellClick;
        }

        private void LoadComboboxes()
        {
            cbxTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));
            cbxTransmission.SelectedIndex = -1;

            cbxTransmission.DropDownStyle = ComboBoxStyle.DropDown;
            cbxTransmission.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxTransmission.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxSeats.DataSource = Enum.GetValues(typeof(SeatCount))
                .Cast<SeatCount>()
                .Select(v => (int)v)
                .ToList();

            cbxSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSeats.SelectedIndex = -1;
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

        public void LoadCars()
        {
            var factory = new CarFactory();
            var cars = factory.ViewAll();

            dgvCars.AllowUserToAddRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCars.RowHeadersVisible = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.RowTemplate.Height = 123;

            _carTable = new DataTable();
            _carTable.Columns.Add("CarID", typeof(long));
            _carTable.Columns.Add("Picture", typeof(Image));
            _carTable.Columns.Add("CarDescription");
            _carTable.Columns.Add("PlateNumber");
            _carTable.Columns.Add("VIN");
            _carTable.Columns.Add("Seats");
            _carTable.Columns.Add("Transmission");
            _carTable.Columns.Add("FuelType");
            _carTable.Columns.Add("PlanName");
            _carTable.Columns.Add("Status");
            _carTable.Columns.Add("PlanID", typeof(long));

            foreach (var car in cars)
            {
                Image img = null;
                if (car.CarPicture != null)
                {
                    img = ImageHelper.ByteArrayToImage(car.CarPicture);
                    img = ImageHelper.ResizeImage(img, 208, 123);
                }

                var row = _carTable.NewRow();
                row["CarID"] = car.CarID;
                row["Picture"] = img;
                row["CarDescription"] = car.CarDescription;
                row["PlateNumber"] = car.PlateNumber;
                row["VIN"] = car.VIN;
                row["Seats"] = car.Seats;
                row["Transmission"] = car.Transmission;
                row["FuelType"] = car.FuelType;
                row["PlanName"] = car.PlanName;
                row["Status"] = car.Status;
                row["PlanID"] = car.PlanID;
                _carTable.Rows.Add(row);
            }

            _carView = new DataView(_carTable);
            dgvCars.DataSource = _carView;

            if (dgvCars.Columns["PlanID"] != null)
                dgvCars.Columns["PlanID"].Visible = false;

            // Rename columns
            dgvCars.Columns["CarID"].HeaderText = "ID";
            dgvCars.Columns["Picture"].HeaderText = "Picture";
            dgvCars.Columns["CarDescription"].HeaderText = "Car";
            dgvCars.Columns["PlateNumber"].HeaderText = "Plate Number";
            dgvCars.Columns["VIN"].HeaderText = "VIN";
            dgvCars.Columns["Seats"].HeaderText = "Seats";
            dgvCars.Columns["Transmission"].HeaderText = "Transmission";
            dgvCars.Columns["FuelType"].HeaderText = "Fuel Type";
            dgvCars.Columns["PlanName"].HeaderText = "Rental Plan";
            dgvCars.Columns["Status"].HeaderText = "Status";

            // Format image column
            if (dgvCars.Columns["Picture"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvCars.Columns["Picture"].Width = 208;
            }

            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvCars.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCars.ReadOnly = true;

            dgvCars.Refresh();
        }

        private void ApplyCarFilters()
        {
            if (_carView == null) return;

            var filters = new List<string>();

            // 🔍 Search filter (only Car Description)
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.Replace("'", "''"); // prevent SQL-like issues
                filters.Add($"CarDescription LIKE '%{search}%'");
            }

            // ⚙️ Transmission filter
            if (cbxTransmission.SelectedItem != null)
            {
                string transmission = cbxTransmission.SelectedItem.ToString();
                filters.Add($"Transmission = '{transmission}'");
            }

            // 💺 Seats filter
            if (cbxSeats.SelectedItem != null)
            {
                filters.Add($"Seats = {cbxSeats.SelectedItem}");
            }

            // 📋 Rental plan filter
            if (cbxRentalPlan.SelectedItem != null)
            {
                var planName = ((dynamic)cbxRentalPlan.SelectedItem).PlanName.ToString().Replace("'", "''");
                filters.Add($"PlanName = '{planName}'");
            }

            // Combine filters
            _carView.RowFilter = filters.Count > 0 ? string.Join(" AND ", filters) : string.Empty;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbxTransmission.SelectedIndex = -1;
            cbxSeats.SelectedIndex = -1;
            cbxRentalPlan.SelectedIndex = -1;
            ApplyCarFilters();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCars.Rows[e.RowIndex];

            SelectedCar = new Cars
            {
                CarID = Convert.ToInt64(row.Cells["CarID"].Value),
                CarDescription = row.Cells["CarDescription"].Value?.ToString(),
                PlateNumber = row.Cells["PlateNumber"].Value?.ToString(),
                Seats = Convert.ToInt32(row.Cells["Seats"].Value),
                Transmission = row.Cells["Transmission"].Value?.ToString(),
                PlanName = row.Cells["PlanName"].Value?.ToString(),
                FuelType = row.Cells["FuelType"].Value?.ToString(),
                CarPicture = ImageHelper.ImageToByteArray(row.Cells["Picture"].Value as Image),
                PlanID = Convert.ToInt64(row.Cells["PlanID"].Value)
            };

            // Optional: update preview in the same modal
            lblCarName.Text = SelectedCar.CarDescription;
            lblSeats.Text = $"Seats: {SelectedCar.Seats}";
            lblTransmission.Text = $"Transmission: {SelectedCar.Transmission}";
            lblRentalPlan.Text = $"Rental Plan: {SelectedCar.PlanName}";
            if (row.Cells["Picture"].Value is Image img)
                picCar.Image = img;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectedCar != null)
            {
                this.DialogResult = DialogResult.OK; // <-- signals that a car was selected
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a car first.");
            }
        }
    }
}
