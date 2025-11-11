namespace CarRentalSystem.WindowsForm.Modal
{
    partial class modal_AddEditCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarImage = new System.Windows.Forms.Button();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.btnAddCarParts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRentalPlan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReplacementValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSeats = new System.Windows.Forms.ComboBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.cbxFuelType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTransmission = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.picCar);
            this.panel1.Controls.Add(this.btnCarImage);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 442);
            this.panel1.TabIndex = 0;
            // 
            // btnCarImage
            // 
            this.btnCarImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarImage.BackColor = System.Drawing.Color.White;
            this.btnCarImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCarImage.Location = new System.Drawing.Point(18, 363);
            this.btnCarImage.Margin = new System.Windows.Forms.Padding(27, 22, 27, 22);
            this.btnCarImage.Name = "btnCarImage";
            this.btnCarImage.Size = new System.Drawing.Size(418, 54);
            this.btnCarImage.TabIndex = 31;
            this.btnCarImage.Text = "Replace Image";
            this.btnCarImage.UseVisualStyleBackColor = false;
            this.btnCarImage.Click += new System.EventHandler(this.btnCarImage_Click);
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarParts.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCarParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarParts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCarParts.EnableHeadersVisualStyles = false;
            this.dgvCarParts.Location = new System.Drawing.Point(18, 66);
            this.dgvCarParts.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCarParts.MultiSelect = false;
            this.dgvCarParts.Name = "dgvCarParts";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCarParts.RowHeadersVisible = false;
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.RowTemplate.DividerHeight = 1;
            this.dgvCarParts.RowTemplate.Height = 40;
            this.dgvCarParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCarParts.Size = new System.Drawing.Size(1369, 234);
            this.dgvCarParts.TabIndex = 75;
            this.dgvCarParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarParts_CellContentClick);
            // 
            // btnAddCarParts
            // 
            this.btnAddCarParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCarParts.BackColor = System.Drawing.Color.White;
            this.btnAddCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarParts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnAddCarParts.Location = new System.Drawing.Point(18, 315);
            this.btnAddCarParts.Margin = new System.Windows.Forms.Padding(27, 22, 27, 22);
            this.btnAddCarParts.Name = "btnAddCarParts";
            this.btnAddCarParts.Size = new System.Drawing.Size(228, 49);
            this.btnAddCarParts.TabIndex = 76;
            this.btnAddCarParts.Text = "Add Car Parts";
            this.btnAddCarParts.UseVisualStyleBackColor = false;
            this.btnAddCarParts.Click += new System.EventHandler(this.btnAddCarParts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtEngineType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbxStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbxRentalPlan);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtReplacementValue);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbxSeats);
            this.panel2.Controls.Add(this.txtVIN);
            this.panel2.Controls.Add(this.cbxFuelType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbxTransmission);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPlateNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtModel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxBrand);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(489, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 442);
            this.panel2.TabIndex = 1;
            // 
            // txtEngineType
            // 
            this.txtEngineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineType.Location = new System.Drawing.Point(595, 383);
            this.txtEngineType.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(331, 34);
            this.txtEngineType.TabIndex = 99;
            this.txtEngineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 390);
            this.label10.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 98;
            this.label10.Text = "Engine Type:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Maintenance",
            "Lost"});
            this.cbxStatus.Location = new System.Drawing.Point(164, 383);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(255, 36);
            this.cbxStatus.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "Status:";
            // 
            // cbxRentalPlan
            // 
            this.cbxRentalPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRentalPlan.FormattingEnabled = true;
            this.cbxRentalPlan.Location = new System.Drawing.Point(595, 321);
            this.cbxRentalPlan.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxRentalPlan.Name = "cbxRentalPlan";
            this.cbxRentalPlan.Size = new System.Drawing.Size(331, 36);
            this.cbxRentalPlan.TabIndex = 95;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(459, 327);
            this.label17.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 24);
            this.label17.TabIndex = 94;
            this.label17.Text = "Rental Plan:";
            // 
            // txtReplacementValue
            // 
            this.txtReplacementValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReplacementValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplacementValue.Location = new System.Drawing.Point(164, 320);
            this.txtReplacementValue.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtReplacementValue.Name = "txtReplacementValue";
            this.txtReplacementValue.Size = new System.Drawing.Size(255, 34);
            this.txtReplacementValue.TabIndex = 92;
            this.txtReplacementValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 316);
            this.label14.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 48);
            this.label14.TabIndex = 91;
            this.label14.Text = "Replacement \r\nValue:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 90;
            this.label8.Text = "Seats:";
            // 
            // cbxSeats
            // 
            this.cbxSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeats.FormattingEnabled = true;
            this.cbxSeats.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.cbxSeats.Location = new System.Drawing.Point(164, 253);
            this.cbxSeats.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxSeats.Name = "cbxSeats";
            this.cbxSeats.Size = new System.Drawing.Size(255, 36);
            this.cbxSeats.TabIndex = 89;
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIN.Location = new System.Drawing.Point(164, 193);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(255, 34);
            this.txtVIN.TabIndex = 88;
            this.txtVIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxFuelType
            // 
            this.cbxFuelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFuelType.FormattingEnabled = true;
            this.cbxFuelType.Location = new System.Drawing.Point(595, 257);
            this.cbxFuelType.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxFuelType.Name = "cbxFuelType";
            this.cbxFuelType.Size = new System.Drawing.Size(331, 36);
            this.cbxFuelType.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 86;
            this.label7.Text = "Fuel Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 85;
            this.label6.Text = "Transmission:";
            // 
            // cbxTransmission
            // 
            this.cbxTransmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTransmission.FormattingEnabled = true;
            this.cbxTransmission.Location = new System.Drawing.Point(595, 192);
            this.cbxTransmission.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(331, 36);
            this.cbxTransmission.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "VIN (Unique):";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNumber.Location = new System.Drawing.Point(595, 132);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(331, 34);
            this.txtPlateNumber.TabIndex = 82;
            this.txtPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 81;
            this.label4.Text = "Plate Number:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(164, 132);
            this.txtYear.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(252, 34);
            this.txtYear.TabIndex = 80;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 79;
            this.label3.Text = "Year:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(595, 72);
            this.txtModel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(331, 34);
            this.txtModel.TabIndex = 77;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Model:";
            // 
            // cbxBrand
            // 
            this.cbxBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Items.AddRange(new object[] {
            "Toyota",
            "Porsche",
            "Honda"});
            this.cbxBrand.Location = new System.Drawing.Point(164, 72);
            this.cbxBrand.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(252, 36);
            this.cbxBrand.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 24);
            this.label13.TabIndex = 76;
            this.label13.Text = "Brand:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(939, 46);
            this.panel6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(387, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(178, 27);
            this.label11.TabIndex = 55;
            this.label11.Text = "Vehicle Details";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.dgvCarParts);
            this.panel3.Controls.Add(this.btnAddCarParts);
            this.panel3.Location = new System.Drawing.Point(15, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1413, 376);
            this.panel3.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1413, 46);
            this.panel4.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Car Parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.Location = new System.Drawing.Point(1010, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 49);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1179, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 49);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "SAVE VEHICLE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picCar
            // 
            this.picCar.Image = global::CarRentalSystem.Properties.Resources.CarSamplePic;
            this.picCar.Location = new System.Drawing.Point(18, 17);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(418, 276);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // modal_AddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 872);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modal_AddEditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modal_AddEditCar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarImage;
        private System.Windows.Forms.Button btnAddCarParts;
        private System.Windows.Forms.DataGridView dgvCarParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSeats;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.ComboBox cbxFuelType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTransmission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReplacementValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxRentalPlan;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.PictureBox picCar;
    }
}