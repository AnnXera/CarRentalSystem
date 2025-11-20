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

            [Description("Add Rental Plan")]
            AddRentalPlan,

            [Description("Edit Rental Plan")]
            EditRentalPlan,

            [Description("Delete Rental Plan")]
            DeleteRentalPlan,

            [Description("Create Contract")]
            CreateContract,

            [Description("Activate Contract")]
            ActivateContract,

            [Description("Cancel Contract")]
            CancelContract,
        }
    }
}
