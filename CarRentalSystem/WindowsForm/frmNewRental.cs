using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm
{
    public partial class frmNewRental : Form
    {
        public frmNewRental()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form setup
            this.Text = "New Rental";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Add a simple label
            Label lbl = new Label
            {
                Text = "New Rental Form\n\nThis form will contain rental creation fields.",
                Location = new Point(50, 50),
                Size = new Size(400, 200),
                Font = new Font("Segoe UI", 12F)
            };
            this.Controls.Add(lbl);

            // Add OK button
            Button btnOk = new Button
            {
                Text = "OK",
                Location = new Point(200, 300),
                Size = new Size(100, 35),
                DialogResult = DialogResult.OK
            };
            this.Controls.Add(btnOk);

            this.ResumeLayout(false);
        }
    }
}