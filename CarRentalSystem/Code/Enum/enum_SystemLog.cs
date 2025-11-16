using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code.Enum
{
    public class enum_SystemLog
    {
        public enum SystemLogAction
        {
            [Description("Login")]
            Login,

            [Description("Logout")]
            Logout,

            [Description("Add Employee")]
            AddEmployee,

            [Description("Edit Employee")]
            EditEmployee,

            [Description("Add Customer")]
            DeleteEmployee,

            [Description("Edit Customer")]
            AddCustomer,

            [Description("Add Car")]
            AddCar,

            [Description("Edit Car")]
            EditCar,

            [Description("Create Contract")]
            CreateContract,
        }
    }
}
