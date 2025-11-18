using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using CarRentalSystem.WindowsForm.AdminForms.Modals;
using CarRentalSystem.WindowsForm.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmEmployeeManagement : Form
    {
        private DataTable employeeTable;
        public frmEmployeeManagement()
        {
            InitializeComponent();

            LoadDesign();
            LoadEmployees();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlEmployeeView,
                pnlSearch
            };
            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void LoadEmployees()
        {
            var employeeFactory = new EmployeeFactory();
            var employees = employeeFactory.ViewAll();

            // DataGridView Settings
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.AllowUserToResizeRows = false;

            employeeTable = new DataTable();
            employeeTable.Columns.Add("EmpID", typeof(long));
            employeeTable.Columns.Add("FullName");
            employeeTable.Columns.Add("Username");
            employeeTable.Columns.Add("Role");

            foreach (var emp in employees)
            {
                var row = employeeTable.NewRow();
                row["EmpID"] = emp.EmpID;
                row["FullName"] = emp.FullName;
                row["Username"] = emp.Username;
                row["Role"] = emp.Role;
                employeeTable.Rows.Add(row);
            }

            dgvEmployees.DataSource = employeeTable;

            dgvEmployees.Columns["EmpID"].HeaderText = "Employee ID";
            dgvEmployees.Columns["FullName"].HeaderText = "Full Name";
            dgvEmployees.Columns["Username"].HeaderText = "Username";
            dgvEmployees.Columns["Role"].HeaderText = "Role";

            if (dgvEmployees.Columns.Contains("Edit"))
                dgvEmployees.Columns.Remove("Edit");

            var editColumn = new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.EditIcon2,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40,
                ToolTipText = "Edit Employee"
            };

            dgvEmployees.Columns.Add(editColumn);


            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployees.Columns["EmpID"].FillWeight = 30;
            dgvEmployees.Columns["FullName"].FillWeight = 60;
            dgvEmployees.Columns["Username"].FillWeight = 40;
            dgvEmployees.Columns["Role"].FillWeight = 30;
            dgvEmployees.Columns["Edit"].FillWeight = 15;

            dgvEmployees.ReadOnly = true;

            dgvEmployees.Refresh();

            // Total Employees Count
            lblTotalEmployees.Text = $"Total Employees: {employees.Count}";
        }

        private void dgvEmployees_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var addEmployeeModal = new modal_AddEditEmployee())
            {
                addEmployeeModal.ShowDialog();
                LoadEmployees();
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            if (dgvEmployees.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow selectedRow = dgvEmployees.Rows[e.RowIndex];

                var employee = new Employee
                {
                    EmpID = Convert.ToInt64(selectedRow.Cells["EmpID"].Value),
                    FullName = selectedRow.Cells["FullName"].Value?.ToString(),
                    Username = selectedRow.Cells["Username"].Value?.ToString(),
                    Role = selectedRow.Cells["Role"].Value?.ToString()
                };

                var editForm = new modal_AddEditEmployee(employee);
                editForm.ShowDialog();

                LoadEmployees();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (employeeTable == null)
                return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            DataView dv = employeeTable.DefaultView;
            dv.RowFilter = string.Format("FullName LIKE '%{0}%'", searchValue);

            dgvEmployees.DataSource = dv;
        }
    }
}
