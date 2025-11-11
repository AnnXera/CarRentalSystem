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
            this.pnlContractDetails = new System.Windows.Forms.Panel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlComboBox = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pnlContractDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContractDetails
            // 
            this.pnlContractDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContractDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
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
            this.pnlContractDetails.Controls.Add(this.btnProcessReturn);
            this.pnlContractDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlContractDetails.Name = "pnlContractDetails";
            this.pnlContractDetails.Size = new System.Drawing.Size(1548, 230);
            this.pnlContractDetails.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(961, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 23);
            this.lblStatus.TabIndex = 73;
            this.lblStatus.Text = "[Status]";
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRented.Location = new System.Drawing.Point(575, 177);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(136, 23);
            this.lblDaysRented.TabIndex = 72;
            this.lblDaysRented.Text = "[Days Rented]";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(961, 107);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(128, 23);
            this.lblReturnDate.TabIndex = 71;
            this.lblReturnDate.Text = "[Return Date]";
            // 
            // lblStarDate
            // 
            this.lblStarDate.AutoSize = true;
            this.lblStarDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarDate.Location = new System.Drawing.Point(575, 107);
            this.lblStarDate.Name = "lblStarDate";
            this.lblStarDate.Size = new System.Drawing.Size(113, 23);
            this.lblStarDate.TabIndex = 70;
            this.lblStarDate.Text = "[Start Date]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(961, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Days Rented: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Start Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(961, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Return Date: ";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(23, 177);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(54, 23);
            this.lblCar.TabIndex = 65;
            this.lblCar.Text = "[Car]";
            // 
            // lblRentalPlanName
            // 
            this.lblRentalPlanName.AutoSize = true;
            this.lblRentalPlanName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPlanName.Location = new System.Drawing.Point(23, 107);
            this.lblRentalPlanName.Name = "lblRentalPlanName";
            this.lblRentalPlanName.Size = new System.Drawing.Size(122, 23);
            this.lblRentalPlanName.TabIndex = 64;
            this.lblRentalPlanName.Text = "[Rental Plan]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Car:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "Rental Plan: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 61;
            this.label1.Text = "Customer Name";
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnProcessReturn.Location = new System.Drawing.Point(1299, 17);
            this.btnProcessReturn.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(234, 53);
            this.btnProcessReturn.TabIndex = 60;
            this.btnProcessReturn.Text = "Process Return";
            this.btnProcessReturn.UseVisualStyleBackColor = true;
            // 
            // btnNewRental
            // 
            this.btnNewRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.btnNewRental.Location = new System.Drawing.Point(1341, 266);
            this.btnNewRental.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(219, 53);
            this.btnNewRental.TabIndex = 59;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = true;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(9, 7, 17, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1548, 365);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.txtSearch);
            this.panel7.Location = new System.Drawing.Point(12, 262);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(518, 55);
            this.panel7.TabIndex = 72;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.SearchIcon;
            this.pictureBox4.Location = new System.Drawing.Point(11, 9);
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
            this.txtSearch.Location = new System.Drawing.Point(64, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(437, 28);
            this.txtSearch.TabIndex = 1;
            // 
            // pnlComboBox
            // 
            this.pnlComboBox.Controls.Add(this.cbxStatus);
            this.pnlComboBox.Location = new System.Drawing.Point(562, 262);
            this.pnlComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnlComboBox.Name = "pnlComboBox";
            this.pnlComboBox.Size = new System.Drawing.Size(353, 55);
            this.pnlComboBox.TabIndex = 73;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(17, 12);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(318, 31);
            this.cbxStatus.TabIndex = 57;
            this.cbxStatus.Text = "All Status";
            // 
            // frmContractsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 724);
            this.Controls.Add(this.pnlComboBox);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewRental);
            this.Controls.Add(this.pnlContractDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContractsManagement";
            this.Text = "frmContractsManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContractDetails.ResumeLayout(false);
            this.pnlContractDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlComboBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContractDetails;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlComboBox;
        private System.Windows.Forms.ComboBox cbxStatus;
    }
}