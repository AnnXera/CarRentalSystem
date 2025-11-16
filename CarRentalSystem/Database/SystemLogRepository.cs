using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class SystemLogRepository
    {
        private readonly SQLDBHelper _db;

        public SystemLogRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public List<SystemLog> GetAllLogs()
        {
            var logs = new List<SystemLog>();

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("ViewSystemLogs", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logs.Add(new SystemLog
                            {
                                LogID = reader.GetInt64("LogID"),
                                LogDate = reader.GetDateTime("LogDate"),
                                Action = reader.GetString("Action"),
                                Description = reader.GetString("Description"),
                                EmployeeName = reader.IsDBNull(reader.GetOrdinal("EmployeeName"))
                                                ? "System"
                                                : reader.GetString("EmployeeName")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving system logs: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return logs;
        }
    }
}
