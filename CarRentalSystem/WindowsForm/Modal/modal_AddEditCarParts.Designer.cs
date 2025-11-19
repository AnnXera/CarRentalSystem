namespace CarRentalSystem.WindowsForm.Modal
{
    partial class modal_AddEditCarParts
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
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAddEditPart = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPart = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlAddEditPart.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 39);
            this.label3.TabIndex = 34;
            this.label3.Text = "Managed Car Parts";
            // 
            // pnlAddEditPart
            // 
            this.pnlAddEditPart.BackColor = System.Drawing.Color.White;
            this.pnlAddEditPart.Controls.Add(this.cbxStatus);
            this.pnlAddEditPart.Controls.Add(this.lblStatus);
            this.pnlAddEditPart.Controls.Add(this.btnCancel);
            this.pnlAddEditPart.Controls.Add(this.btnSave);
            this.pnlAddEditPart.Controls.Add(this.panel4);
            this.pnlAddEditPart.Controls.Add(this.txtCost);
            this.pnlAddEditPart.Controls.Add(this.txtPartName);
            this.pnlAddEditPart.Controls.Add(this.label5);
            this.pnlAddEditPart.Controls.Add(this.label13);
            this.pnlAddEditPart.Location = new System.Drawing.Point(20, 73);
            this.pnlAddEditPart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddEditPart.Name = "pnlAddEditPart";
            this.pnlAddEditPart.Size = new System.Drawing.Size(720, 378);
            this.pnlAddEditPart.TabIndex = 77;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(149, 160);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(233, 31);
            this.cbxStatus.TabIndex = 83;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 163);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 23);
            this.lblStatus.TabIndex = 82;
            this.lblStatus.Text = "Status:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(373, 309);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 49);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(545, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 50);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "ADD / SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.lblPart);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 52);
            this.panel4.TabIndex = 80;
            // 
            // lblPart
            // 
            this.lblPart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.ForeColor = System.Drawing.Color.White;
            this.lblPart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPart.Location = new System.Drawing.Point(248, 9);
            this.lblPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPart.Name = "lblPart";
            this.lblPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPart.Size = new System.Drawing.Size(249, 33);
            this.lblPart.TabIndex = 76;
            this.lblPart.Text = "Add / Update Part";
            this.lblPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            this.txtCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(488, 88);
            this.txtCost.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(209, 34);
            this.txtCost.TabIndex = 80;
            // 
            // txtPartName
            // 
            this.txtPartName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPartName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(151, 92);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(233, 30);
            this.txtPartName.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Part Name:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(411, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 77;
            this.label13.Text = "Cost:";
            // 
            // modal_AddEditCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(765, 476);
            this.Controls.Add(this.pnlAddEditPart);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modal_AddEditCarParts";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modal_AddEditCarParts";
            this.pnlAddEditPart.ResumeLayout(false);
            this.pnlAddEditPart.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAddEditPart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}