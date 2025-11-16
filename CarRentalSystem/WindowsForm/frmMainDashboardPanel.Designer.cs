namespace CarRentalSystem.WindowsForm
{
    partial class frmMainDashboardPanel
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
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.pnlOverView = new System.Windows.Forms.Panel();
            this.pnlSearchActiveRentals = new System.Windows.Forms.Panel();
            this.txtSearchActiveRentals = new System.Windows.Forms.TextBox();
            this.dgvActiveRentals = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlVehiclesAvailable = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlRentalsDue = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlReturnsDueToday = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOverviewVehicles = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAdminOverview = new System.Windows.Forms.Panel();
            this.pnlAvgDailyRate = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlFleetUtilization = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnProcessContract = new System.Windows.Forms.Button();
            this.btnNewContract = new System.Windows.Forms.Button();
            this.pnlQuickActions.SuspendLayout();
            this.pnlOverView.SuspendLayout();
            this.pnlSearchActiveRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveRentals)).BeginInit();
            this.pnlVehiclesAvailable.SuspendLayout();
            this.pnlRentalsDue.SuspendLayout();
            this.pnlReturnsDueToday.SuspendLayout();
            this.pnlOverviewVehicles.SuspendLayout();
            this.pnlAdminOverview.SuspendLayout();
            this.pnlAvgDailyRate.SuspendLayout();
            this.pnlFleetUtilization.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.btnProcessContract);
            this.pnlQuickActions.Controls.Add(this.btnNewContract);
            this.pnlQuickActions.Controls.Add(this.label1);
            this.pnlQuickActions.Controls.Add(this.lblRole);
            this.pnlQuickActions.Controls.Add(this.lblUserName);
            this.pnlQuickActions.Location = new System.Drawing.Point(788, 20);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(737, 137);
            this.pnlQuickActions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quick Action";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(550, 59);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(50, 23);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(549, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 27);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Rental System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today Statistics";
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDate.Location = new System.Drawing.Point(15, 112);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(106, 23);
            this.lblTodayDate.TabIndex = 3;
            this.lblTodayDate.Text = "Date, Time";
            // 
            // pnlOverView
            // 
            this.pnlOverView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOverView.BackColor = System.Drawing.Color.White;
            this.pnlOverView.Controls.Add(this.pnlSearchActiveRentals);
            this.pnlOverView.Controls.Add(this.dgvActiveRentals);
            this.pnlOverView.Controls.Add(this.label13);
            this.pnlOverView.Location = new System.Drawing.Point(788, 187);
            this.pnlOverView.Name = "pnlOverView";
            this.pnlOverView.Size = new System.Drawing.Size(737, 841);
            this.pnlOverView.TabIndex = 4;
            // 
            // pnlSearchActiveRentals
            // 
            this.pnlSearchActiveRentals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchActiveRentals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearchActiveRentals.Controls.Add(this.pictureBox4);
            this.pnlSearchActiveRentals.Controls.Add(this.txtSearchActiveRentals);
            this.pnlSearchActiveRentals.Location = new System.Drawing.Point(20, 58);
            this.pnlSearchActiveRentals.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSearchActiveRentals.Name = "pnlSearchActiveRentals";
            this.pnlSearchActiveRentals.Size = new System.Drawing.Size(698, 55);
            this.pnlSearchActiveRentals.TabIndex = 76;
            // 
            // txtSearchActiveRentals
            // 
            this.txtSearchActiveRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchActiveRentals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchActiveRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchActiveRentals.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchActiveRentals.Location = new System.Drawing.Point(64, 13);
            this.txtSearchActiveRentals.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.txtSearchActiveRentals.Name = "txtSearchActiveRentals";
            this.txtSearchActiveRentals.Size = new System.Drawing.Size(617, 28);
            this.txtSearchActiveRentals.TabIndex = 1;
            // 
            // dgvActiveRentals
            // 
            this.dgvActiveRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActiveRentals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvActiveRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActiveRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActiveRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveRentals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveRentals.EnableHeadersVisualStyles = false;
            this.dgvActiveRentals.Location = new System.Drawing.Point(20, 132);
            this.dgvActiveRentals.Margin = new System.Windows.Forms.Padding(5);
            this.dgvActiveRentals.MultiSelect = false;
            this.dgvActiveRentals.Name = "dgvActiveRentals";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveRentals.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveRentals.RowHeadersVisible = false;
            this.dgvActiveRentals.RowHeadersWidth = 51;
            this.dgvActiveRentals.RowTemplate.DividerHeight = 1;
            this.dgvActiveRentals.RowTemplate.Height = 40;
            this.dgvActiveRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvActiveRentals.Size = new System.Drawing.Size(698, 690);
            this.dgvActiveRentals.TabIndex = 75;
            this.dgvActiveRentals.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvActiveRentals_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "Active Rentals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fleet and Rental Overview";
            // 
            // pnlVehiclesAvailable
            // 
            this.pnlVehiclesAvailable.BackColor = System.Drawing.Color.White;
            this.pnlVehiclesAvailable.Controls.Add(this.panel3);
            this.pnlVehiclesAvailable.Controls.Add(this.label5);
            this.pnlVehiclesAvailable.Location = new System.Drawing.Point(19, 219);
            this.pnlVehiclesAvailable.Name = "pnlVehiclesAvailable";
            this.pnlVehiclesAvailable.Size = new System.Drawing.Size(361, 167);
            this.pnlVehiclesAvailable.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.ForeColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(16, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 1);
            this.panel3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vehicles Available";
            // 
            // pnlRentalsDue
            // 
            this.pnlRentalsDue.BackColor = System.Drawing.Color.White;
            this.pnlRentalsDue.Controls.Add(this.panel4);
            this.pnlRentalsDue.Controls.Add(this.label6);
            this.pnlRentalsDue.Location = new System.Drawing.Point(404, 219);
            this.pnlRentalsDue.Name = "pnlRentalsDue";
            this.pnlRentalsDue.Size = new System.Drawing.Size(361, 167);
            this.pnlRentalsDue.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.ForeColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(16, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 1);
            this.panel4.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rentals Due Today";
            // 
            // pnlReturnsDueToday
            // 
            this.pnlReturnsDueToday.BackColor = System.Drawing.Color.White;
            this.pnlReturnsDueToday.Controls.Add(this.panel6);
            this.pnlReturnsDueToday.Controls.Add(this.label7);
            this.pnlReturnsDueToday.Location = new System.Drawing.Point(19, 409);
            this.pnlReturnsDueToday.Name = "pnlReturnsDueToday";
            this.pnlReturnsDueToday.Size = new System.Drawing.Size(361, 167);
            this.pnlReturnsDueToday.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.ForeColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(16, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 1);
            this.panel6.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Returns Due Today";
            // 
            // pnlOverviewVehicles
            // 
            this.pnlOverviewVehicles.BackColor = System.Drawing.Color.White;
            this.pnlOverviewVehicles.Controls.Add(this.panel8);
            this.pnlOverviewVehicles.Controls.Add(this.label8);
            this.pnlOverviewVehicles.Location = new System.Drawing.Point(404, 409);
            this.pnlOverviewVehicles.Name = "pnlOverviewVehicles";
            this.pnlOverviewVehicles.Size = new System.Drawing.Size(361, 167);
            this.pnlOverviewVehicles.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.ForeColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(16, 50);
            this.panel8.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 1);
            this.panel8.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Overdue Vehicles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Admin Overview";
            // 
            // pnlAdminOverview
            // 
            this.pnlAdminOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlAdminOverview.Controls.Add(this.pnlAvgDailyRate);
            this.pnlAdminOverview.Controls.Add(this.pnlFleetUtilization);
            this.pnlAdminOverview.Controls.Add(this.pnlRevenue);
            this.pnlAdminOverview.Controls.Add(this.label9);
            this.pnlAdminOverview.Location = new System.Drawing.Point(-1, 607);
            this.pnlAdminOverview.Name = "pnlAdminOverview";
            this.pnlAdminOverview.Size = new System.Drawing.Size(790, 437);
            this.pnlAdminOverview.TabIndex = 32;
            // 
            // pnlAvgDailyRate
            // 
            this.pnlAvgDailyRate.BackColor = System.Drawing.Color.White;
            this.pnlAvgDailyRate.Controls.Add(this.panel9);
            this.pnlAvgDailyRate.Controls.Add(this.label12);
            this.pnlAvgDailyRate.Location = new System.Drawing.Point(405, 254);
            this.pnlAvgDailyRate.Name = "pnlAvgDailyRate";
            this.pnlAvgDailyRate.Size = new System.Drawing.Size(361, 167);
            this.pnlAvgDailyRate.TabIndex = 32;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.ForeColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(16, 50);
            this.panel9.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(322, 1);
            this.panel9.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Avg Daily Rate";
            // 
            // pnlFleetUtilization
            // 
            this.pnlFleetUtilization.BackColor = System.Drawing.Color.White;
            this.pnlFleetUtilization.Controls.Add(this.panel7);
            this.pnlFleetUtilization.Controls.Add(this.label11);
            this.pnlFleetUtilization.Location = new System.Drawing.Point(20, 254);
            this.pnlFleetUtilization.Name = "pnlFleetUtilization";
            this.pnlFleetUtilization.Size = new System.Drawing.Size(361, 167);
            this.pnlFleetUtilization.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.ForeColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(16, 50);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(322, 1);
            this.panel7.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Fleet Utilization";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.panel2);
            this.pnlRevenue.Controls.Add(this.label10);
            this.pnlRevenue.Location = new System.Drawing.Point(20, 52);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(746, 182);
            this.pnlRevenue.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(16, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 1);
            this.panel2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Revenue(MTD)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Properties.Resources.IconSearch2;
            this.pictureBox4.Location = new System.Drawing.Point(11, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btnProcessContract
            // 
            this.btnProcessContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcessContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessContract.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnProcessContract.Image = global::CarRentalSystem.Properties.Resources.AddIcon;
            this.btnProcessContract.Location = new System.Drawing.Point(255, 67);
            this.btnProcessContract.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcessContract.Name = "btnProcessContract";
            this.btnProcessContract.Size = new System.Drawing.Size(226, 48);
            this.btnProcessContract.TabIndex = 74;
            this.btnProcessContract.Text = "Process Contract";
            this.btnProcessContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessContract.UseVisualStyleBackColor = true;
            this.btnProcessContract.Click += new System.EventHandler(this.btnProcessContract_Click);
            // 
            // btnNewContract
            // 
            this.btnNewContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewContract.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnNewContract.Image = global::CarRentalSystem.Properties.Resources.AddIcon;
            this.btnNewContract.Location = new System.Drawing.Point(20, 67);
            this.btnNewContract.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewContract.Name = "btnNewContract";
            this.btnNewContract.Size = new System.Drawing.Size(225, 48);
            this.btnNewContract.TabIndex = 73;
            this.btnNewContract.Text = "New Contract";
            this.btnNewContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewContract.UseVisualStyleBackColor = true;
            this.btnNewContract.Click += new System.EventHandler(this.btnNewContract_Click);
            // 
            // frmMainDashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1558, 724);
            this.Controls.Add(this.pnlAdminOverview);
            this.Controls.Add(this.pnlOverviewVehicles);
            this.Controls.Add(this.pnlReturnsDueToday);
            this.Controls.Add(this.pnlRentalsDue);
            this.Controls.Add(this.pnlVehiclesAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlOverView);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlQuickActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainDashboardPanel";
            this.Text = "z";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.pnlOverView.ResumeLayout(false);
            this.pnlOverView.PerformLayout();
            this.pnlSearchActiveRentals.ResumeLayout(false);
            this.pnlSearchActiveRentals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveRentals)).EndInit();
            this.pnlVehiclesAvailable.ResumeLayout(false);
            this.pnlVehiclesAvailable.PerformLayout();
            this.pnlRentalsDue.ResumeLayout(false);
            this.pnlRentalsDue.PerformLayout();
            this.pnlReturnsDueToday.ResumeLayout(false);
            this.pnlReturnsDueToday.PerformLayout();
            this.pnlOverviewVehicles.ResumeLayout(false);
            this.pnlOverviewVehicles.PerformLayout();
            this.pnlAdminOverview.ResumeLayout(false);
            this.pnlAdminOverview.PerformLayout();
            this.pnlAvgDailyRate.ResumeLayout(false);
            this.pnlAvgDailyRate.PerformLayout();
            this.pnlFleetUtilization.ResumeLayout(false);
            this.pnlFleetUtilization.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Panel pnlOverView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlVehiclesAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRentalsDue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlReturnsDueToday;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlOverviewVehicles;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlAdminOverview;
        private System.Windows.Forms.Panel pnlFleetUtilization;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlAvgDailyRate;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvActiveRentals;
        private System.Windows.Forms.Panel pnlSearchActiveRentals;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearchActiveRentals;
        private System.Windows.Forms.Button btnProcessContract;
    }
}