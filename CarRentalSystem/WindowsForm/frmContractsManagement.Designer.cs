namespace CarRentalSystem.WindowsForm
{
    partial class frmContractsManagement
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
            this.pnlContractDetails = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDaysRented = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblStarDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblRentalPlanName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessReturn = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlComboBox = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pnlContractsOverview = new System.Windows.Forms.Panel();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.pnlContractDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlComboBox.SuspendLayout();
            this.pnlContractsOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContractDetails
            // 
            this.pnlContractDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContractDetails.BackColor = System.Drawing.Color.White;
            this.pnlContractDetails.Controls.Add(this.btnPayment);
            this.pnlContractDetails.Controls.Add(this.lblStatus);
            this.pnlContractDetails.Controls.Add(this.lblDaysRented);
            this.pnlContractDetails.Controls.Add(this.lblReturnDate);
            this.pnlContractDetails.Controls.Add(this.lblStarDate);
            this.pnlContractDetails.Controls.Add(this.label7);
            this.pnlContractDetails.Controls.Add(this.label6);
            this.pnlContractDetails.Controls.Add(this.label5);
            this.pnlContractDetails.Controls.Add(this.label4);
            this.pnlContractDetails.Controls.Add(this.lblCar);
            this.pnlContractDetails.Controls.Add(this.lblRentalPlanName);
            this.pnlContractDetails.Controls.Add(this.label3);
            this.pnlContractDetails.Controls.Add(this.label2);
            this.pnlContractDetails.Controls.Add(this.label1);
            this.pnlContractDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlContractDetails.Name = "pnlContractDetails";
            this.pnlContractDetails.Size = new System.Drawing.Size(1535, 268);
            this.pnlContractDetails.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnPayment.Location = new System.Drawing.Point(1337, 10);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(5, 0, 10, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(188, 60);
            this.btnPayment.TabIndex = 74;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(961, 195);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 28);
            this.lblStatus.TabIndex = 73;
            this.lblStatus.Text = "[Status]";
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRented.Location = new System.Drawing.Point(545, 195);
            this.lblDaysRented.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(139, 28);
            this.lblDaysRented.TabIndex = 72;
            this.lblDaysRented.Text = "[Days Rented]";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(961, 109);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(134, 28);
            this.lblReturnDate.TabIndex = 71;
            this.lblReturnDate.Text = "[Return Date]";
            // 
            // lblStarDate
            // 
            this.lblStarDate.AutoSize = true;
            this.lblStarDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarDate.Location = new System.Drawing.Point(545, 109);
            this.lblStarDate.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblStarDate.Name = "lblStarDate";
            this.lblStarDate.Size = new System.Drawing.Size(116, 28);
            this.lblStarDate.TabIndex = 70;
            this.lblStarDate.Text = "[Start Date]";
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
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Days Rented: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(545, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Start Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(961, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Return Date: ";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(20, 191);
            this.lblCar.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(55, 28);
            this.lblCar.TabIndex = 65;
            this.lblCar.Text = "[Car]";
            // 
            // lblRentalPlanName
            // 
            this.lblRentalPlanName.AutoSize = true;
            this.lblRentalPlanName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPlanName.Location = new System.Drawing.Point(20, 109);
            this.lblRentalPlanName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.lblRentalPlanName.Name = "lblRentalPlanName";
            this.lblRentalPlanName.Size = new System.Drawing.Size(127, 28);
            this.lblRentalPlanName.TabIndex = 64;
            this.lblRentalPlanName.Text = "[Rental Plan]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Car:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "Rental Plan: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 61;
            this.label1.Text = "Customer Name";
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnProcessReturn.Location = new System.Drawing.Point(1041, 20);
            this.btnProcessReturn.Margin = new System.Windows.Forms.Padding(5, 20, 10, 10);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(226, 60);
            this.btnProcessReturn.TabIndex = 60;
            this.btnProcessReturn.Text = "Process Return";
            this.btnProcessReturn.UseVisualStyleBackColor = true;
            this.btnProcessReturn.Click += new System.EventHandler(this.btnProcessReturn_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnNewRental.Location = new System.Drawing.Point(1289, 20);
            this.btnNewRental.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(226, 60);
            this.btnNewRental.TabIndex = 59;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = true;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
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
            // pnlComboBox
            // 
            this.pnlComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlComboBox.Controls.Add(this.cbxStatus);
            this.pnlComboBox.Location = new System.Drawing.Point(540, 20);
            this.pnlComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlComboBox.Name = "pnlComboBox";
            this.pnlComboBox.Size = new System.Drawing.Size(273, 60);
            this.pnlComboBox.TabIndex = 73;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(10, 13);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(10);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(253, 36);
            this.cbxStatus.TabIndex = 57;
            // 
            // pnlContractsOverview
            // 
            this.pnlContractsOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContractsOverview.BackColor = System.Drawing.Color.White;
            this.pnlContractsOverview.Controls.Add(this.dgvContracts);
            this.pnlContractsOverview.Controls.Add(this.btnNewRental);
            this.pnlContractsOverview.Controls.Add(this.btnProcessReturn);
            this.pnlContractsOverview.Controls.Add(this.pnlSearch);
            this.pnlContractsOverview.Controls.Add(this.pnlComboBox);
            this.pnlContractsOverview.Location = new System.Drawing.Point(12, 299);
            this.pnlContractsOverview.Name = "pnlContractsOverview";
            this.pnlContractsOverview.Size = new System.Drawing.Size(1535, 478);
            this.pnlContractsOverview.TabIndex = 74;
            // 
            // dgvContracts
            // 
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContracts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContracts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.EnableHeadersVisualStyles = false;
            this.dgvContracts.Location = new System.Drawing.Point(18, 101);
            this.dgvContracts.Margin = new System.Windows.Forms.Padding(5, 0, 20, 20);
            this.dgvContracts.MultiSelect = false;
            this.dgvContracts.Name = "dgvContracts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContracts.RowHeadersVisible = false;
            this.dgvContracts.RowHeadersWidth = 51;
            this.dgvContracts.RowTemplate.DividerHeight = 1;
            this.dgvContracts.RowTemplate.Height = 40;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvContracts.Size = new System.Drawing.Size(1497, 360);
            this.dgvContracts.TabIndex = 75;
            this.dgvContracts.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvContracts_Paint);
            // 
            // frmContractsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlContractsOverview);
            this.Controls.Add(this.pnlContractDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContractsManagement";
            this.Text = "frmContractsManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContractDetails.ResumeLayout(false);
            this.pnlContractDetails.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlComboBox.ResumeLayout(false);
            this.pnlContractsOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContractDetails;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblRentalPlanName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaysRented;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblStarDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlComboBox;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel pnlContractsOverview;
        private System.Windows.Forms.DataGridView dgvContracts;
    }
}