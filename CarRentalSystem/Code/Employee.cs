using MySql.Data.MySqlClient;
using System;
using CarRentalSystem.Utils;
using CarRentalSystem.Database;
using System.Collections.Generic;

namespace CarRentalSystem.Code
{
    public class Employee
    {
        public long EmpID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee Login(string username, string password)
        {
            var db = SQLDBHelper.Instance;
            db.Open();

            string hashedPassword = SecurityHelper.HashPassword(password);
            string query = "SELECT EmpID, FullName, Username, Role FROM Employee WHERE Username=@Username AND Password=@Password";

            using (var cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var emp = new Employee
                        {
                            EmpID = Convert.ToInt64(reader["EmpID"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString()
                        };

                        db.Close();

                        SystemLogger.Log(
                            "Login",
                            $"{emp.FullName} ({emp.Username}) logged in.",
                            emp.EmpID
                        );

                        return emp;
                    }
                    else
                    {
                        db.Close();
                        return null;
                    }
                }
            }
        }

    }

    public class EmployeeFactory : IModalFactory<Employee>
    {
        private readonly EmployeeRepository _repo;
        public EmployeeFactory()
        {
            _repo = new EmployeeRepository();
        }
        public List<Employee> ViewAll()
        {
            return _repo.GetAllEmployees();
        }
        public long Add(Employee emp)
        {
            return _repo.AddEmployee(emp);
        }
        public void Edit(Employee emp)
        {
            _repo.UpdateEmployee(emp);
        }
        public long EmployeeIDNext()
        {
            return _repo.GetNextEmployeeID();
        }
        public int GetCount()
        {
            return _repo.GetEmployeeCount();
        }
    }
}
