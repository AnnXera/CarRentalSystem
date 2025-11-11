namespace CarRentalSystem.WindowsForm.Modal
{
    partial class modal_Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblRentalName = new System.Windows.Forms.Label();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Payment";
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Controls.Add(this.lblRentalName);
            this.pnlPayment.Controls.Add(this.lblCarName);
            this.pnlPayment.Controls.Add(this.lblCustomerName);
            this.pnlPayment.Controls.Add(this.btnCancel);
            this.pnlPayment.Controls.Add(this.btnConfirmPayment);
            this.pnlPayment.Controls.Add(this.label6);
            this.pnlPayment.Controls.Add(this.label5);
            this.pnlPayment.Controls.Add(this.txtAmountReceived);
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.cbxPaymentMethod);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.lblAmount);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Location = new System.Drawing.Point(18, 54);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(770, 414);
            this.pnlPayment.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount Due:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(644, 135);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmount.Size = new System.Drawing.Size(109, 23);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "(lblAmount)";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Method:";
            // 
            // cbxPaymentMethod
            // 
            this.cbxPaymentMethod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentMethod.FormattingEnabled = true;
            this.cbxPaymentMethod.Location = new System.Drawing.Point(453, 179);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.Size = new System.Drawing.Size(296, 31);
            this.cbxPaymentMethod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount Received:";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountReceived.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.Location = new System.Drawing.Point(453, 238);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(296, 30);
            this.txtAmountReceived.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Remaining Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 290);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(204, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "(lblRemainingBalance)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(521, 351);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(228, 44);
            this.btnConfirmPayment.TabIndex = 50;
            this.btnConfirmPayment.Text = "CONFIRM PAYMENT";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.Location = new System.Drawing.Point(287, 351);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 44);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(11, 10);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(275, 33);
            this.lblCustomerName.TabIndex = 52;
            this.lblCustomerName.Text = "(lblCustomerName)";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCarName.Location = new System.Drawing.Point(33, 87);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(157, 27);
            this.lblCarName.TabIndex = 53;
            this.lblCarName.Text = "(lblCarName)";
            // 
            // lblRentalName
            // 
            this.lblRentalName.AutoSize = true;
            this.lblRentalName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRentalName.Location = new System.Drawing.Point(33, 50);
            this.lblRentalName.Name = "lblRentalName";
            this.lblRentalName.Size = new System.Drawing.Size(179, 27);
            this.lblRentalName.TabIndex = 54;
            this.lblRentalName.Text = "(lblRentalPlan)";
            // 
            // modal_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modal_Payment";
            this.Text = "modal_Payment";
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label lblRentalName;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCustomerName;
    }
}