using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.AdminForms.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmRentalPlanManagement : Form
    {
        private DataTable rentalPlanTable;
        public frmRentalPlanManagement()
        {
            InitializeComponent();
            LoadDesign();
            LoadRentalPlans();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlRentalPlanView,
                pnlSearch
            };
            UIHelper.ApplyRoundedPanels(panels, 8);

            UIHelper.SetPlaceholder(
                txtSearch,
                "Type to Search...",
                Color.Gray,
                new Font("Segoe UI", 12, FontStyle.Italic),
                Color.Black,
                new Font("Segoe UI", 12, FontStyle.Regular)
            );
        }

        private void LoadRentalPlans()
        {
            var rentalPlanFactory = new RentalPlanFactory();
            var rentalPlans = rentalPlanFactory.ViewAll();

            dgvRentalPlan.AllowUserToAddRows = false;
            dgvRentalPlan.RowHeadersVisible = false;
            dgvRentalPlan.AllowUserToResizeRows = false;

            rentalPlanTable = new DataTable();
            rentalPlanTable.Columns.Add("PlanID", typeof(long));
            rentalPlanTable.Columns.Add("PlanName");
            rentalPlanTable.Columns.Add("MileageLimitPerDay");
            rentalPlanTable.Columns.Add("ExcessFeePerKm");
            rentalPlanTable.Columns.Add("DailyRate");
            rentalPlanTable.Columns.Add("Description");

            foreach (var plan in rentalPlans)
            {
                var row = rentalPlanTable.NewRow();
                row["PlanID"] = plan.PlanID;
                row["PlanName"] = plan.PlanName;
                row["MileageLimitPerDay"] = plan.MileageLimitPerDay;
                row["ExcessFeePerKm"] = plan.ExcessFeePerKm;
                row["DailyRate"] = plan.DailyRate;
                row["Description"] = plan.Description;
                rentalPlanTable.Rows.Add(row);
            }

            dgvRentalPlan.DataSource = rentalPlanTable;

            dgvRentalPlan.Columns["PlanID"].HeaderText = "Plan ID";
            dgvRentalPlan.Columns["PlanName"].HeaderText = "Plan Name";
            dgvRentalPlan.Columns["MileageLimitPerDay"].HeaderText = "Mileage Limit/Day";
            dgvRentalPlan.Columns["ExcessFeePerKm"].HeaderText = "Excess Fee/Km";
            dgvRentalPlan.Columns["DailyRate"].HeaderText = "Daily Rate";
            dgvRentalPlan.Columns["Description"].HeaderText = "Description";
            dgvRentalPlan.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvRentalPlan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (dgvRentalPlan.Columns.Contains("Edit"))
                dgvRentalPlan.Columns.Remove("Edit");

            var editColumn = new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.EditIcon2,
                ImageLayout = DataGridViewImageCellLayout.Normal,
                Width = 40,
                ToolTipText = "Edit Rental Plan"
            };

            dgvRentalPlan.Columns.Add(editColumn);

            dgvRentalPlan.RowTemplate.Height = 40;

            dgvRentalPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRentalPlan.Columns["PlanID"].FillWeight = 20;
            dgvRentalPlan.Columns["PlanName"].FillWeight = 40;
            dgvRentalPlan.Columns["MileageLimitPerDay"].FillWeight = 30;
            dgvRentalPlan.Columns["ExcessFeePerKm"].FillWeight = 30;
            dgvRentalPlan.Columns["DailyRate"].FillWeight = 30;
            dgvRentalPlan.Columns["Description"].FillWeight = 50;
            dgvRentalPlan.Columns["Edit"].FillWeight = 15;

            dgvRentalPlan.ReadOnly = true;

            dgvRentalPlan.Refresh();
        }

        private void dgvRentalPlan_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnAddRentalPlan_Click(object sender, System.EventArgs e)
        {
            using (var addRentalPlanModal = new Modals.modal_AddEditRentalPlan())
            {
                addRentalPlanModal.ShowDialog();
            }
        }

        private void dgvRentalPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRentalPlan.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow selectedRow = dgvRentalPlan.Rows[e.RowIndex];

                var rentalPlan = new RentalPlan
                {
                    PlanID = Convert.ToInt64(selectedRow.Cells["PlanID"].Value),
                    PlanName = selectedRow.Cells["PlanName"].Value?.ToString(),
                    MileageLimitPerDay = selectedRow.Cells["MileageLimitPerDay"].Value != DBNull.Value
                        ? (long?)Convert.ToInt64(selectedRow.Cells["MileageLimitPerDay"].Value)
                        : null,
                    ExcessFeePerKm = Convert.ToDecimal(selectedRow.Cells["ExcessFeePerKm"].Value),
                    DailyRate = Convert.ToDecimal(selectedRow.Cells["DailyRate"].Value),
                    Description = selectedRow.Cells["Description"].Value?.ToString()
                };

                var editForm = new modal_AddEditRentalPlan(rentalPlan);
                editForm.ShowDialog();

                LoadRentalPlans();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rentalPlanTable == null)
                return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            DataView dv = rentalPlanTable.DefaultView;
            dv.RowFilter = string.Format("PlanName LIKE '%{0}%'", searchValue);

            dgvRentalPlan.DataSource = dv;
        }
    }
}
