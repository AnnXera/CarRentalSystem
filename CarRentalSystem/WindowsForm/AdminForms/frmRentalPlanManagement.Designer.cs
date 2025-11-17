namespace CarRentalSystem.WindowsForm.AdminForms
{
    partial class frmRentalPlanManagement
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
            this.pnlRentalPlanView = new System.Windows.Forms.Panel();
            this.btnAddRentalPlan = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvRentalPlan = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlRentalPlanView.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRentalPlanView
            // 
            this.pnlRentalPlanView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRentalPlanView.BackColor = System.Drawing.Color.White;
            this.pnlRentalPlanView.Controls.Add(this.btnAddRentalPlan);
            this.pnlRentalPlanView.Controls.Add(this.pnlSearch);
            this.pnlRentalPlanView.Controls.Add(this.lblTitle);
            this.pnlRentalPlanView.Controls.Add(this.dgvRentalPlan);
            this.pnlRentalPlanView.Location = new System.Drawing.Point(12, 12);
            this.pnlRentalPlanView.Name = "pnlRentalPlanView";
            this.pnlRentalPlanView.Size = new System.Drawing.Size(1535, 765);
            this.pnlRentalPlanView.TabIndex = 76;
            // 
            // btnAddRentalPlan
            // 
            this.btnAddRentalPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRentalPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRentalPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRentalPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnAddRentalPlan.Location = new System.Drawing.Point(1272, 86);
            this.btnAddRentalPlan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnAddRentalPlan.Name = "btnAddRentalPlan";
            this.btnAddRentalPlan.Size = new System.Drawing.Size(243, 60);
            this.btnAddRentalPlan.TabIndex = 81;
            this.btnAddRentalPlan.Text = "Add RentalPlan";
            this.btnAddRentalPlan.UseVisualStyleBackColor = true;
            this.btnAddRentalPlan.Click += new System.EventHandler(this.btnAddRentalPlan_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.pictureBox4);
            this.pnlSearch.Location = new System.Drawing.Point(20, 86);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(20, 20, 5, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(674, 60);
            this.pnlSearch.TabIndex = 76;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 54);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Rental Plans";
            // 
            // dgvRentalPlan
            // 
            this.dgvRentalPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentalPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvRentalPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentalPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRentalPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRentalPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalPlan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentalPlan.EnableHeadersVisualStyles = false;
            this.dgvRentalPlan.Location = new System.Drawing.Point(18, 166);
            this.dgvRentalPlan.Margin = new System.Windows.Forms.Padding(5, 0, 20, 20);
            this.dgvRentalPlan.MultiSelect = false;
            this.dgvRentalPlan.Name = "dgvRentalPlan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRentalPlan.RowHeadersVisible = false;
            this.dgvRentalPlan.RowHeadersWidth = 51;
            this.dgvRentalPlan.RowTemplate.DividerHeight = 1;
            this.dgvRentalPlan.RowTemplate.Height = 40;
            this.dgvRentalPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRentalPlan.Size = new System.Drawing.Size(1497, 579);
            this.dgvRentalPlan.TabIndex = 74;
            this.dgvRentalPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalPlan_CellClick);
            this.dgvRentalPlan.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvRentalPlan_Paint);
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
            this.txtSearch.Size = new System.Drawing.Size(589, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmRentalPlanManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlRentalPlanView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentalPlanManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRentalPlanManagement";
            this.pnlRentalPlanView.ResumeLayout(false);
            this.pnlRentalPlanView.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRentalPlanView;
        private System.Windows.Forms.Button btnAddRentalPlan;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvRentalPlan;
        private System.Windows.Forms.TextBox txtSearch;
    }
}