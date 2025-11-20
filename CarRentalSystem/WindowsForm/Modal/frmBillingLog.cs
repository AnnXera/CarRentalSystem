using CarRentalSystem.Code;
using Org.BouncyCastle.Asn1.BC;
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
    public partial class frmBillingLog : Form
    {
        BillingLogFactory billingLogFactory = new BillingLogFactory();

        private DataTable billingLogTable;

        public frmBillingLog()
        {
            InitializeComponent();
            LoadBillingLog();
        }

        private void LoadBillingLog()
        {
            var logs = billingLogFactory.ViewAll(); // Your BillingLogFactory

            dgvBillingLog.AllowUserToAddRows = false;
            dgvBillingLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBillingLog.RowHeadersVisible = false;
            dgvBillingLog.AllowUserToResizeRows = false;

            billingLogTable = new DataTable();
            billingLogTable.Columns.Add("BillLogID", typeof(long));
            billingLogTable.Columns.Add("BillingID", typeof(long));
            billingLogTable.Columns.Add("TransactionDate", typeof(DateTime));
            billingLogTable.Columns.Add("PaymentMethod");
            billingLogTable.Columns.Add("TransactionType");
            billingLogTable.Columns.Add("Amount", typeof(decimal));
            billingLogTable.Columns.Add("Notes");

            foreach (var log in logs)
            {
                var row = billingLogTable.NewRow();
                row["BillLogID"] = log.BillLogID;
                row["BillingID"] = log.BillingID;
                row["TransactionDate"] = log.TransactionDate;
                row["PaymentMethod"] = log.PaymentMethod;
                row["TransactionType"] = log.TransactionType;
                row["Amount"] = log.Amount;
                row["Notes"] = log.Notes ?? string.Empty;
                billingLogTable.Rows.Add(row);
            }

            dgvBillingLog.DataSource = billingLogTable;

            // Hide BillingID if you want
            dgvBillingLog.Columns["BillingID"].Visible = false;

            DataView dv = billingLogTable.DefaultView;
            dv.Sort = "TransactionDate DESC";
            dgvBillingLog.DataSource = dv;

            dgvBillingLog.DefaultCellStyle.NullValue = "NULL";

            dgvBillingLog.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgvBillingLog.Columns["TransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            // Set column headers
            dgvBillingLog.Columns["BillLogID"].HeaderText = "Log ID";
            dgvBillingLog.Columns["TransactionDate"].HeaderText = "Transaction Date";
            dgvBillingLog.Columns["PaymentMethod"].HeaderText = "Payment Method";
            dgvBillingLog.Columns["TransactionType"].HeaderText = "Transaction Type";
            dgvBillingLog.Columns["Amount"].HeaderText = "Amount";
            dgvBillingLog.Columns["Notes"].HeaderText = "Notes";

            dgvBillingLog.ReadOnly = true;
            dgvBillingLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBillingLog.Refresh();
        }

        private void ApplyBillingLogDateFilter()
        {
            if (billingLogTable == null) return;

            DataView dv = billingLogTable.DefaultView;

            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            // Filter by TransactionDate between start and end (inclusive)
            dv.RowFilter = $"TransactionDate >= #{start:yyyy-MM-dd}# AND TransactionDate <= #{end:yyyy-MM-dd}#";

            dgvBillingLog.DataSource = dv;
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyBillingLogDateFilter();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyBillingLogDateFilter();
        }
    }
}
