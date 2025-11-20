using CarRentalSystem.Code;
using CarRentalSystem.Database;
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
    public partial class modal_ViewDepAdditonalCharges : Form
    {

        public long BillingID { get; set; }
        public AdditionalChargesRepository AditionalRepo { get; set; } = new AdditionalChargesRepository();

        public modal_ViewDepAdditonalCharges()
        {

            //lblDepositAmount and dgvAdditionalCharges
            InitializeComponent();

            this.Text = "View Security Deposit and Additonal Charges";

        }

        private void modal_ViewDepAdditonalCharges_Load(object sender, EventArgs e)
        {
            if (BillingID <= 0)
                return;

            var info = AditionalRepo.GetContractChargesInfo(BillingID);

            // SET LABEL
            lblDepositAmount.Text = info.SecurityDeposit.ToString("N2");

            // SET DATAGRID
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
