using CarRentalSystem.Code;
using CarRentalSystem.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using static CarRentalSystem.Code.Enum.enum_SystemLog;

namespace CarRentalSystem.WindowsForm.AdminForms
{
    public partial class frmSystemLog : Form
    {
        public frmSystemLog()
        {
            InitializeComponent();
            LoadDesign();
            LoadComboboxes();
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
        }

        private void dgvSystemLog_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.DrawRoundedControl(sender, e, 8);
        }
    }
}
