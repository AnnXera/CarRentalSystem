namespace CarRentalSystem.WindowsForm.Modal
{
    partial class frmBilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContractsOverview = new System.Windows.Forms.Panel();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlContractDetails = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblBillingID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnViewBillingLog = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlContractsOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlContractDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContractsOverview
            // 
            this.pnlContractsOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContractsOverview.BackColor = System.Drawing.Color.White;
            this.pnlContractsOverview.Controls.Add(this.btnViewBillingLog);
            this.pnlContractsOverview.Controls.Add(this.dgvBilling);
            this.pnlContractsOverview.Controls.Add(this.pnlSearch);
            this.pnlContractsOverview.Location = new System.Drawing.Point(12, 299);
            this.pnlContractsOverview.Name = "pnlContractsOverview";
            this.pnlContractsOverview.Size = new System.Drawing.Size(1535, 478);
            this.pnlContractsOverview.TabIndex = 76;
            // 
            // dgvBilling
            // 
            this.dgvBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBilling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBilling.EnableHeadersVisualStyles = false;
            this.dgvBilling.Location = new System.Drawing.Point(18, 101);
            this.dgvBilling.Margin = new System.Windows.Forms.Padding(5, 0, 20, 20);
            this.dgvBilling.MultiSelect = false;
            this.dgvBilling.Name = "dgvBilling";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBilling.RowHeadersVisible = false;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.DividerHeight = 1;
            this.dgvBilling.RowTemplate.Height = 40;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBilling.Size = new System.Drawing.Size(1497, 360);
            this.dgvBilling.TabIndex = 75;
            this.dgvBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellContentClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlSearch.Controls.Add(this.pictureBox4);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(20, 20);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(20, 20, 5, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(476, 60);
            this.pnlSearch.TabIndex = 72;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(57, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnPayment.Location = new System.Drawing.Point(1289, 20);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(226, 60);
            this.btnPayment.TabIndex = 59;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnlContractDetails
            // 
            this.pnlContractDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContractDetails.BackColor = System.Drawing.Color.White;
            this.pnlContractDetails.Controls.Add(this.lblStatus);
            this.pnlContractDetails.Controls.Add(this.btnPayment);
            this.pnlContractDetails.Controls.Add(this.lblTotalCharges);
            this.pnlContractDetails.Controls.Add(this.lblRemainingBalance);
            this.pnlContractDetails.Controls.Add(this.lblBaseRate);
            this.pnlContractDetails.Controls.Add(this.label7);
            this.pnlContractDetails.Controls.Add(this.label6);
            this.pnlContractDetails.Controls.Add(this.label5);
            this.pnlContractDetails.Controls.Add(this.label4);
            this.pnlContractDetails.Controls.Add(this.lblTotalAmount);
            this.pnlContractDetails.Controls.Add(this.lblBillingID);
            this.pnlContractDetails.Controls.Add(this.label3);
            this.pnlContractDetails.Controls.Add(this.label2);
            this.pnlContractDetails.Controls.Add(this.lblCustomerName);
            this.pnlContractDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlContractDetails.Name = "pnlContractDetails";
            this.pnlContractDetails.Size = new System.Drawing.Size(1535, 268);
            this.pnlContractDetails.TabIndex = 75;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(961, 195);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 28);
            this.lblStatus.TabIndex = 73;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(545, 195);
            this.lblTotalCharges.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(164, 28);
            this.lblTotalCharges.TabIndex = 72;
            this.lblTotalCharges.Text = "[lblTotalCharges]";
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalance.Location = new System.Drawing.Point(961, 109);
            this.lblRemainingBalance.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(213, 28);
            this.lblRemainingBalance.TabIndex = 71;
            this.lblRemainingBalance.Text = "[lblRemainingBalance]";
            // 
            // lblBaseRate
            // 
            this.lblBaseRate.AutoSize = true;
            this.lblBaseRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseRate.Location = new System.Drawing.Point(545, 109);
            this.lblBaseRate.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblBaseRate.Name = "lblBaseRate";
            this.lblBaseRate.Size = new System.Drawing.Size(130, 28);
            this.lblBaseRate.TabIndex = 70;
            this.lblBaseRate.Text = "[lblBaseRate]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(961, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(545, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "TotalCharges: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(545, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Base Rate: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(961, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Remaining Balance:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 191);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(165, 28);
            this.lblTotalAmount.TabIndex = 65;
            this.lblTotalAmount.Text = "[lblTotalAmount]";
            // 
            // lblBillingID
            // 
            this.lblBillingID.AutoSize = true;
            this.lblBillingID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingID.Location = new System.Drawing.Point(20, 109);
            this.lblBillingID.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblBillingID.Name = "lblBillingID";
            this.lblBillingID.Size = new System.Drawing.Size(124, 28);
            this.lblBillingID.TabIndex = 64;
            this.lblBillingID.Text = "[lblBillingID]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "Billing ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(10, 10);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(10, 10, 3, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(244, 41);
            this.lblCustomerName.TabIndex = 61;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnViewBillingLog
            // 
            this.btnViewBillingLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBillingLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewBillingLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBillingLog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBillingLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnViewBillingLog.Location = new System.Drawing.Point(1289, 21);
            this.btnViewBillingLog.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btnViewBillingLog.Name = "btnViewBillingLog";
            this.btnViewBillingLog.Size = new System.Drawing.Size(226, 60);
            this.btnViewBillingLog.TabIndex = 74;
            this.btnViewBillingLog.Text = "View Billing Log";
            this.btnViewBillingLog.UseVisualStyleBackColor = true;
            this.btnViewBillingLog.Click += new System.EventHandler(this.btnViewBillingLog_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.IconSearch2;
            this.pictureBox4.Location = new System.Drawing.Point(10, 14);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlContractsOverview);
            this.Controls.Add(this.pnlContractDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilling";
            this.Text = "frmBilling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContractsOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlContractDetails.ResumeLayout(false);
            this.pnlContractDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContractsOverview;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlContractDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblBillingID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnViewBillingLog;
    }
}