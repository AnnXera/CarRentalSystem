using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.Modal;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmContractsManagement : Form
    {
        private List<ContractViewModel> allContracts;
        private BindingSource bindingSource;

        public frmContractsManagement()
        {
            InitializeComponent();
        }

        private void frmContractsManagement_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeForm();
                LoadContracts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeForm()
        {
            bindingSource = new BindingSource();

            // Setup dataGridView1
            try
            {
                dataGridView1.DataSource = bindingSource;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = SystemColors.Window;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

                // Add CellClick event for displaying details
                dataGridView1.CellClick += (s, e) => {
                    if (e.RowIndex >= 0)
                        DisplayContractDetails(e.RowIndex);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing grid: {ex.Message}");
            }

            // Setup status filter ComboBox
            try
            {
                ComboBox cbo = this.Controls.Find("cboStatusFilter", true).FirstOrDefault() as ComboBox;
                if (cbo != null)
                {
                    cbo.Items.Clear();
                    cbo.Items.Add("All");
                    cbo.Items.Add("Pending");
                    cbo.Items.Add("Active");
                    cbo.Items.Add("Completed");
                    cbo.Items.Add("Cancelled");
                    cbo.SelectedIndex = 0;
                    cbo.SelectedIndexChanged += CboStatusFilter_SelectedIndexChanged;
                }
            }
            catch { }

            // Setup New Rental button
            try
            {
                Button btn = this.Controls.Find("btnNewRental", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Click += btnNewRental_Click;
                }
            }
            catch { }

            // Setup Process Return button
            try
            {
                Button btn = this.Controls.Find("btnProcessReturn", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Click += btnProcessReturn_Click;
                }
            }
            catch { }

            // Setup Payment button
            try
            {
                Button btn = this.Controls.Find("btnPayment", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Click += btnPayment_Click;
                }
            }
            catch { }
        }

        private void LoadContracts()
        {
            try
            {
                var contractFactory = new ContractFactory();
                var contracts = contractFactory.ViewAll();

                // DEBUG: Check if contracts are being loaded
                MessageBox.Show($"Found {contracts.Count} contracts in database", "Debug Info");

                var customerFactory = new CustomerFactory();
                var customers = customerFactory.ViewAll();

                var carFactory = new CarFactory();
                var cars = carFactory.ViewAll();

                allContracts = new List<ContractViewModel>();

                foreach (var contract in contracts)
                {
                    var customer = customers.FirstOrDefault(c => c.CustID == contract.CustID);
                    var car = cars.FirstOrDefault(c => c.CarID == contract.CarID);

                    // Get rental plan name
                    string planName = car?.PlanName ?? "N/A";

                    allContracts.Add(new ContractViewModel
                    {
                        ContractId = contract.ContractID,
                        CustomerName = customer?.FullName ?? "Unknown",
                        RentalPlan = planName,
                        CarDescription = car?.CarDescription ?? "Unknown",
                        StartDate = contract.StartDate,
                        ReturnDate = contract.ReturnDate,
                        DaysRented = contract.DaysRented,
                        Status = contract.Status
                    });
                }

                // DEBUG: Check how many view models were created
                MessageBox.Show($"Created {allContracts.Count} contract view models", "Debug Info");

                RefreshDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contracts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDisplay(string statusFilter = "All")
        {
            try
            {
                if (allContracts == null)
                {
                    allContracts = new List<ContractViewModel>();
                }

                var filteredContracts = allContracts;

                if (statusFilter != "All")
                {
                    filteredContracts = allContracts.Where(c => c.Status == statusFilter).ToList();
                }

                // Convert to display format
                var displayList = filteredContracts.Select(c => new
                {
                    ContractID = c.ContractId,
                    CustomerName = c.CustomerName,
                    RentalPlan = c.RentalPlan,
                    Car = c.CarDescription,
                    StartDate = c.StartDate.ToString("MM/dd/yyyy"),
                    ReturnDate = c.ReturnDate.ToString("MM/dd/yyyy"),
                    DaysRented = c.DaysRented,
                    Status = c.Status
                }).ToList();

                // Directly set DataSource - no BindingSource needed
                dataGridView1.DataSource = null; // Clear first
                dataGridView1.DataSource = displayList;

                // Update column headers
                if (dataGridView1.Columns["ContractID"] != null)
                    dataGridView1.Columns["ContractID"].HeaderText = "Contract ID";
                if (dataGridView1.Columns["CustomerName"] != null)
                    dataGridView1.Columns["CustomerName"].HeaderText = "Customer";
                if (dataGridView1.Columns["RentalPlan"] != null)
                    dataGridView1.Columns["RentalPlan"].HeaderText = "Rental Plan";
                if (dataGridView1.Columns["Car"] != null)
                    dataGridView1.Columns["Car"].HeaderText = "Car";
                if (dataGridView1.Columns["StartDate"] != null)
                    dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
                if (dataGridView1.Columns["ReturnDate"] != null)
                    dataGridView1.Columns["ReturnDate"].HeaderText = "Return Date";
                if (dataGridView1.Columns["DaysRented"] != null)
                    dataGridView1.Columns["DaysRented"].HeaderText = "Days";
                if (dataGridView1.Columns["Status"] != null)
                    dataGridView1.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing display: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cbo = sender as ComboBox;
                if (cbo != null && cbo.SelectedItem != null)
                {
                    RefreshDisplay(cbo.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            try
            {
                using (var createContractModal = new modal_CreateContract())
                {
                    if (createContractModal.ShowDialog() == DialogResult.OK)
                    {
                        // Reload contracts after successful creation
                        LoadContracts();
                        MessageBox.Show("Contract created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    if (long.TryParse(selectedRow.Cells["ContractID"].Value?.ToString() ?? "", out long contractId))
                    {
                        var contract = allContracts.FirstOrDefault(c => c.ContractId == contractId);

                        if (contract != null)
                        {
                            modal_ProcessReturn returnModal = new modal_ProcessReturn((int)contractId);

                            if (returnModal.ShowDialog() == DialogResult.OK)
                            {
                                // Reload contracts after processing return
                                LoadContracts();
                                MessageBox.Show("Return processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a contract first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing return: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    if (long.TryParse(selectedRow.Cells["ContractID"].Value?.ToString() ?? "", out long contractId))
                    {
                        var contract = allContracts.FirstOrDefault(c => c.ContractId == contractId);

                        if (contract != null)
                        {
                            modal_Payment paymentModal = new modal_Payment((int)contractId);

                            if (paymentModal.ShowDialog() == DialogResult.OK)
                            {
                                MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadContracts();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a contract first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DisplayContractDetails(e.RowIndex);
            }
        }

        private void DisplayContractDetails(int rowIndex)
        {
            try
            {
                var row = dataGridView1.Rows[rowIndex];

                if (long.TryParse(row.Cells["ContractID"].Value?.ToString() ?? "", out long contractId))
                {
                    var contract = allContracts.FirstOrDefault(c => c.ContractId == contractId);

                    if (contract != null)
                    {
                        // Customer Name - label1
                        Label label1 = this.Controls.Find("label1", true).FirstOrDefault() as Label;
                        if (label1 != null)
                            label1.Text = contract.CustomerName;

                        // Rental Plan - label2
                        Label label2 = this.Controls.Find("label2", true).FirstOrDefault() as Label;
                        if (label2 != null)
                            label2.Text = contract.RentalPlan;

                        // Car - label3
                        Label label3 = this.Controls.Find("label3", true).FirstOrDefault() as Label;
                        if (label3 != null)
                            label3.Text = contract.CarDescription;

                        // Return Date - label4
                        Label label4 = this.Controls.Find("label4", true).FirstOrDefault() as Label;
                        if (label4 != null)
                            label4.Text = contract.ReturnDate.ToString("MM/dd/yyyy");

                        // Start Date - label5
                        Label label5 = this.Controls.Find("label5", true).FirstOrDefault() as Label;
                        if (label5 != null)
                            label5.Text = contract.StartDate.ToString("MM/dd/yyyy");

                        // Days Rented - label6
                        Label label6 = this.Controls.Find("label6", true).FirstOrDefault() as Label;
                        if (label6 != null)
                            label6.Text = contract.DaysRented.ToString();

                        // Status - label7
                        Label label7 = this.Controls.Find("label7", true).FirstOrDefault() as Label;
                        if (label7 != null)
                            label7.Text = contract.Status;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying contract details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabel(string[] possibleNames, string value)
        {
            foreach (var name in possibleNames)
            {
                Label label = this.Controls.Find(name, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = value;
                    return; // Found and updated, exit
                }
            }
            // If we get here, label wasn't found - this is okay for debugging
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting logic here if needed
            // For now, just let the DataGridView paint normally
        }
    }

    // ViewModel class for displaying contracts
    public class ContractViewModel
    {
        public long ContractId { get; set; }
        public string CustomerName { get; set; }
        public string RentalPlan { get; set; }
        public string CarDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int DaysRented { get; set; }
        public string Status { get; set; }
    }
}