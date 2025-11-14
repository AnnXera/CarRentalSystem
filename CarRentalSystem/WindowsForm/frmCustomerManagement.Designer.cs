namespace CarRentalSystem.WindowsForm
{
    partial class frmCustomerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCustomerDetails = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlCustomerView = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnCustomerAddEdit = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.pnlCustomerDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlCustomerView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerDetails.BackColor = System.Drawing.Color.White;
            this.pnlCustomerDetails.Controls.Add(this.picCustomer);
            this.pnlCustomerDetails.Controls.Add(this.lblAddress);
            this.pnlCustomerDetails.Controls.Add(this.lblGender);
            this.pnlCustomerDetails.Controls.Add(this.label10);
            this.pnlCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.pnlCustomerDetails.Controls.Add(this.label30);
            this.pnlCustomerDetails.Controls.Add(this.label6);
            this.pnlCustomerDetails.Controls.Add(this.lblCustomerID);
            this.pnlCustomerDetails.Controls.Add(this.label3);
            this.pnlCustomerDetails.Controls.Add(this.label33);
            this.pnlCustomerDetails.Controls.Add(this.lblFullName);
            this.pnlCustomerDetails.Location = new System.Drawing.Point(11, 11);
            this.pnlCustomerDetails.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(1535, 268);
            this.pnlCustomerDetails.TabIndex = 53;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(888, 140);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(241, 28);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "123 Main St, Davao City";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(404, 217);
            this.lblGender.Margin = new System.Windows.Forms.Padding(0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 28);
            this.lblGender.TabIndex = 64;
            this.lblGender.Text = "Male";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(887, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 28);
            this.label10.TabIndex = 61;
            this.label10.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(888, 64);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(167, 28);
            this.lblPhoneNumber.TabIndex = 58;
            this.lblPhoneNumber.Text = "0917-XXX-XXXX";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Gray;
            this.label30.Location = new System.Drawing.Point(403, 177);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 28);
            this.label30.TabIndex = 63;
            this.label30.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(887, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 57;
            this.label6.Text = "Phone Number:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(404, 65);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(24, 28);
            this.lblCustomerID.TabIndex = 62;
            this.lblCustomerID.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(403, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Customer ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(403, 102);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 28);
            this.label33.TabIndex = 53;
            this.label33.Text = "Full Name:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(404, 142);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(101, 28);
            this.lblFullName.TabIndex = 55;
            this.lblFullName.Text = "John Doe";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlSearch.Controls.Add(this.pictureBox4);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(18, 20);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(20, 20, 5, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(476, 60);
            this.pnlSearch.TabIndex = 71;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(68, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlCustomerView
            // 
            this.pnlCustomerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerView.BackColor = System.Drawing.Color.White;
            this.pnlCustomerView.Controls.Add(this.dgvCustomers);
            this.pnlCustomerView.Controls.Add(this.btnCustomerAddEdit);
            this.pnlCustomerView.Controls.Add(this.pnlSearch);
            this.pnlCustomerView.Location = new System.Drawing.Point(11, 297);
            this.pnlCustomerView.Name = "pnlCustomerView";
            this.pnlCustomerView.Size = new System.Drawing.Size(1535, 478);
            this.pnlCustomerView.TabIndex = 74;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(18, 95);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(5, 5, 20, 20);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.DividerHeight = 1;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1497, 363);
            this.dgvCustomers.TabIndex = 74;
            this.dgvCustomers.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvCustomers_Paint);
            // 
            // btnCustomerAddEdit
            // 
            this.btnCustomerAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAddEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAddEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCustomerAddEdit.Image = global::CarRentalSystem.Properties.Resources.AddIcon;
            this.btnCustomerAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerAddEdit.Location = new System.Drawing.Point(1289, 20);
            this.btnCustomerAddEdit.Margin = new System.Windows.Forms.Padding(5, 20, 20, 5);
            this.btnCustomerAddEdit.Name = "btnCustomerAddEdit";
            this.btnCustomerAddEdit.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCustomerAddEdit.Size = new System.Drawing.Size(226, 60);
            this.btnCustomerAddEdit.TabIndex = 72;
            this.btnCustomerAddEdit.Text = "Add Customer";
            this.btnCustomerAddEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerAddEdit.UseVisualStyleBackColor = true;
            this.btnCustomerAddEdit.Click += new System.EventHandler(this.btnCustomerAddEdit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.IconSearch2;
            this.pictureBox4.Location = new System.Drawing.Point(14, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::CarRentalSystem.Properties.Resources.SampleDriver_s_License;
            this.picCustomer.Location = new System.Drawing.Point(10, 10);
            this.picCustomer.Margin = new System.Windows.Forms.Padding(10);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(383, 248);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 65;
            this.picCustomer.TabStop = false;
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlCustomerView);
            this.Controls.Add(this.pnlCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerManagement";
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlCustomerView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCustomerAddEdit;
        private System.Windows.Forms.Panel pnlCustomerView;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.PictureBox picCustomer;
    }
}