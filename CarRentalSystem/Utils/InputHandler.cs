using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Utils
{
    public class InputHandler
    {
        // Allow only integers 
        public static void AllowOnlyInteger(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Allow decimal numbers
        public static void AllowDecimal(KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Only allow one dot
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // Only integers with max length
        public static void AllowIntegerWithLimit(KeyPressEventArgs e, TextBox textBox, int maxLength)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        // Allow only letters and spaces
        public static void AllowLettersOnly(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Allow alphanumeric only
        public static void AllowAlphanumeric(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void AllowVIN(KeyPressEventArgs e, TextBox textBox)
        {
            char c = char.ToUpper(e.KeyChar);

            // Allow control keys (backspace, delete)
            if (char.IsControl(c))
                return;

            // Allow only letters A-H, J-N, P, R-Z and digits 0-9
            if (!((c >= 'A' && c <= 'H') ||
                  (c >= 'J' && c <= 'N') ||
                  c == 'P' || c == 'R' ||
                  (c >= 'S' && c <= 'Z') ||
                  char.IsDigit(c)))
            {
                e.Handled = true; // Invalid character
                return;
            }

            // Limit to 17 characters
            if (textBox.Text.Length >= 17)
                e.Handled = true;
        }

        public static void AllowPlateNumber(KeyPressEventArgs e, TextBox textBox, int maxLength = 10)
        {
            char c = char.ToUpper(e.KeyChar);

            // Allow control keys
            if (char.IsControl(c))
                return;

            // Allow letters, digits, and dash
            if (!char.IsLetterOrDigit(c) && c != '-')
            {
                e.Handled = true;
                return;
            }

            // Limit total length
            if (textBox.Text.Length >= maxLength)
                e.Handled = true;
        }

    }
}
