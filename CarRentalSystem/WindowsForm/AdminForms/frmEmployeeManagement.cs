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

            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            dgvEmployees.ReadOnly = true;

            dgvEmployees.Refresh();
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
    }
}
