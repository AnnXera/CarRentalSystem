using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmFleetManagement : Form
    {
        public frmFleetManagement()
        {
            InitializeComponent();
            LoadCars();
            LoadRentalPlans();
        }
        public void LoadCars()
        {
            var factory = new CarFactory();
            var cars = factory.ViewAll();

            dgvCars.AllowUserToAddRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCars.RowHeadersVisible = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.RowTemplate.Height = 123; // match image height

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
                    img = ImageHelper.ResizeImage(img, 208, 123); // fixed size
                }

                var row = carTable.NewRow();
                row["CarID"] = car.CarID;
                row["Picture"] = img;
                row["CarDescription"] = car.CarDescription; // only description
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
                    Image = Properties.Resources.EditIcon, // your icon
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 40,
                    ToolTipText = "Edit Car"
                };

                dgvCars.Columns.Insert(0, editColumn);
            }

            dgvCars.Refresh();
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

        private void pnlRentalPlan_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawBorderInside((Control)sender, e);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawBorderInside((Control)sender, e);
        }

        private void pnlComboBox_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawBorderInside((Control)sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 15);
        }

        private void picCar_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 15);
        }

        private void frmFleetManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            using (var addEditCar = new modal_AddEditCar(0, false))
            {
                addEditCar.ShowDialog();
                LoadCars();
            }
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
    }
}
