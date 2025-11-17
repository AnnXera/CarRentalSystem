using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Code;

namespace CarRentalSystem.Utils
{
    internal class AccessManager
    {
        public static void ApplyAccessRules(Form form, Employee loggedInEmployee)
        {
            if (loggedInEmployee == null)
            {
                MessageBox.Show("No logged-in user detected. Please log in again.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
                return;
            }

            // Admin can access everything
            if (loggedInEmployee.Role == "Admin")
            {
                ShowControlIfExists(form, "pnlAdminOverview", true);
                ShowControlIfExists(form, "btnRentalPlans", true);
                ShowControlIfExists(form, "btnSystemLog", true);
                ShowControlIfExists(form, "btnEmployeeManagement", true);
            }
            else
            {
                // Hide restricted buttons for non-admin users
                ShowControlIfExists(form, "pnlAdminOverview", false);
                ShowControlIfExists(form, "btnEmployeeManagement", false);
                ShowControlIfExists(form, "btnRentalPlans", false);
                ShowControlIfExists(form, "btnSystemLog", false);
            }
        }

        // Helper: Find a control by name and show/hide it
        private static void ShowControlIfExists(Form form, string controlName, bool visible)
        {
            var control = form.Controls.Find(controlName, true); // search recursively
            if (control.Length > 0)
            {
                control[0].Visible = visible;
            }
        }
    }
}
