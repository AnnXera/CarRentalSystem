namespace CarRentalSystem.WindowsForm.AdminForms
{
    partial class frmSystemLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSystemLogView = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.cbxAction = new System.Windows.Forms.ComboBox();
            this.pnlEndDate = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlStartDate = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.cbxEmployeeNames = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvSystemLog = new System.Windows.Forms.DataGridView();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.pnlSystemLogView.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlEndDate.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSystemLogView
            // 
            this.pnlSystemLogView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSystemLogView.BackColor = System.Drawing.Color.White;
            this.pnlSystemLogView.Controls.Add(this.btnClearFilter);
            this.pnlSystemLogView.Controls.Add(this.label17);
            this.pnlSystemLogView.Controls.Add(this.label15);
            this.pnlSystemLogView.Controls.Add(this.label14);
            this.pnlSystemLogView.Controls.Add(this.label13);
            this.pnlSystemLogView.Controls.Add(this.pnlAction);
            this.pnlSystemLogView.Controls.Add(this.pnlEndDate);
            this.pnlSystemLogView.Controls.Add(this.pnlStartDate);
            this.pnlSystemLogView.Controls.Add(this.pnlEmployee);
            this.pnlSystemLogView.Controls.Add(this.lblTitle);
            this.pnlSystemLogView.Controls.Add(this.dgvSystemLog);
            this.pnlSystemLogView.Location = new System.Drawing.Point(12, 12);
            this.pnlSystemLogView.Name = "pnlSystemLogView";
            this.pnlSystemLogView.Size = new System.Drawing.Size(1535, 765);
            this.pnlSystemLogView.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(933, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 28);
            this.label17.TabIndex = 101;
            this.label17.Text = "Action Description:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(13, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 28);
            this.label15.TabIndex = 99;
            this.label15.Text = "Employee:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(473, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 28);
            this.label14.TabIndex = 98;
            this.label14.Text = "End Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(13, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 28);
            this.label13.TabIndex = 97;
            this.label13.Text = "Start Date:";
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlAction.Controls.Add(this.cbxAction);
            this.pnlAction.Location = new System.Drawing.Point(938, 124);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(577, 55);
            this.pnlAction.TabIndex = 95;
            // 
            // cbxAction
            // 
            this.cbxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAction.FormattingEnabled = true;
            this.cbxAction.Location = new System.Drawing.Point(17, 10);
            this.cbxAction.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(542, 36);
            this.cbxAction.TabIndex = 57;
            // 
            // pnlEndDate
            // 
            this.pnlEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlEndDate.Controls.Add(this.dtpEndDate);
            this.pnlEndDate.Location = new System.Drawing.Point(478, 124);
            this.pnlEndDate.Margin = new System.Windows.Forms.Padding(0, 4, 20, 4);
            this.pnlEndDate.Name = "pnlEndDate";
            this.pnlEndDate.Size = new System.Drawing.Size(440, 55);
            this.pnlEndDate.TabIndex = 96;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(17, 10);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(401, 34);
            this.dtpEndDate.TabIndex = 1;
            // 
            // pnlStartDate
            // 
            this.pnlStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlStartDate.Controls.Add(this.dtpStartDate);
            this.pnlStartDate.Location = new System.Drawing.Point(18, 124);
            this.pnlStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 20, 20);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(440, 55);
            this.pnlStartDate.TabIndex = 93;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(17, 10);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(401, 34);
            this.dtpStartDate.TabIndex = 1;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlEmployee.Controls.Add(this.cbxEmployeeNames);
            this.pnlEmployee.Location = new System.Drawing.Point(18, 241);
            this.pnlEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 20, 20);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(417, 55);
            this.pnlEmployee.TabIndex = 92;
            // 
            // cbxEmployeeNames
            // 
            this.cbxEmployeeNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmployeeNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxEmployeeNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmployeeNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeNames.FormattingEnabled = true;
            this.cbxEmployeeNames.Location = new System.Drawing.Point(17, 10);
            this.cbxEmployeeNames.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxEmployeeNames.Name = "cbxEmployeeNames";
            this.cbxEmployeeNames.Size = new System.Drawing.Size(383, 36);
            this.cbxEmployeeNames.TabIndex = 57;
            this.cbxEmployeeNames.Text = "All Users";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 54);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "System Log";
            // 
            // dgvSystemLog
            // 
            this.dgvSystemLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSystemLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSystemLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSystemLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSystemLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSystemLog.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSystemLog.EnableHeadersVisualStyles = false;
            this.dgvSystemLog.Location = new System.Drawing.Point(18, 316);
            this.dgvSystemLog.Margin = new System.Windows.Forms.Padding(5, 0, 20, 20);
            this.dgvSystemLog.MultiSelect = false;
            this.dgvSystemLog.Name = "dgvSystemLog";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSystemLog.RowHeadersVisible = false;
            this.dgvSystemLog.RowHeadersWidth = 51;
            this.dgvSystemLog.RowTemplate.DividerHeight = 1;
            this.dgvSystemLog.RowTemplate.Height = 40;
            this.dgvSystemLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSystemLog.Size = new System.Drawing.Size(1497, 429);
            this.dgvSystemLog.TabIndex = 74;
            this.dgvSystemLog.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSystemLog_Paint);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.Black;
            this.btnClearFilter.Location = new System.Drawing.Point(1374, 243);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(141, 55);
            this.btnClearFilter.TabIndex = 102;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // frmSystemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlSystemLogView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSystemLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSystemLog";
            this.pnlSystemLogView.ResumeLayout(false);
            this.pnlSystemLogView.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlEndDate.ResumeLayout(false);
            this.pnlStartDate.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystemLogView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.ComboBox cbxAction;
        private System.Windows.Forms.Panel pnlEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel pnlStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.ComboBox cbxEmployeeNames;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSystemLog;
        private System.Windows.Forms.Button btnClearFilter;
    }
}