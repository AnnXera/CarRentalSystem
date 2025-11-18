namespace CarRentalSystem.WindowsForm.Modal
{
    partial class modal_SelectRentalAndCar
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
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblRentalPlan = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAvailableCar = new System.Windows.Forms.Panel();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlTransmission = new System.Windows.Forms.Panel();
            this.cbxTransmission = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.cbxSeats = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRentalPlan = new System.Windows.Forms.Panel();
            this.cbxRentalPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.pnlAvailableCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlTransmission.SuspendLayout();
            this.pnlSeats.SuspendLayout();
            this.pnlRentalPlan.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.Color.DimGray;
            this.lblSeats.Location = new System.Drawing.Point(296, 157);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(65, 28);
            this.lblSeats.TabIndex = 85;
            this.lblSeats.Text = "Seats:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.ForeColor = System.Drawing.Color.DimGray;
            this.lblTransmission.Location = new System.Drawing.Point(296, 114);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(134, 28);
            this.lblTransmission.TabIndex = 84;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblRentalPlan
            // 
            this.lblRentalPlan.AutoSize = true;
            this.lblRentalPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPlan.ForeColor = System.Drawing.Color.DimGray;
            this.lblRentalPlan.Location = new System.Drawing.Point(296, 71);
            this.lblRentalPlan.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.lblRentalPlan.Name = "lblRentalPlan";
            this.lblRentalPlan.Size = new System.Drawing.Size(124, 28);
            this.lblRentalPlan.TabIndex = 83;
            this.lblRentalPlan.Text = "Rental Plan: ";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(294, 16);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(156, 41);
            this.lblCarName.TabIndex = 82;
            this.lblCarName.Text = "Car Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 81;
            this.label5.Text = "Car Brand:";
            // 
            // pnlAvailableCar
            // 
            this.pnlAvailableCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAvailableCar.BackColor = System.Drawing.Color.White;
            this.pnlAvailableCar.Controls.Add(this.dgvCars);
            this.pnlAvailableCar.Controls.Add(this.lblSeats);
            this.pnlAvailableCar.Controls.Add(this.label4);
            this.pnlAvailableCar.Controls.Add(this.lblTransmission);
            this.pnlAvailableCar.Controls.Add(this.btnSave);
            this.pnlAvailableCar.Controls.Add(this.btnCancel);
            this.pnlAvailableCar.Controls.Add(this.lblRentalPlan);
            this.pnlAvailableCar.Controls.Add(this.picCar);
            this.pnlAvailableCar.Controls.Add(this.lblCarName);
            this.pnlAvailableCar.Location = new System.Drawing.Point(13, 264);
            this.pnlAvailableCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pnlAvailableCar.Name = "pnlAvailableCar";
            this.pnlAvailableCar.Size = new System.Drawing.Size(1103, 899);
            this.pnlAvailableCar.TabIndex = 80;
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.Location = new System.Drawing.Point(16, 226);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.DividerHeight = 1;
            this.dgvCars.RowTemplate.Height = 40;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCars.Size = new System.Drawing.Size(1071, 594);
            this.dgvCars.TabIndex = 75;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            this.dgvCars.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvCars_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Available Cars";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(940, 843);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 38);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SELECT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.Location = new System.Drawing.Point(780, 843);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 38);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picCar
            // 
            this.picCar.Image = global::CarRentalSystem.Properties.Resources.CarSamplePic;
            this.picCar.Location = new System.Drawing.Point(16, 12);
            this.picCar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(262, 171);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 78;
            this.picCar.TabStop = false;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.Black;
            this.btnClearFilter.Location = new System.Drawing.Point(946, 158);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(20, 18, 15, 15);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(141, 55);
            this.btnClearFilter.TabIndex = 79;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlSearch.Controls.Add(this.pictureBox4);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(15, 52);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(15, 4, 15, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1072, 55);
            this.pnlSearch.TabIndex = 77;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.IconSearch2;
            this.pictureBox4.Location = new System.Drawing.Point(13, 14);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
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
            this.txtSearch.Location = new System.Drawing.Point(59, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1000, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // pnlTransmission
            // 
            this.pnlTransmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlTransmission.Controls.Add(this.cbxTransmission);
            this.pnlTransmission.Location = new System.Drawing.Point(341, 165);
            this.pnlTransmission.Margin = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.pnlTransmission.Name = "pnlTransmission";
            this.pnlTransmission.Size = new System.Drawing.Size(250, 55);
            this.pnlTransmission.TabIndex = 76;
            // 
            // cbxTransmission
            // 
            this.cbxTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTransmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxTransmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTransmission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTransmission.FormattingEnabled = true;
            this.cbxTransmission.Location = new System.Drawing.Point(13, 12);
            this.cbxTransmission.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(224, 31);
            this.cbxTransmission.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 75;
            this.label3.Text = "Transmission:";
            // 
            // pnlSeats
            // 
            this.pnlSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlSeats.Controls.Add(this.cbxSeats);
            this.pnlSeats.Location = new System.Drawing.Point(606, 165);
            this.pnlSeats.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(136, 55);
            this.pnlSeats.TabIndex = 74;
            // 
            // cbxSeats
            // 
            this.cbxSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxSeats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSeats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeats.FormattingEnabled = true;
            this.cbxSeats.Location = new System.Drawing.Point(13, 12);
            this.cbxSeats.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxSeats.Name = "cbxSeats";
            this.cbxSeats.Size = new System.Drawing.Size(110, 31);
            this.cbxSeats.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 73;
            this.label2.Text = "Seats:";
            // 
            // pnlRentalPlan
            // 
            this.pnlRentalPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlRentalPlan.Controls.Add(this.cbxRentalPlan);
            this.pnlRentalPlan.Location = new System.Drawing.Point(15, 165);
            this.pnlRentalPlan.Margin = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.pnlRentalPlan.Name = "pnlRentalPlan";
            this.pnlRentalPlan.Size = new System.Drawing.Size(311, 55);
            this.pnlRentalPlan.TabIndex = 72;
            // 
            // cbxRentalPlan
            // 
            this.cbxRentalPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRentalPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxRentalPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRentalPlan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRentalPlan.FormattingEnabled = true;
            this.cbxRentalPlan.Location = new System.Drawing.Point(17, 12);
            this.cbxRentalPlan.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxRentalPlan.Name = "cbxRentalPlan";
            this.cbxRentalPlan.Size = new System.Drawing.Size(276, 31);
            this.cbxRentalPlan.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 20, 4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "Rental Plan:";
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchBox.BackColor = System.Drawing.Color.White;
            this.pnlSearchBox.Controls.Add(this.label5);
            this.pnlSearchBox.Controls.Add(this.pnlSearch);
            this.pnlSearchBox.Controls.Add(this.label1);
            this.pnlSearchBox.Controls.Add(this.pnlRentalPlan);
            this.pnlSearchBox.Controls.Add(this.btnClearFilter);
            this.pnlSearchBox.Controls.Add(this.pnlTransmission);
            this.pnlSearchBox.Controls.Add(this.label2);
            this.pnlSearchBox.Controls.Add(this.label3);
            this.pnlSearchBox.Controls.Add(this.pnlSeats);
            this.pnlSearchBox.Location = new System.Drawing.Point(14, 14);
            this.pnlSearchBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(1102, 235);
            this.pnlSearchBox.TabIndex = 86;
            // 
            // modal_SelectRentalAndCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 15);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1152, 1052);
            this.Controls.Add(this.pnlSearchBox);
            this.Controls.Add(this.pnlAvailableCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modal_SelectRentalAndCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modal_SelectRentalAndCar";
            this.pnlAvailableCar.ResumeLayout(false);
            this.pnlAvailableCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlTransmission.ResumeLayout(false);
            this.pnlSeats.ResumeLayout(false);
            this.pnlRentalPlan.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAvailableCar;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlTransmission;
        private System.Windows.Forms.ComboBox cbxTransmission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.ComboBox cbxSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRentalPlan;
        private System.Windows.Forms.ComboBox cbxRentalPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblRentalPlan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Panel pnlSearchBox;
    }
}