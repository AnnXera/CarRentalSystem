using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.WindowsForm.Modal
{
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            using (var modalPayment = new modal_Payment()) 
            { 
                modalPayment.ShowDialog();
            }
        }
    }
}
