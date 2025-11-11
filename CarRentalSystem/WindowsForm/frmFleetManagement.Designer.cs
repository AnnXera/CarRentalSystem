namespace CarRentalSystem.WindowsForm
{
    partial class frmFleetManagement
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlComboBox = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.pnlRentalPlan = new System.Windows.Forms.Panel();
            this.cbxRentalPlan = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.pnlRentalPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.picCar);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(22, 21);
            this.panel5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1528, 160);
            this.panel5.TabIndex = 53;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // picCar
            // 
            this.picCar.Image = global::CarRentalSystem.Properties.Resources.CarSamplePic;
            this.picCar.Location = new System.Drawing.Point(13, 12);
            this.picCar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(208, 138);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 66;
            this.picCar.TabStop = false;
            this.picCar.Paint += new System.Windows.Forms.PaintEventHandler(this.picCar_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(238, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 24);
            this.label7.TabIndex = 64;
            this.label7.Text = "Status: All/Available/Rented/Maintenance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 35);
            this.label5.TabIndex = 58;
            this.label5.Text = "Car Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.txtSearch);
            this.panel7.Location = new System.Drawing.Point(22, 197);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(423, 55);
            this.panel7.TabIndex = 55;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.SearchIcon;
            this.pictureBox4.Location = new System.Drawing.Point(13, 11);
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
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(59, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // pnlComboBox
            // 
            this.pnlComboBox.Controls.Add(this.cbxStatus);
            this.pnlComboBox.Location = new System.Drawing.Point(475, 197);
            this.pnlComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnlComboBox.Name = "pnlComboBox";
            this.pnlComboBox.Size = new System.Drawing.Size(353, 55);
            this.pnlComboBox.TabIndex = 56;
            this.pnlComboBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlComboBox_Paint);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Rented",
            "Maintenance",
            "Lost"});
            this.cbxStatus.Location = new System.Drawing.Point(17, 12);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(318, 31);
            this.cbxStatus.TabIndex = 57;
            this.cbxStatus.Text = "All Status";
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.Location = new System.Drawing.Point(22, 274);
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
            this.dgvCars.Size = new System.Drawing.Size(1528, 423);
            this.dgvCars.TabIndex = 74;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnAddVehicle.Location = new System.Drawing.Point(1308, 208);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(242, 44);
            this.btnAddVehicle.TabIndex = 75;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // pnlRentalPlan
            // 
            this.pnlRentalPlan.Controls.Add(this.cbxRentalPlan);
            this.pnlRentalPlan.Location = new System.Drawing.Point(867, 197);
            this.pnlRentalPlan.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRentalPlan.Name = "pnlRentalPlan";
            this.pnlRentalPlan.Size = new System.Drawing.Size(353, 55);
            this.pnlRentalPlan.TabIndex = 76;
            this.pnlRentalPlan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRentalPlan_Paint);
            // 
            // cbxRentalPlan
            // 
            this.cbxRentalPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRentalPlan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRentalPlan.FormattingEnabled = true;
            this.cbxRentalPlan.Location = new System.Drawing.Point(17, 12);
            this.cbxRentalPlan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxRentalPlan.Name = "cbxRentalPlan";
            this.cbxRentalPlan.Size = new System.Drawing.Size(318, 31);
            this.cbxRentalPlan.TabIndex = 57;
            this.cbxRentalPlan.Text = "All Plans";
            // 
            // frmFleetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 724);
            this.Controls.Add(this.pnlRentalPlan);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.pnlComboBox);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFleetManagement";
            this.Text = "FleetManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFleetManagement_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlComboBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.pnlRentalPlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlComboBox;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Panel pnlRentalPlan;
        private System.Windows.Forms.ComboBox cbxRentalPlan;
    }
}