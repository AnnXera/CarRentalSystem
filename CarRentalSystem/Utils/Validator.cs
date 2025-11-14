using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Utils
{
    public class Validator
    {
        // ---------------- General Required Field ----------------
        public static void RequireNotEmpty(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception($"{fieldName} is required.");
        }

        public static void RequirePictureSelected(PictureBox pictureBox, string fieldName = "Picture")
        {
            if (pictureBox == null)
                throw new ArgumentNullException(nameof(pictureBox));

            if (pictureBox.Image == null)
                throw new Exception($"{fieldName} is required. Please select an image.");
        }

        public static void RequireGenderSelected(bool maleChecked, bool femaleChecked)
        {
            if (!maleChecked && !femaleChecked)
                throw new Exception("Please select a gender.");
        }

        public static void RequireComboBoxSelected(ComboBox comboBox, string fieldName)
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            if (comboBox.SelectedIndex < 0 || comboBox.SelectedValue == null)
            {
                comboBox.BackColor = Color.MistyRose; // highlight invalid
                throw new Exception($"Please select a {fieldName}.");
            }
            else
            {
                comboBox.BackColor = Color.White; // reset if valid
            }
        }

        // ---------------- Text Validations ----------------
        public static void ValidateLettersOnly(string text, string fieldName)
        {
            if (!Regex.IsMatch(text, @"^[A-Za-z\s]+$"))
                throw new Exception($"{fieldName} must contain only letters and spaces.");
        }

        public static void ValidateMaxLength(string text, int maxLength, string fieldName)
        {
            if (!string.IsNullOrEmpty(text) && text.Length > maxLength)
                throw new Exception($"{fieldName} cannot exceed {maxLength} characters.");
        }

        public static void ValidateAlphanumeric(string text, string fieldName)
        {
            if (!Regex.IsMatch(text, @"^[A-Za-z0-9]+$"))
                throw new Exception($"{fieldName} must contain only letters and numbers.");
        }

        // ---------------- Phone and ID ----------------
        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new Exception("Contact Number is required.");

            if (!Regex.IsMatch(phoneNumber, @"^\d{11}$"))
                throw new Exception("Contact Number must contain exactly 11 digits.");
        }

        public static void ValidateDriversLicense(string license)
        {
            if (string.IsNullOrWhiteSpace(license))
                throw new Exception("Driver's License is required.");

            if (!Regex.IsMatch(license, @"^[A-Za-z0-9\-]+$"))
                throw new Exception("Driver's License must be alphanumeric.");
        }

        public static void ValidateVIN(string vin)
        {
            if (string.IsNullOrWhiteSpace(vin))
                throw new Exception("VIN is required.");

            if (!Regex.IsMatch(vin, @"^[A-HJ-NPR-Z0-9]{17}$"))
                throw new Exception("VIN must be exactly 17 alphanumeric characters (excluding I, O, Q).");
        }

        public static void ValidatePlateNumber(string plateNumber)
        {
            if (string.IsNullOrWhiteSpace(plateNumber))
                throw new Exception("Plate Number is required.");

            if (!Regex.IsMatch(plateNumber, @"^[A-Z0-9\-]{1,10}$"))
                throw new Exception("Plate Number must be alphanumeric and up to 10 characters.");
        }

        // ---------------- Numeric Validations ----------------
        public static void ValidateInteger(string value, string fieldName)
        {
            if (!int.TryParse(value, out _))
                throw new Exception($"{fieldName} must be a valid integer.");
        }

        public static void ValidateDecimal(string value, string fieldName)
        {
            if (!decimal.TryParse(value, out _))
                throw new Exception($"{fieldName} must be a valid decimal number.");
        }

        public static void ValidatePositiveInteger(string value, string fieldName)
        {
            if (!int.TryParse(value, out int result) || result <= 0)
                throw new Exception($"{fieldName} must be a positive integer.");
        }

        public static void ValidatePositiveDecimal(string value, string fieldName)
        {
            if (!decimal.TryParse(value, out decimal result) || result <= 0)
                throw new Exception($"{fieldName} must be a positive number.");
        }

        public static void ValidateYear(string value, string fieldName = "Year")
        {
            if (!int.TryParse(value, out int year) || year < 1886 || year > DateTime.Now.Year + 1)
                throw new Exception($"{fieldName} must be a valid year.");
        }

        // ---------------- Specific Validations ----------------
        public static void ValidateMinimumSecurityDeposit(string value, decimal minimum = 10000, string fieldName = "Security Deposit")
        {
            if (!decimal.TryParse(value, out decimal result))
                throw new Exception($"{fieldName} must be a valid decimal number.");

            if (result < minimum)
                throw new Exception($"{fieldName} must be at least {minimum:C}.");
        }

        // ---------------- Misc ----------------
        public static void ValidateRange(int value, int min, int max, string fieldName)
        {
            if (value < min || value > max)
                throw new Exception($"{fieldName} must be between {min} and {max}.");
        }

        public static void ValidateDate(DateTime date, string fieldName)
        {
            if (date == default)
                throw new Exception($"{fieldName} is required.");
        }

        public static void ValidateNotPastDate(DateTime date, string fieldName)
        {
            if (date.Date < DateTime.Today)
                throw new Exception($"{fieldName} cannot be before today.");
        }
    }
}
