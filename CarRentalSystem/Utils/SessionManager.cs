using CarRentalSystem.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Utils
{
    internal class SessionManager
    {
        public static Employee LoggedInEmployee { get; private set; }

        public static void StartSession(Employee employee)
        {
            LoggedInEmployee = employee;
        }

        public static void EndSession()
        {
            LoggedInEmployee = null;
        }

        public static bool IsLoggedIn => LoggedInEmployee != null;
    }
}
