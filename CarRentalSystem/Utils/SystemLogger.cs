using CarRentalSystem.Database;
using MySql.Data.MySqlClient;
using System;

namespace CarRentalSystem.Utils
{
    public static class SystemLogger
    {
        public static void Log(string action, string description, long? employeeId = null)
        {
            try
            {
                var db = SQLDBHelper.Instance;
                db.Open();

                string sql = @"
                    INSERT INTO system_logs (EmployeeID, Action, Description)
                    VALUES (@emp, @action, @desc);
                ";

                using (var cmd = new MySqlCommand(sql, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@emp", employeeId.HasValue ? employeeId.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@action", action);
                    cmd.Parameters.AddWithValue("@desc", description);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Logging failed: " + ex.Message);
            }
        }
    }
}
