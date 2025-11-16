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


    }
}
