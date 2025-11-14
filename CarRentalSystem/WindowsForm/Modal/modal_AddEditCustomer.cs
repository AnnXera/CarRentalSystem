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

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_AddEditCustomer : Form
    {
        private Customer _editingCustomer;

        public modal_AddEditCustomer()
        {
            InitializeComponent();
            LoadPanelTxtCbx();
            SetupForNewCustomer();

            this.Text = "Add New Customer";

            txtFullName.TextChanged += TxtFullName_TextChanged;
        }

        private void LoadPanelTxtCbx()
        {
            var panels = new List<Panel>
            {
                pnlAddEditCustomer,
                pnlFullName,
                pnlPhoneNumber,
                pnlAddress
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void SetupForNewCustomer()
        {
            try
            {
                var repo = new CustomerRepository();
                long nextId = repo.GetNextCustomerId();

                lblCustomerName.Text = "New Customer";
                lblCustomerID.Text = nextId.ToString();
            }
            catch (Exception ex)
            {
                lblCustomerName.Text = "New Customer";
                lblCustomerID.Text = "N/A";
                MessageBox.Show($"Unable to retrieve next Customer ID.\n\nDetails: {ex.Message}",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            lblCustomerName.Text = string.IsNullOrWhiteSpace(txtFullName.Text)
                ? "New Customer"
                : txtFullName.Text.Trim();
        }

        public modal_AddEditCustomer(Customer customer) : this()
        {
            _editingCustomer = customer;

            this.Text = "Edit Customer";

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            if (_editingCustomer == null) return;

            lblCustomerName.Text = _editingCustomer.FullName;
            lblCustomerID.Text = _editingCustomer.CustID.ToString();

            txtFullName.Text = _editingCustomer.FullName;
            rdoMale.Checked = _editingCustomer.Gender == "Male";
            rdoFemale.Checked = _editingCustomer.Gender == "Female";
            txtContactNumber.Text = _editingCustomer.PhoneNumber;
            txtAddress.Text = _editingCustomer.Address;
            picCustomer.Image = ImageHelper.ByteArrayToImage(_editingCustomer.Picture);
            picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void ClearFields()
        {
            txtFullName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtContactNumber.Clear();
            txtAddress.Clear();
            picCustomer.Image = null;
        }

        private void btnCustomerImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Customer Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picCustomer.Image = Image.FromFile(ofd.FileName);
                    picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔍 Validation
                Validator.RequireNotEmpty(txtFullName.Text, "Full Name");
                Validator.ValidateLettersOnly(txtFullName.Text, "Full Name");
                Validator.ValidatePhoneNumber(txtContactNumber.Text);
                Validator.RequireNotEmpty(txtAddress.Text, "Address");
                Validator.RequireGenderSelected(rdoMale.Checked, rdoFemale.Checked);
                Validator.RequirePictureSelected(picCustomer, "Customer Picture");

                var currentEmp = SessionManager.LoggedInEmployee;
                if (currentEmp == null)
                    throw new Exception("No logged-in employee detected. Please log in again.");

                var repo = new CustomerRepository();

                if (_editingCustomer == null)
                {
                    //Add new customer
                    var customer = new Customer
                    {
                        FullName = txtFullName.Text.Trim(),
                        Gender = rdoMale.Checked ? "Male" : "Female",
                        PhoneNumber = txtContactNumber.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        RegisteredByEmpID = currentEmp.EmpID,
                        Picture = ImageHelper.ImageToByteArray(picCustomer.Image)
                    };

                    repo.AddCustomer(customer);

                    MessageBox.Show(
                        $"Customer '{customer.FullName}' successfully registered by {currentEmp.FullName}!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    //Edit existing customer
                    _editingCustomer.FullName = txtFullName.Text.Trim();
                    _editingCustomer.Gender = rdoMale.Checked ? "Male" : "Female";
                    _editingCustomer.PhoneNumber = txtContactNumber.Text.Trim();
                    _editingCustomer.Address = txtAddress.Text.Trim();
                    _editingCustomer.Picture = ImageHelper.ImageToByteArray(picCustomer.Image);

                    repo.UpdateCustomer(_editingCustomer);

                    MessageBox.Show(
                        $"Customer '{_editingCustomer.FullName}' successfully updated!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Operation failed.\n\nDetails: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
