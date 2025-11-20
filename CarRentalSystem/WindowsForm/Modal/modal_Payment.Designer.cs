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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.lblTextChangeRemainingBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentAmountDue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrevAmountPaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSecurityDepUsed = new System.Windows.Forms.Label();
            this.lblTotalChargeFee = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblMileageFee = new System.Windows.Forms.Label();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblCarPartsCharges = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Controls.Add(this.panel5);
            this.pnlPayment.Controls.Add(this.label7);
            this.pnlPayment.Controls.Add(this.btnCancel);
            this.pnlPayment.Controls.Add(this.btnConfirmPayment);
            this.pnlPayment.Controls.Add(this.lblTextChangeRemainingBalance);
            this.pnlPayment.Controls.Add(this.label5);
            this.pnlPayment.Controls.Add(this.txtAmountReceived);
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.cbxPaymentMethod);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.lblCurrentAmountDue);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Location = new System.Drawing.Point(352, 80);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(418, 633);
            this.pnlPayment.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(8, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 1);
            this.panel5.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 12, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 91;
            this.label7.Text = "Process Payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnCancel.Location = new System.Drawing.Point(55, 587);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 36);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(230, 587);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(172, 36);
            this.btnConfirmPayment.TabIndex = 50;
            this.btnConfirmPayment.Text = "CONFIRM PAYMENT";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // lblTextChangeRemainingBalance
            // 
            this.lblTextChangeRemainingBalance.AutoSize = true;
            this.lblTextChangeRemainingBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextChangeRemainingBalance.Location = new System.Drawing.Point(195, 179);
            this.lblTextChangeRemainingBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextChangeRemainingBalance.Name = "lblTextChangeRemainingBalance";
            this.lblTextChangeRemainingBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTextChangeRemainingBalance.Size = new System.Drawing.Size(165, 21);
            this.lblTextChangeRemainingBalance.TabIndex = 7;
            this.lblTextChangeRemainingBalance.Text = "(lblRemainingBalance)";
            this.lblTextChangeRemainingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Remaining Balance:";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountReceived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.Location = new System.Drawing.Point(194, 138);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(209, 29);
            this.txtAmountReceived.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount Received:";
            // 
            // cbxPaymentMethod
            // 
            this.cbxPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentMethod.FormattingEnabled = true;
            this.cbxPaymentMethod.Location = new System.Drawing.Point(195, 98);
            this.cbxPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.Size = new System.Drawing.Size(210, 29);
            this.cbxPaymentMethod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Method:";
            // 
            // lblCurrentAmountDue
            // 
            this.lblCurrentAmountDue.AutoSize = true;
            this.lblCurrentAmountDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAmountDue.Location = new System.Drawing.Point(195, 62);
            this.lblCurrentAmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentAmountDue.Name = "lblCurrentAmountDue";
            this.lblCurrentAmountDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentAmountDue.Size = new System.Drawing.Size(93, 21);
            this.lblCurrentAmountDue.TabIndex = 1;
            this.lblCurrentAmountDue.Text = "(lblAmount)";
            this.lblCurrentAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Amount Due:";
            // 
            // lblPrevAmountPaid
            // 
            this.lblPrevAmountPaid.AutoSize = true;
            this.lblPrevAmountPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevAmountPaid.Location = new System.Drawing.Point(163, 596);
            this.lblPrevAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevAmountPaid.Name = "lblPrevAmountPaid";
            this.lblPrevAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrevAmountPaid.Size = new System.Drawing.Size(122, 21);
            this.lblPrevAmountPaid.TabIndex = 93;
            this.lblPrevAmountPaid.Text = "(lblAmountPaid)";
            this.lblPrevAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 596);
            this.label11.Margin = new System.Windows.Forms.Padding(15, 0, 2, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 21);
            this.label11.TabIndex = 92;
            this.label11.Text = "Amount Prev Paid:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBillNo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblPrevAmountPaid);
            this.panel1.Controls.Add(this.lblContractNo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblCarName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblLost);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.lblSecurityDepUsed);
            this.panel1.Controls.Add(this.lblTotalChargeFee);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.lblMileageFee);
            this.panel1.Controls.Add(this.lblLateFee);
            this.panel1.Controls.Add(this.lblCarPartsCharges);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.lblBaseRate);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Location = new System.Drawing.Point(14, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 0, 11, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 633);
            this.panel1.TabIndex = 83;
            // 
            // lblBillNo
            // 
            this.lblBillNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(236, 245);
            this.lblBillNo.Margin = new System.Windows.Forms.Padding(8, 12, 3, 16);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBillNo.Size = new System.Drawing.Size(88, 25);
            this.lblBillNo.TabIndex = 98;
            this.lblBillNo.Text = "lblBillNo";
            this.lblBillNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(8, 230);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 1);
            this.panel3.TabIndex = 85;
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractNo.Location = new System.Drawing.Point(117, 54);
            this.lblContractNo.Margin = new System.Windows.Forms.Padding(8, 0, 0, 16);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContractNo.Size = new System.Drawing.Size(117, 21);
            this.lblContractNo.TabIndex = 97;
            this.lblContractNo.Text = "(lblContractNo)";
            this.lblContractNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.TabIndex = 96;
            this.label13.Text = "Contract No:";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(15, 185);
            this.lblCarName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarName.Size = new System.Drawing.Size(103, 21);
            this.lblCarName.TabIndex = 95;
            this.lblCarName.Text = "(lblCarName)";
            this.lblCarName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 94;
            this.label12.Text = "Car:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(15, 115);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(147, 21);
            this.lblCustomerName.TabIndex = 93;
            this.lblCustomerName.Text = "(lblCustomerName)";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 92;
            this.label10.Text = "Customer Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 12, 3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "Customer Details";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 12, 3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 90;
            this.label8.Text = "Billing Details";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.Location = new System.Drawing.Point(144, 448);
            this.lblLost.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(66, 21);
            this.lblLost.TabIndex = 51;
            this.lblLost.Text = "(lblLost)";
            this.lblLost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(88, 448);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 21);
            this.label20.TabIndex = 50;
            this.label20.Text = "Lost:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(163, 557);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalAmount.Size = new System.Drawing.Size(125, 21);
            this.lblTotalAmount.TabIndex = 48;
            this.lblTotalAmount.Text = "(lblTotalAmount)";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(10, 557);
            this.label24.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 21);
            this.label24.TabIndex = 47;
            this.label24.Text = "Total Amount Due:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 518);
            this.label27.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 21);
            this.label27.TabIndex = 45;
            this.label27.Text = "Deposit Used:";
            // 
            // lblSecurityDepUsed
            // 
            this.lblSecurityDepUsed.AutoSize = true;
            this.lblSecurityDepUsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityDepUsed.Location = new System.Drawing.Point(130, 518);
            this.lblSecurityDepUsed.Margin = new System.Windows.Forms.Padding(15, 0, 15, 16);
            this.lblSecurityDepUsed.Name = "lblSecurityDepUsed";
            this.lblSecurityDepUsed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSecurityDepUsed.Size = new System.Drawing.Size(100, 21);
            this.lblSecurityDepUsed.TabIndex = 44;
            this.lblSecurityDepUsed.Text = "(lblDepUsed)";
            this.lblSecurityDepUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalChargeFee
            // 
            this.lblTotalChargeFee.AutoSize = true;
            this.lblTotalChargeFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChargeFee.Location = new System.Drawing.Point(144, 479);
            this.lblTotalChargeFee.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.lblTotalChargeFee.Name = "lblTotalChargeFee";
            this.lblTotalChargeFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalChargeFee.Size = new System.Drawing.Size(93, 21);
            this.lblTotalChargeFee.TabIndex = 14;
            this.lblTotalChargeFee.Text = "(lblTotalFee)";
            this.lblTotalChargeFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(83, 479);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 21);
            this.label30.TabIndex = 13;
            this.label30.Text = "Total:";
            // 
            // lblMileageFee
            // 
            this.lblMileageFee.AutoSize = true;
            this.lblMileageFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageFee.Location = new System.Drawing.Point(142, 418);
            this.lblMileageFee.Margin = new System.Windows.Forms.Padding(15, 0, 0, 8);
            this.lblMileageFee.Name = "lblMileageFee";
            this.lblMileageFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMileageFee.Size = new System.Drawing.Size(116, 21);
            this.lblMileageFee.TabIndex = 12;
            this.lblMileageFee.Text = "(lblMileageFee)";
            this.lblMileageFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFee.Location = new System.Drawing.Point(142, 387);
            this.lblLateFee.Margin = new System.Windows.Forms.Padding(15, 0, 2, 8);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLateFee.Size = new System.Drawing.Size(90, 21);
            this.lblLateFee.TabIndex = 11;
            this.lblLateFee.Text = "(lblLateFee)";
            this.lblLateFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCarPartsCharges
            // 
            this.lblCarPartsCharges.AutoSize = true;
            this.lblCarPartsCharges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPartsCharges.Location = new System.Drawing.Point(142, 356);
            this.lblCarPartsCharges.Margin = new System.Windows.Forms.Padding(15, 0, 2, 8);
            this.lblCarPartsCharges.Name = "lblCarPartsCharges";
            this.lblCarPartsCharges.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarPartsCharges.Size = new System.Drawing.Size(152, 21);
            this.lblCarPartsCharges.TabIndex = 10;
            this.lblCarPartsCharges.Text = "(lblCarPartsCharges)";
            this.lblCarPartsCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(27, 418);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 0, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 21);
            this.label34.TabIndex = 9;
            this.label34.Text = "Mileage (KM):";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(41, 387);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 0, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 21);
            this.label35.TabIndex = 8;
            this.label35.Text = "Late Return:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(58, 356);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 0, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 21);
            this.label36.TabIndex = 7;
            this.label36.Text = "Car Parts:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(10, 325);
            this.label37.Margin = new System.Windows.Forms.Padding(15, 0, 2, 8);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(153, 21);
            this.label37.TabIndex = 6;
            this.label37.Text = "Additional Charges:";
            // 
            // lblBaseRate
            // 
            this.lblBaseRate.AutoSize = true;
            this.lblBaseRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseRate.Location = new System.Drawing.Point(155, 285);
            this.lblBaseRate.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.lblBaseRate.Name = "lblBaseRate";
            this.lblBaseRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBaseRate.Size = new System.Drawing.Size(100, 21);
            this.lblBaseRate.TabIndex = 5;
            this.lblBaseRate.Text = "(lblBaseRate)";
            this.lblBaseRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(10, 286);
            this.label39.Margin = new System.Windows.Forms.Padding(15, 0, 0, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(132, 21);
            this.label39.TabIndex = 4;
            this.label39.Text = "Base Rate (days):";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(14, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 53);
            this.panel4.TabIndex = 84;
            // 
            // modal_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(811, 752);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modal_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modal_Payment";
            this.Load += new System.EventHandler(this.modal_Payment_Load);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblCurrentAmountDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTextChangeRemainingBalance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSecurityDepUsed;
        private System.Windows.Forms.Label lblTotalChargeFee;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblMileageFee;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblCarPartsCharges;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPrevAmountPaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBillNo;
    }
}