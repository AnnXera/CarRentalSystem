using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmCustomerManagement : Form
    {
        private DataTable customerTable;
        public frmCustomerManagement()
        {
            InitializeComponent();

            txtSearch.TextChanged += txtSearch_TextChanged;
            dgvCustomers.CellClick += dgvCustomers_CellClick_1;

            LoadPanelTxtCbx();
            LoadCustomers();
            EventHandler();

            lblCustomerID.Text = "";
            lblFullName.Text = "";
            lblGender.Text = "";
            lblPhoneNumber.Text = "";
            lblAddress.Text = "";
        }

        private void LoadPanelTxtCbx ()
        {
            var panels = new List<Panel>
            {
                pnlCustomerDetails,
                pnlSearch,
                pnlCustomerView,
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void EventHandler()
        {
            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }

        public void LoadCustomers()
        {
            var factory = new CustomerFactory();
            var customers = factory.ViewAll();

            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.RowTemplate.Height = 160;

            customerTable = new DataTable(); // store globally
            customerTable.Columns.Add("CustID", typeof(long));
            customerTable.Columns.Add("DriversLicensePic", typeof(Image));
            customerTable.Columns.Add("FullName");
            customerTable.Columns.Add("Gender");
            customerTable.Columns.Add("PhoneNumber");
            customerTable.Columns.Add("Address");
            customerTable.Columns.Add("RegisteredBy");

            foreach (var c in customers)
            {
                Image img = ImageHelper.ByteArrayToImage(c.Picture);
                img = ImageHelper.ResizeImage(img, 359, 228);

                var row = customerTable.NewRow();
                row["CustID"] = c.CustID;
                row["DriversLicensePic"] = img;
                row["FullName"] = c.FullName;
                row["Gender"] = c.Gender;
                row["PhoneNumber"] = c.PhoneNumber;
                row["Address"] = c.Address;
                row["RegisteredBy"] = c.RegisteredByName;
                customerTable.Rows.Add(row);
            }

            dgvCustomers.DataSource = customerTable;

            DataView dv = customerTable.DefaultView;
            dv.Sort = "CustID DESC";
            dgvCustomers.DataSource = dv;

            // Rename columns
            dgvCustomers.Columns["CustID"].HeaderText = "ID";
            dgvCustomers.Columns["DriversLicensePic"].HeaderText = "Driver's License";
            dgvCustomers.Columns["FullName"].HeaderText = "Full Name";
            dgvCustomers.Columns["Gender"].HeaderText = "Gender";
            dgvCustomers.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCustomers.Columns["Address"].HeaderText = "Address";
            dgvCustomers.Columns["RegisteredBy"].HeaderText = "Registered By";

            // Format image column
            if (dgvCustomers.Columns["DriversLicensePic"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvCustomers.Columns["DriversLicensePic"].Width = 359;
            }

            // Remove old edit column to avoid duplicates
            if (dgvCustomers.Columns.Contains("Edit"))
                dgvCustomers.Columns.Remove("Edit");

            // Add edit column with resource icon
            var editColumn = new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.EditIcon2,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40,
                ToolTipText = "Edit Customer"
            };

            dgvCustomers.ReadOnly = true;

            dgvCustomers.Columns.Insert(0, editColumn);
            dgvCustomers.Refresh();
        }

        private void DisplayCustomerDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;

            lblCustomerID.Text = selectedRow.Cells["CustID"].Value?.ToString();
            lblFullName.Text = selectedRow.Cells["FullName"].Value?.ToString();
            lblGender.Text = selectedRow.Cells["Gender"].Value?.ToString();
            lblPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
            lblAddress.Text = selectedRow.Cells["Address"].Value?.ToString();

            // 🖼️ Show image (from DB or fallback)
            if (selectedRow.Cells["DriversLicensePic"].Value is Image img && img != null)
            {
                picCustomer.Image = img;
            }
            else
            {
                string defaultPath = Path.Combine(Application.StartupPath, "Assets", "default_user.png");

                if (File.Exists(defaultPath))
                    picCustomer.Image = Image.FromFile(defaultPath);
                else
                    picCustomer.Image = null;
            }

            picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header clicks
            {
                DataGridViewRow selectedRow = dgvCustomers.Rows[e.RowIndex];
                DisplayCustomerDetails(selectedRow);
            }
        }

        private void dgvCustomers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCustomers.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow selectedRow = dgvCustomers.Rows[e.RowIndex];

                // Build customer object from the grid
                var customer = new Customer
                {
                    CustID = Convert.ToInt64(selectedRow.Cells["CustID"].Value),
                    FullName = selectedRow.Cells["FullName"].Value?.ToString(),
                    Gender = selectedRow.Cells["Gender"].Value?.ToString(),
                    PhoneNumber = selectedRow.Cells["PhoneNumber"].Value?.ToString(),
                    Address = selectedRow.Cells["Address"].Value?.ToString(),
                    Picture = ImageHelper.ImageToByteArray(selectedRow.Cells["DriversLicensePic"].Value as Image)
                };

                // Open modal in "Edit" mode
                var editForm = new modal_AddEditCustomer(customer);
                editForm.ShowDialog();

                // Refresh after editing
                LoadCustomers();
            }
            else
            {
                DisplayCustomerDetails(dgvCustomers.Rows[e.RowIndex]);
            }
        }

        private void btnCustomerAddEdit_Click(object sender, EventArgs e)
        {
            using (var addCustomerModal = new modal_AddEditCustomer())
            {
                addCustomerModal.ClearFields();
                addCustomerModal.ShowDialog();  // Waits until modal closes

                // Refresh DataGridView after adding a new customer
                LoadCustomers();
            }
        }

        private void picCustomer_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 10);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (customerTable == null)
                return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''"); // prevent filter errors

            DataView dv = customerTable.DefaultView;
            dv.RowFilter = string.Format("FullName LIKE '%{0}%'", searchValue);

            dgvCustomers.DataSource = dv;
        }

        private void dgvCustomers_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }
    }
}
