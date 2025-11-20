using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_Car;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmFleetManagement : Form
    {
        CarFactory carFactory = new CarFactory();

        public frmFleetManagement()
        {
            InitializeComponent();
            LoadCars();
            LoadComboboxes();
            LoadDesign();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                panel5,
                pnlCarView,
                pnlComboBox,
                pnlRentalPlan,
                pnlSearch
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        public void LoadCars()
        {
            var cars = carFactory.ViewAll();

            dgvCars.AllowUserToAddRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCars.RowHeadersVisible = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.RowTemplate.Height = 123;

            var carTable = new DataTable();

            // Define columns
            carTable.Columns.Add("CarID", typeof(long));
            carTable.Columns.Add("Picture", typeof(Image));
            carTable.Columns.Add("CarDescription");
            carTable.Columns.Add("PlateNumber");
            carTable.Columns.Add("VIN");
            carTable.Columns.Add("Seats");
            carTable.Columns.Add("Transmission");
            carTable.Columns.Add("FuelType");
            carTable.Columns.Add("PlanName");
            carTable.Columns.Add("Status");

            foreach (var car in cars)
            {
                Image img = null;
                if (car.CarPicture != null)
                {
                    img = ImageHelper.ByteArrayToImage(car.CarPicture);
                    img = ImageHelper.ResizeImage(img, 208, 123);
                }

                var row = carTable.NewRow();
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

                carTable.Rows.Add(row);
            }

            dgvCars.DataSource = carTable;

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

            // Add edit column if desired
            if (!dgvCars.Columns.Contains("Edit"))
            {
                var editColumn = new DataGridViewImageColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Image = Properties.Resources.EditIcon2, // your icon
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 40,
                    ToolTipText = "Edit Car"
                };

                dgvCars.Columns.Insert(0, editColumn);
            }

            dgvCars.ReadOnly = true;

            dgvCars.Refresh();
        }

        private void LoadComboboxes()
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

            cbxStatus.DataSource = Enum.GetValues(typeof(CarStatus));
            cbxStatus.SelectedIndex = -1;
        }

        private void picCar_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            using (var addEditCar = new modal_AddEditCar(0, false))
            {
                addEditCar.ShowDialog();
                LoadCars();
            }
        }

        private void dgvCars_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCars.Columns[e.ColumnIndex].Name == "Edit")
            {
                long carId = Convert.ToInt64(dgvCars.Rows[e.RowIndex].Cells["CarID"].Value);
                using (var editCarForm = new modal_AddEditCar(carId, true))
                {
                    editCarForm.ShowDialog();
                    LoadCars();
                }
            }
        }

        private void DisplayCarDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;
            
            lblCarName.Text = selectedRow.Cells["CarDescription"].Value?.ToString();
            lblStatus.Text = selectedRow.Cells["Status"].Value?.ToString();

            if (selectedRow.Cells["Picture"].Value is Image img && img != null)
            {
                picCar.Image = img;
            }
            else
            {
                string defaultPath = System.IO.Path.Combine(Application.StartupPath, "Assets", "default_car.png");

                if (System.IO.File.Exists(defaultPath))
                    picCar.Image = Image.FromFile(defaultPath);
                else
                    picCar.Image = null;
            }

            picCar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header clicks
            {
                DataGridViewRow selectedRow = dgvCars.Rows[e.RowIndex];
                DisplayCarDetails(selectedRow);
            }
        }
    }
}
