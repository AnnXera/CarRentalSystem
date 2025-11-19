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
    public partial class modal_ProcessReturn : Form
    {

        private Contracts _selectedContract;
        private List<Contracts> _activeContracts;


        public modal_ProcessReturn()
        {
            InitializeComponent();
            LoadPanels();
            LoadCustomerDropdown();
            SetupCarPartsGrid();
            dgvCarParts.DataSource = null;
        }

        private void LoadPanels()
        {
            var panels = new List<Panel>
            {
                pnlCustomer,
                pnlCharges,
                pnlBilling
            };
            UIHelper.ApplyRoundedPanels(panels, 10);

            UIHelper.ApplyBorderInsideToPanels(new List<Panel>
            {
                pnlSearch,
                pnlCarPartsSearch,
                pnlMileage,
                pnlSecurityDeposit,
                pnlCarPartsSearch
            });
        }

        private void LoadCustomerDropdown()
        {
            var factory = new ContractFactory();
            _activeContracts = factory.GetActiveContracts();

            cbxSearch.DataSource = _activeContracts;
            cbxSearch.DisplayMember = "CustomerName";
            cbxSearch.ValueMember = "ContractID";
            cbxSearch.SelectedIndex = -1;

            cbxSearch.DropDownStyle = ComboBoxStyle.DropDown;
            cbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadCarParts(long carId)
        {
            try
            {
                var factory = new CarPartsFactory();
                var parts = factory.ViewByCar(carId) ?? new List<CarParts>();

                dgvCarParts.DataSource = parts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load car parts: " + ex.Message);
            }
        }

        private void SetupCarPartsGrid()
        {
            dgvCarParts.AutoGenerateColumns = false;
            dgvCarParts.Columns.Clear();
            var colPartID = new DataGridViewTextBoxColumn
            {
                Name = "PartsID",
                DataPropertyName = "PartsID", // Make sure your CarParts class has PartID property
                Visible = false // Hide from the user
            };
            dgvCarParts.Columns.Add(colPartID);
            // ---------------- Part Name Column ----------------
            var colName = new DataGridViewTextBoxColumn
            {
                HeaderText = "Part Name",
                DataPropertyName = "PartName",
                ReadOnly = true
            };
            dgvCarParts.Columns.Add(colName);

            // ---------------- Damage Checkbox Column ----------------
            var colDamage = new DataGridViewCheckBoxColumn
            {
                Name = "Damage",
                HeaderText = "Damage",
                DataPropertyName = "IsDamaged",
                TrueValue = true,
                FalseValue = false,
                ReadOnly = false // Editable
            };
            dgvCarParts.Columns.Add(colDamage);

            // ---------------- Quantity Column (temporary, not in DB) ----------------
            var colQuantity = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Name = "Quantity", // Use Name to access it in code
                ValueType = typeof(int),
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            };
            dgvCarParts.Columns.Add(colQuantity);

            // ---------------- Replacement Cost Column ----------------
            var colCost = new DataGridViewTextBoxColumn
            {
                Name = "Cost",
                HeaderText = "Cost",
                DataPropertyName = "ReplacementCost",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            };
            dgvCarParts.Columns.Add(colCost);

            dgvCarParts.CellValueChanged += DgvCarParts_CellValueChanged;
            dgvCarParts.CurrentCellDirtyStateChanged += DgvCarParts_CurrentCellDirtyStateChanged;
        }


        private void DisplayContract(Contracts selected)
        {
            if (selected != null)
            {
                _selectedContract = selected;

                lblFullName.Text = selected.CustomerName;
                lblCarName.Text = selected.CarName;
                lblRegisteredEmployee.Text = selected.EmployeeName;
                lblSecurityDeposit.Text = selected.DepositAmount.ToString("N2");
                lblBaseRate.Text = (selected.BaseRate ?? 0).ToString("N2");
                lblRentalPlan.Text = selected.PlanName;
                lblMileageLimit.Text = selected.MileageLimit.ToString("N0") + " km";
                lblRate.Text = selected.ExcessFeePerKm.ToString("N2") + " per km";
                lblDueDate.Text = selected.ReturnDate.ToString("MMMM dd, yyyy");

                chbxLateReturn.Checked = DateTime.Now.Date > selected.ReturnDate.Date;

                LoadCarParts(_selectedContract.CarID);

                UpdateSubtotalAndTotal();

                // Display customer driver license
                if (selected.DriversLicensePic != null && selected.DriversLicensePic.Length > 0)
                {
                    Image driverImg = ImageHelper.ByteArrayToImage(selected.DriversLicensePic);
                    picCustomer.Image = ImageHelper.ResizeImage(driverImg, 240, 152);
                    picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    Image defaultImg = Properties.Resources.SampleDriver_s_License;
                    picCustomer.Image = ImageHelper.ResizeImage(defaultImg, 240, 152);
                    picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
                }

                // Display car image
                if (selected.CarPicture != null && selected.CarPicture.Length > 0)
                {
                    Image carImg = ImageHelper.ByteArrayToImage(selected.CarPicture);
                    picCar.Image = ImageHelper.ResizeImage(carImg, 429, 276);
                    picCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    Image defaultCarImg = Properties.Resources.CarSamplePic;
                    picCar.Image = ImageHelper.ResizeImage(defaultCarImg, 429, 276);
                    picCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                // Reset to defaults
                _selectedContract = null;

                lblFullName.Text = "";
                lblCarName.Text = "";
                lblRegisteredEmployee.Text = "";
                lblSecurityDeposit.Text = "0.00";
                lblBaseRate.Text = "0.00";
                lblRate.Text = "0.00";
                lblRentalPlan.Text = "";
                lblMileageLimit.Text = "0 km";
                lblDueDate.Text = "";
                lblLost.Text = "0.00";
                lblMileageFee.Text = "0.00";
                lblCarPartsCharges.Text = "0.00";
                lblLateFee.Text = "0.00";
                lblTotalChargeFee.Text = "0.00";
                lblSubTotal.Text = "0.00";
                lblTotalAmount.Text = "0.00";
                chbxLateReturn.Checked = false;

                Image defaultDriver = Properties.Resources.SampleDriver_s_License;
                picCustomer.Image = ImageHelper.ResizeImage(defaultDriver, 240, 152);
                picCustomer.SizeMode = PictureBoxSizeMode.Zoom;

                Image defaultCar = Properties.Resources.CarSamplePic;
                picCar.Image = ImageHelper.ResizeImage(defaultCar, 429, 276);
                picCar.SizeMode = PictureBoxSizeMode.Zoom;

                dgvCarParts.DataSource = null;
            }
        }

        private void UpdateSubtotalAndTotal()
        {
            // Helper function to safely convert labels to decimal
            decimal SafeDecimal(Label lbl)
            {
                if (decimal.TryParse(lbl.Text, out decimal val))
                    return val;
                return 0m;
            }

            decimal SafeDecimalTextBox(TextBox txt)
            {
                if (decimal.TryParse(txt.Text, out decimal val))
                    return val;
                return 0m;
            }

            decimal baseRate = SafeDecimal(lblBaseRate);
            decimal mileageFee = SafeDecimal(lblMileageFee);
            decimal lateFee = SafeDecimal(lblLateFee);
            decimal partsFee = SafeDecimal(lblCarPartsCharges);
            decimal lostFee = SafeDecimal(lblLost);

            decimal totalChargeFee = mileageFee + lateFee + partsFee + lostFee;
            lblTotalChargeFee.Text = totalChargeFee.ToString("N2");

            decimal subtotal = baseRate + totalChargeFee;
            lblSubTotal.Text = subtotal.ToString("N2");

            decimal securityDeposit = SafeDecimalTextBox(txtSecurityDeposit);
            decimal total = subtotal - securityDeposit;

            lblTotalAmount.Text = total.ToString("N2");
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedItem is Contracts selected)
            {
                DisplayContract(selected);
            }
            else
            {
                DisplayContract(null);
            }
        }

        private void cbxSearch_TextChanged(object sender, EventArgs e)
        {
            string typedText = cbxSearch.Text.Trim();

            var matchedContract = _activeContracts
                .FirstOrDefault(c => c.CustomerName.Equals(typedText, StringComparison.OrdinalIgnoreCase));

            DisplayContract(matchedContract);
        }

        private void txtEndMileage_TextChanged(object sender, EventArgs e)
        {
            if (_selectedContract == null)
            {
                lblMileageFee.Text = "0.00";
                return;
            }

            if (!long.TryParse(txtEndMileage.Text, out long drivenDistance))
            {
                lblMileageFee.Text = "0.00";
                return;
            }

            decimal excessFee = Math.Max(0, (drivenDistance - _selectedContract.MileageLimit) * _selectedContract.ExcessFeePerKm);
            lblMileageFee.Text = excessFee.ToString("N2");

            UpdateSubtotalAndTotal();
        }

        private void chbxLateReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedContract == null)
            {
                lblLateFee.Text = "0.00";
                UpdateSubtotalAndTotal();
                return;
            }

            decimal lateFeePerDay = 50.00m;
            int overdueDays = 0;

            if (DateTime.Now.Date > _selectedContract.ReturnDate.Date)
            {
                overdueDays = (DateTime.Now.Date - _selectedContract.ReturnDate.Date).Days;
            }

            decimal lateFee = chbxLateReturn.Checked ? lateFeePerDay * overdueDays : 0m;
            lblLateFee.Text = lateFee.ToString("N2");

            UpdateSubtotalAndTotal();
        }

        private void DgvCarParts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCarParts.IsCurrentCellDirty)
                dgvCarParts.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void DgvCarParts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvCarParts.Columns["Damage"].Index ||
                e.ColumnIndex == dgvCarParts.Columns["Quantity"].Index)
            {
                UpdateCarPartsCharges();
            }
        }

        private void UpdateCarPartsCharges()
        {
            decimal total = 0m;

            foreach (DataGridViewRow row in dgvCarParts.Rows)
            {
                bool isDamaged = false;
                int quantity = 1;

                if (row.Cells["Damage"].Value != null)
                    isDamaged = Convert.ToBoolean(row.Cells["Damage"].Value);

                if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out int q))
                    quantity = Math.Max(1, q);

                if (isDamaged)
                {
                    decimal cost = Convert.ToDecimal(row.Cells["Cost"].Value);
                    total += cost * quantity;
                }
            }

            lblCarPartsCharges.Text = total.ToString("N2");
            UpdateSubtotalAndTotal(); 
        }

        private void chbxLost_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedContract == null) return;

            if (chbxLost.Checked)
            {
                // Disable car parts grid
                dgvCarParts.Enabled = false;

                // Show car lost fee — car replacement value
                decimal replacementValue = _selectedContract.ReplacementValue;
                lblLost.Text = replacementValue.ToString("N2");

                // When lost, no need to compute car parts
                lblCarPartsCharges.Text = "0.00";
            }
            else
            {
                // Re-enable the grid
                dgvCarParts.Enabled = true;

                // Remove the lost fee
                lblLost.Text = "0.00";

                // Recalculate parts again
                UpdateCarPartsCharges();
            }

            // Always refresh totals
            UpdateSubtotalAndTotal();
        }

        private void txtSecurityDeposit_TextChanged(object sender, EventArgs e)
        {
            // If empty or invalid, treat as 0
            if (string.IsNullOrWhiteSpace(txtSecurityDeposit.Text))
            {
                txtSecurityDeposit.SelectionStart = txtSecurityDeposit.Text.Length;
            }

            // Validate input
            if (!decimal.TryParse(txtSecurityDeposit.Text, out decimal deposit))
            {
                lblTotalAmount.Text = "0.00";
                return;
            }

            // Recalculate totals
            UpdateSubtotalAndTotal();
        }

        private void txtSecurityDeposit_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSecurityDeposit.Text, out decimal deposit))
                txtSecurityDeposit.Text = deposit.ToString("N2");
        }

        private void btnFinalizePayment_Click(object sender, EventArgs e)
        {
            
        }
    }
}
