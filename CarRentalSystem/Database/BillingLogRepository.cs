using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class BillingLogRepository
    {
        private readonly SQLDBHelper _db;
        public BillingLogRepository()
        {

            _db = SQLDBHelper.Instance;
        }
    }
}
