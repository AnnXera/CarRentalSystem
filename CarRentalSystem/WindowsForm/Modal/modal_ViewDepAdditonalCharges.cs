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
using static CarRentalSystem.Code.Enum.enum_Contracts;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class modal_ViewDepAdditonalCharges : Form
    {

        public long BillingID { get; set; }
        public AdditionalChargesRepository AditionalRepo { get; set; } = new AdditionalChargesRepository();

        public modal_ViewDepAdditonalCharges()
        {

            //lblDepositAmount and dgvAdditionalCharges
            InitializeComponent();
            LoadDesign();

            this.Text = "View Security Deposit and Additonal Charges";

        }

        private void LoadDesign()
        {
            var panels = new List<Panel>
            {
                panel1,
                panel2,
            };

            UIHelper.ApplyRoundedPanels(panels, 8);
        }

        private void modal_ViewDepAdditonalCharges_Load(object sender, EventArgs e)
        {
            if (BillingID <= 0)
                return;

            var info = AditionalRepo.GetContractChargesInfo(BillingID);

            lblDepositAmount.Text = info.SecurityDeposit.ToString("N2");
            lblSecurityDepUsed.Text = info.SecurityDepUsed.ToString("N2");

            dgvAdditionalCharges.DataSource = info.AdditionalChargesTable;

            dgvAdditionalCharges.AllowUserToAddRows = false;
            dgvAdditionalCharges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAdditionalCharges.RowHeadersVisible = false;
            dgvAdditionalCharges.AllowUserToResizeRows = false;
            dgvAdditionalCharges.ReadOnly = true;
            dgvAdditionalCharges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Format numeric/date columns
            if (dgvAdditionalCharges.Columns.Contains("Amount"))
                dgvAdditionalCharges.Columns["Amount"].DefaultCellStyle.Format = "N2";

            if (dgvAdditionalCharges.Columns.Contains("SecurityDeposit"))
                dgvAdditionalCharges.Columns["SecurityDeposit"].DefaultCellStyle.Format = "N2";

            if (dgvAdditionalCharges.Columns.Contains("ChargeDate"))
                dgvAdditionalCharges.Columns["ChargeDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // Set header texts
            if (dgvAdditionalCharges.Columns.Contains("ChargeID"))
                dgvAdditionalCharges.Columns["ChargeID"].HeaderText = "Charge ID";

            if (dgvAdditionalCharges.Columns.Contains("ChargeType"))
                dgvAdditionalCharges.Columns["ChargeType"].HeaderText = "Charge Type";

            if (dgvAdditionalCharges.Columns.Contains("PartID"))
                dgvAdditionalCharges.Columns["PartID"].HeaderText = "Part ID";

            if (dgvAdditionalCharges.Columns.Contains("Quantity"))
                dgvAdditionalCharges.Columns["Quantity"].HeaderText = "Quantity";

            if (dgvAdditionalCharges.Columns.Contains("Notes"))
                dgvAdditionalCharges.Columns["Notes"].HeaderText = "Notes";

            // Optional: hide internal IDs
            if (dgvAdditionalCharges.Columns.Contains("ChargeID"))
                dgvAdditionalCharges.Columns["ChargeID"].Visible = false;

            if (dgvAdditionalCharges.Columns.Contains("PartID"))
                dgvAdditionalCharges.Columns["PartID"].Visible = false;

            dgvAdditionalCharges.Refresh();
        }

        
    }
}
