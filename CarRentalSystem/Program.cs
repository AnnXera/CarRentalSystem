using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.WindowsForm;
using CarRentalSystem.WindowsForm.AdminForms;
using CarRentalSystem.WindowsForm.Modal;
using CarRentalSystem.PDF;

namespace CarRentalSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new modal_ProcessReturn());
        }
    }
}
