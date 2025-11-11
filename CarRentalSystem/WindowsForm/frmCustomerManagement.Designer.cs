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
            this.lblDriversLicense = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlCustomerSnapshot = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerAddEdit = new System.Windows.Forms.Button();
            this.pnlCustomerView = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.pnlCustomerSnapshot.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlCustomerView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCustomerDetails.Controls.Add(this.lblAddress);
            this.pnlCustomerDetails.Controls.Add(this.lblGender);
            this.pnlCustomerDetails.Controls.Add(this.label10);
            this.pnlCustomerDetails.Controls.Add(this.lblDriversLicense);
            this.pnlCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.pnlCustomerDetails.Controls.Add(this.label30);
            this.pnlCustomerDetails.Controls.Add(this.label6);
            this.pnlCustomerDetails.Controls.Add(this.label8);
            this.pnlCustomerDetails.Controls.Add(this.lblCustomerID);
            this.pnlCustomerDetails.Controls.Add(this.label3);
            this.pnlCustomerDetails.Controls.Add(this.picCustomer);
            this.pnlCustomerDetails.Controls.Add(this.label33);
            this.pnlCustomerDetails.Controls.Add(this.lblFullName);
            this.pnlCustomerDetails.Location = new System.Drawing.Point(11, 11);
            this.pnlCustomerDetails.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(1244, 268);
            this.pnlCustomerDetails.TabIndex = 53;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAddress.Location = new System.Drawing.Point(778, 218);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(224, 23);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "123 Main St, Davao City";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGender.Location = new System.Drawing.Point(265, 218);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 23);
            this.lblGender.TabIndex = 64;
            this.lblGender.Text = "Male";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(777, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Address:";
            // 
            // lblDriversLicense
            // 
            this.lblDriversLicense.AutoSize = true;
            this.lblDriversLicense.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDriversLicense.Location = new System.Drawing.Point(778, 142);
            this.lblDriversLicense.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblDriversLicense.Name = "lblDriversLicense";
            this.lblDriversLicense.Size = new System.Drawing.Size(147, 23);
            this.lblDriversLicense.TabIndex = 64;
            this.lblDriversLicense.Text = "N02-12-345678";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(778, 65);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(159, 23);
            this.lblPhoneNumber.TabIndex = 58;
            this.lblPhoneNumber.Text = "0917-XXX-XXXX";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label30.Location = new System.Drawing.Point(264, 178);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 25);
            this.label30.TabIndex = 63;
            this.label30.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(777, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(777, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Driver\'s License No:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerID.Location = new System.Drawing.Point(265, 66);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(21, 23);
            this.lblCustomerID.TabIndex = 62;
            this.lblCustomerID.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(264, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Customer ID:";
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::CarRentalSystem.Properties.Resources.user_image_mockup;
            this.picCustomer.Location = new System.Drawing.Point(37, 33);
            this.picCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(197, 197);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomer.TabIndex = 6;
            this.picCustomer.TabStop = false;
            this.picCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.picCustomer_Paint);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label33.Location = new System.Drawing.Point(264, 103);
            this.label33.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 25);
            this.label33.TabIndex = 53;
            this.label33.Text = "Full Name:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFullName.Location = new System.Drawing.Point(265, 143);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(93, 23);
            this.lblFullName.TabIndex = 55;
            this.lblFullName.Text = "John Doe";
            // 
            // pnlCustomerSnapshot
            // 
            this.pnlCustomerSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerSnapshot.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCustomerSnapshot.Controls.Add(this.label11);
            this.pnlCustomerSnapshot.Controls.Add(this.label14);
            this.pnlCustomerSnapshot.Controls.Add(this.label2);
            this.pnlCustomerSnapshot.Controls.Add(this.label13);
            this.pnlCustomerSnapshot.Controls.Add(this.label12);
            this.pnlCustomerSnapshot.Location = new System.Drawing.Point(1272, 11);
            this.pnlCustomerSnapshot.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.pnlCustomerSnapshot.Name = "pnlCustomerSnapshot";
            this.pnlCustomerSnapshot.Size = new System.Drawing.Size(274, 268);
            this.pnlCustomerSnapshot.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(241, 29);
            this.label11.TabIndex = 54;
            this.label11.Text = "Customer Snapshot";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(23, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 67;
            this.label14.Text = "Total Rentals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(23, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(23, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 25);
            this.label13.TabIndex = 65;
            this.label13.Text = "Total Revenue:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.Location = new System.Drawing.Point(23, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 23);
            this.label12.TabIndex = 68;
            this.label12.Text = "0";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pictureBox4);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(11, 299);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(679, 60);
            this.pnlSearch.TabIndex = 71;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.SearchIcon;
            this.pictureBox4.Location = new System.Drawing.Point(13, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(68, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(594, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCustomerAddEdit
            // 
            this.btnCustomerAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAddEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCustomerAddEdit.Location = new System.Drawing.Point(1272, 290);
            this.btnCustomerAddEdit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.btnCustomerAddEdit.Name = "btnCustomerAddEdit";
            this.btnCustomerAddEdit.Size = new System.Drawing.Size(274, 54);
            this.btnCustomerAddEdit.TabIndex = 72;
            this.btnCustomerAddEdit.Text = "Add Customer";
            this.btnCustomerAddEdit.UseVisualStyleBackColor = true;
            this.btnCustomerAddEdit.Click += new System.EventHandler(this.btnCustomerAddEdit_Click);
            // 
            // pnlCustomerView
            // 
            this.pnlCustomerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerView.Controls.Add(this.dgvCustomers);
            this.pnlCustomerView.Location = new System.Drawing.Point(11, 377);
            this.pnlCustomerView.Name = "pnlCustomerView";
            this.pnlCustomerView.Size = new System.Drawing.Size(1535, 335);
            this.pnlCustomerView.TabIndex = 74;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(5, 5);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(5);
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
            this.dgvCustomers.Size = new System.Drawing.Size(1525, 328);
            this.dgvCustomers.TabIndex = 74;
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 724);
            this.Controls.Add(this.pnlCustomerView);
            this.Controls.Add(this.btnCustomerAddEdit);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlCustomerSnapshot);
            this.Controls.Add(this.pnlCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerManagement";
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.pnlCustomerSnapshot.ResumeLayout(false);
            this.pnlCustomerSnapshot.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlCustomerView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDriversLicense;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlCustomerSnapshot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCustomerAddEdit;
        private System.Windows.Forms.Panel pnlCustomerView;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}