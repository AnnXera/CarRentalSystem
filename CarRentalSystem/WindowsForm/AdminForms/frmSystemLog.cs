using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_SystemLog;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmSystemLog : Form
    {
        private DataTable systemLogTable;

        public frmSystemLog()
        {
            InitializeComponent();
            LoadDesign();
            LoadComboboxes();
            LoadSystemLogs();
            EventHandlers();
        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                pnlSystemLogView,
                pnlStartDate,
                pnlEndDate,
                pnlEmployee,
                pnlAction
            };
            Utils.UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void EventHandlers()
        {
            dtpStartDate.ValueChanged += (s, e) => ApplyFilters();
            dtpEndDate.ValueChanged += (s, e) => ApplyFilters();
            cbxAction.SelectedIndexChanged += (s, e) => ApplyFilters();
            cbxEmployeeNames.SelectedIndexChanged += (s, e) => ApplyFilters();
            cbxEmployeeNames.TextChanged += (s, e) => ApplyFilters();
        }

        private void LoadComboboxes()
        {
            var employeeFactory = new EmployeeFactory();
            var allEmployees = employeeFactory.ViewAll();

            // Populate Employee ComboBox by Name
            cbxEmployeeNames.DataSource = allEmployees;
            cbxEmployeeNames.DisplayMember = "FullName";
            cbxEmployeeNames.ValueMember = "EmpID";
            cbxEmployeeNames.SelectedIndex = -1;

            cbxEmployeeNames.DropDownStyle = ComboBoxStyle.DropDown;
            cbxEmployeeNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxEmployeeNames.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxAction.DataSource = EnumHelper.GetEnumDescriptions();
            cbxAction.DisplayMember = "Value";
            cbxAction.ValueMember = "Key";
            cbxAction.SelectedIndex = -1;

            cbxAction.DropDownStyle = ComboBoxStyle.DropDown;
            cbxAction.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAction.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadSystemLogs()
        {
            var systemLogFactory = new SystemLogFactory();
            var systemLog = systemLogFactory.ViewAll();

            dgvSystemLog.AllowUserToAddRows = false;
            dgvSystemLog.RowHeadersVisible = false;
            dgvSystemLog.AllowUserToResizeRows = false;

            systemLogTable = new DataTable();
            systemLogTable.Columns.Add("EmployeeName");
            systemLogTable.Columns.Add("Action");
            systemLogTable.Columns.Add("Description");
            systemLogTable.Columns.Add("LogDate");

            foreach (var log in systemLog)
            {
                var row = systemLogTable.NewRow();
                row["EmployeeName"] = log.EmployeeName;
                row["Action"] = log.Action;
                row["Description"] = log.Description;
                row["LogDate"] = log.LogDate;
                systemLogTable.Rows.Add(row);
            }

            dgvSystemLog.DataSource = systemLogTable;

            dgvSystemLog.Columns["EmployeeName"].HeaderText = "Employee Name";
            dgvSystemLog.Columns["Action"].HeaderText = "Action";
            dgvSystemLog.Columns["Description"].HeaderText = "Description";
            dgvSystemLog.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSystemLog.Columns["LogDate"].HeaderText = "Log Date";

            dgvSystemLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvSystemLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSystemLog.Columns["EmployeeName"].FillWeight = 40;
            dgvSystemLog.Columns["Action"].FillWeight = 20;
            dgvSystemLog.Columns["Description"].FillWeight = 60;
            dgvSystemLog.Columns["LogDate"].FillWeight = 30;

            dgvSystemLog.ReadOnly = true;

            dgvSystemLog.Refresh();
        }

        private void ApplyFilters()
        {
            if (systemLogTable == null || systemLogTable.Rows.Count == 0)
                return;

            string filter = "1 = 1";

            // Filter by Employee NAME
            if (!string.IsNullOrWhiteSpace(cbxEmployeeNames.Text))
            {
                string empName = cbxEmployeeNames.Text.Replace("'", "''");
                filter += $" AND EmployeeName LIKE '%{empName}%'";
            }

            // Filter by Action
            if (!string.IsNullOrWhiteSpace(cbxAction.Text))
            {
                string action = cbxAction.Text.Replace("'", "''");
                filter += $" AND Action = '{action}'";
            }

            // Filter by Date Range
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

            filter += $" AND LogDate >= #{start:yyyy-MM-dd HH:mm:ss}#";
            filter += $" AND LogDate <= #{end:yyyy-MM-dd HH:mm:ss}#";

            // Apply filter
            DataView dv = new DataView(systemLogTable);
            dv.RowFilter = filter;

            dgvSystemLog.DataSource = dv;
        }


        private void dgvSystemLog_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbxEmployeeNames.SelectedIndex = -1;
            cbxEmployeeNames.Text = "";

            cbxAction.SelectedIndex = -1;

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            dgvSystemLog.DataSource = systemLogTable;
        }
    }
}
