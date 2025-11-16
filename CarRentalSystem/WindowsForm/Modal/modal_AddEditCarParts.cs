using CarRentalSystem.Code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_AddEditCarParts : Form
    {
        //txtPartName, txtCost

        public CarParts NewPart { get; set; }
        private bool _isEditMode;

        public modal_AddEditCarParts(bool isEditMode = false)
        {
            InitializeComponent();
            _isEditMode = isEditMode;

            if (_isEditMode)
            {
                lblPart.Text = "Edit Car Part";
                btnSave.Text = "UPDATE";
                this.Text = "Edit Car";
            }
            else
            {
                lblPart.Text = "Add New Car Part";
                btnSave.Text = "ADD";
                this.Text = "Add New Car";
                cbxStatus.Visible = false;
                lblStatus.Visible = false;
            }
        }

        public void LoadExistingPart()
        {
            if (NewPart != null)
            {
                txtPartName.Text = NewPart.PartName;
                txtCost.Text = NewPart.ReplacementCost.ToString("0.00");
                cbxStatus.Text = NewPart.Status;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtPartName.Text))
                    throw new Exception("Part Name is required.");

                if (string.IsNullOrWhiteSpace(txtCost.Text))
                    throw new Exception("Replacement Cost is required.");

                if (!decimal.TryParse(txtCost.Text, out decimal cost))
                    throw new Exception("Invalid cost format.");

                // Create new part object
                NewPart = new CarParts
                {
                    PartName = txtPartName.Text.Trim(),
                    ReplacementCost = cost,
                    Status = cbxStatus.Visible ? cbxStatus.Text : "Good"
                };

                // Return OK so parent form knows a part was added
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
