using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Utils
{
    internal class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (var b in hash)
                {
                    builder.Append(b.ToString("x2")); // convert to hex string
                }
                return builder.ToString();
            }
        }
    }
}
