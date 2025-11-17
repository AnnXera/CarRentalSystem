using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public long AddEmployee(Employee emp)
        {
            long newEmpId = 0;

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("AddEmployee", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_FullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@p_Username", emp.Username);
                    cmd.Parameters.AddWithValue("@p_Password", emp.Password);
                    cmd.Parameters.AddWithValue("@p_Role", emp.Role);

                    // output parameter
                    var outputParam = new MySqlParameter("@p_NewEmpID", MySqlDbType.Int64)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    newEmpId = Convert.ToInt64(outputParam.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding employee: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return newEmpId;
        }

        public void UpdateEmployee(Employee emp)
        {
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("UpdateEmployee", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_EmpID", emp.EmpID);
                    cmd.Parameters.AddWithValue("@p_FullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@p_Username", emp.Username);
                    cmd.Parameters.AddWithValue("@p_Role", emp.Role);

                    // NULL means "don't update password"
                    cmd.Parameters.AddWithValue("@p_Password", (object)emp.Password ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _db.Close();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            var list = new List<Employee>();
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("GetAllEmployees", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Employee
                            {
                                EmpID = Convert.ToInt64(reader["EmpID"]),
                                FullName = reader["FullName"].ToString(),
                                Username = reader["Username"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
            }
            finally
            {
                _db.Close();
            }
            return list;
        }

        public bool IsUsernameTaken(string username, long? excludeEmpId = null)
        {
            bool exists = false;

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = _db.Connection;

                    if (excludeEmpId.HasValue)
                    {
                        // Exclude current employee when editing
                        cmd.CommandText = "SELECT COUNT(*) FROM Employee WHERE Username = @username AND EmpID <> @id";
                        cmd.Parameters.AddWithValue("@id", excludeEmpId.Value);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM Employee WHERE Username = @username";
                    }

                    cmd.Parameters.AddWithValue("@username", username);

                    long count = Convert.ToInt64(cmd.ExecuteScalar());
                    exists = count > 0;
                }
            }
            finally
            {
                _db.Close();
            }

            return exists;
        }

        public long GetNextEmployeeID()
        {
            long nextId = 1;
            _db.Open();

            using (var cmd = new MySqlCommand("GetNextEmployeeId", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var outParam = new MySqlParameter("@p_NextID", MySqlDbType.Int64)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();
                nextId = Convert.ToInt64(outParam.Value);
            }

            _db.Close();
            return nextId;
        }

        public int GetEmployeeCount()
        {
            int count = 0;

            try
            {
                _db.Open();

                using (var cmd = new MySqlCommand("GetEmployeeCount", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Output parameter
                    var outputParam = new MySqlParameter("@p_TotalEmployees", MySqlDbType.Int32)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(outputParam.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving employee count: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return count;
        }
    }
}
