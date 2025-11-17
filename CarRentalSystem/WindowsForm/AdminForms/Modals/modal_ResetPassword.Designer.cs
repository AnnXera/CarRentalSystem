namespace CarRentalSystem.WindowsForm.AdminForms.Modals
{
    partial class modal_ResetPassword
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
            this.pnlResetPassword = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbxShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlResetPassword.SuspendLayout();
            this.pnlNewPassword.SuspendLayout();
            this.pnlConfirmPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResetPassword
            // 
            this.pnlResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResetPassword.BackColor = System.Drawing.Color.White;
            this.pnlResetPassword.Controls.Add(this.chbxShowPassword);
            this.pnlResetPassword.Controls.Add(this.btnSave);
            this.pnlResetPassword.Controls.Add(this.btnCancel);
            this.pnlResetPassword.Controls.Add(this.pnlConfirmPassword);
            this.pnlResetPassword.Controls.Add(this.label3);
            this.pnlResetPassword.Controls.Add(this.pnlNewPassword);
            this.pnlResetPassword.Controls.Add(this.label2);
            this.pnlResetPassword.Controls.Add(this.label1);
            this.pnlResetPassword.Controls.Add(this.panel2);
            this.pnlResetPassword.Location = new System.Drawing.Point(12, 12);
            this.pnlResetPassword.Name = "pnlResetPassword";
            this.pnlResetPassword.Size = new System.Drawing.Size(439, 469);
            this.pnlResetPassword.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(10, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 1);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlNewPassword.Controls.Add(this.txtNewPassword);
            this.pnlNewPassword.Location = new System.Drawing.Point(20, 137);
            this.pnlNewPassword.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(399, 46);
            this.pnlNewPassword.TabIndex = 31;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(13, 10);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(373, 27);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(20, 246);
            this.pnlConfirmPassword.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(399, 46);
            this.pnlConfirmPassword.TabIndex = 33;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(13, 10);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(373, 27);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Confirm Password";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(281, 401);
            this.btnSave.Margin = new System.Windows.Forms.Padding(27, 22, 27, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 48);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.Location = new System.Drawing.Point(128, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(27, 22, 27, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 48);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbxShowPassword
            // 
            this.chbxShowPassword.AutoSize = true;
            this.chbxShowPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxShowPassword.Location = new System.Drawing.Point(298, 315);
            this.chbxShowPassword.Name = "chbxShowPassword";
            this.chbxShowPassword.Size = new System.Drawing.Size(121, 21);
            this.chbxShowPassword.TabIndex = 36;
            this.chbxShowPassword.Text = "Show Password";
            this.chbxShowPassword.UseVisualStyleBackColor = true;
            this.chbxShowPassword.CheckedChanged += new System.EventHandler(this.chbxShowPassword_CheckedChanged);
            // 
            // modal_ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(463, 493);
            this.Controls.Add(this.pnlResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modal_ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modal_ResetPassword";
            this.pnlResetPassword.ResumeLayout(false);
            this.pnlResetPassword.PerformLayout();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            this.pnlConfirmPassword.ResumeLayout(false);
            this.pnlConfirmPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResetPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbxShowPassword;
    }
}