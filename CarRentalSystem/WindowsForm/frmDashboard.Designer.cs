namespace CarRentalSystem.WindowsForm
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSystemLog = new System.Windows.Forms.Button();
            this.btnRentalPlans = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBillingLogs = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnFleet = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainDashboard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSystemLog);
            this.panel1.Controls.Add(this.btnRentalPlans);
            this.panel1.Controls.Add(this.btnEmployeeManagement);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnBillingLogs);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnFleet);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = global::CarRentalSystem.Properties.Resources.Icon___Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(13, 711);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(239, 44);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSystemLog
            // 
            this.btnSystemLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnSystemLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSystemLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSystemLog.Location = new System.Drawing.Point(13, 574);
            this.btnSystemLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSystemLog.Name = "btnSystemLog";
            this.btnSystemLog.Size = new System.Drawing.Size(241, 44);
            this.btnSystemLog.TabIndex = 33;
            this.btnSystemLog.Text = "System Log";
            this.btnSystemLog.UseVisualStyleBackColor = false;
            this.btnSystemLog.Click += new System.EventHandler(this.btnSystemLog_Click);
            // 
            // btnRentalPlans
            // 
            this.btnRentalPlans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentalPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnRentalPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRentalPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalPlans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnRentalPlans.Location = new System.Drawing.Point(13, 509);
            this.btnRentalPlans.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentalPlans.Name = "btnRentalPlans";
            this.btnRentalPlans.Size = new System.Drawing.Size(241, 44);
            this.btnRentalPlans.TabIndex = 32;
            this.btnRentalPlans.Text = "Rental Plans";
            this.btnRentalPlans.UseVisualStyleBackColor = false;
            this.btnRentalPlans.Click += new System.EventHandler(this.btnRentalPlans_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnEmployeeManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEmployeeManagement.Location = new System.Drawing.Point(13, 446);
            this.btnEmployeeManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(241, 44);
            this.btnEmployeeManagement.TabIndex = 31;
            this.btnEmployeeManagement.Text = "Employees";
            this.btnEmployeeManagement.UseVisualStyleBackColor = false;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(13, 413);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 1);
            this.panel3.TabIndex = 26;
            // 
            // btnBillingLogs
            // 
            this.btnBillingLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillingLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnBillingLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBillingLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnBillingLogs.Location = new System.Drawing.Point(13, 343);
            this.btnBillingLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnBillingLogs.Name = "btnBillingLogs";
            this.btnBillingLogs.Size = new System.Drawing.Size(241, 44);
            this.btnBillingLogs.TabIndex = 29;
            this.btnBillingLogs.Text = "Report";
            this.btnBillingLogs.UseVisualStyleBackColor = false;
            this.btnBillingLogs.Click += new System.EventHandler(this.btnBillingLogs_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCustomer.Location = new System.Drawing.Point(13, 281);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(241, 44);
            this.btnCustomer.TabIndex = 28;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnFleet
            // 
            this.btnFleet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFleet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnFleet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFleet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnFleet.Location = new System.Drawing.Point(13, 216);
            this.btnFleet.Margin = new System.Windows.Forms.Padding(4);
            this.btnFleet.Name = "btnFleet";
            this.btnFleet.Size = new System.Drawing.Size(241, 44);
            this.btnFleet.TabIndex = 27;
            this.btnFleet.Text = "Fleet";
            this.btnFleet.UseVisualStyleBackColor = false;
            this.btnFleet.Click += new System.EventHandler(this.btnFleet_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTransactions.Location = new System.Drawing.Point(13, 154);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(241, 44);
            this.btnTransactions.TabIndex = 26;
            this.btnTransactions.Text = "Contracts";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(245)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDashboard.Location = new System.Drawing.Point(13, 90);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(241, 44);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CarRentalSystem.Properties.Resources.Car_Logo_24x24;
            this.pictureBox1.Location = new System.Drawing.Point(42, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMainDashboard
            // 
            this.pnlMainDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainDashboard.BackColor = System.Drawing.Color.White;
            this.pnlMainDashboard.Location = new System.Drawing.Point(270, 0);
            this.pnlMainDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMainDashboard.Name = "pnlMainDashboard";
            this.pnlMainDashboard.Size = new System.Drawing.Size(1095, 768);
            this.pnlMainDashboard.TabIndex = 52;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlMainDashboard);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnFleet;
        public System.Windows.Forms.Panel pnlMainDashboard;
        private System.Windows.Forms.Button btnBillingLogs;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSystemLog;
        private System.Windows.Forms.Button btnRentalPlans;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}