using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static CarRentalSystem.Code.Enum.enum_SystemLog;

namespace CarRentalSystem.Utils
{
    public class EnumHelper
    {
        public static List<KeyValuePair<SystemLogAction, string>> GetEnumDescriptions()
        {
            return Enum.GetValues(typeof(SystemLogAction))
                       .Cast<SystemLogAction>()
                       .Select(e => new KeyValuePair<SystemLogAction, string>(e, GetDescription(e)))
                       .ToList();
        }

        public static string GetDescription(SystemLogAction value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
