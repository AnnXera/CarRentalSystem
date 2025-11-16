using System;
using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class EmployeeRepository
    {
        private readonly SQLDBHelper _db;
        public EmployeeRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        // Additional methods for EmployeeRepository can be added here
        /*public long AddEmployee(Employee emp)
        {
            string sql = @"INSERT INTO Employee 
                   (FullName, Username, Password, Role)
                   VALUES (@FullName, @Username, @Password, @Role);
                   SELECT LAST_INSERT_ID();";
            try
            {
                if (_db.Connection.State != System.Data.ConnectionState.Open)
                    _db.Open();
                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@Username", emp.Username);
                    cmd.Parameters.AddWithValue("@Password", emp.Password); // Assume password is already hashed
                    cmd.Parameters.AddWithValue("@Role", emp.Role);
                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding employee: " + ex.Message);
            }
        }*/
    }
}
