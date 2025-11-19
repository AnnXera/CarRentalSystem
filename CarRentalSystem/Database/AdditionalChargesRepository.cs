using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class AdditionalChargesRepository
    {
        private readonly SQLDBHelper _db;

        public AdditionalChargesRepository()
        {
            _db = SQLDBHelper.Instance;
        }
    }
}
