using MySql.Data.MySqlClient;
using System;
using CarRentalSystem.Code;
using System.Collections.Generic;
using CarRentalSystem.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    internal class CustomerRepository
    {
        private readonly SQLDBHelper _db;

        public CustomerRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();
            _db.Open();

            string query = @"SELECT c.*, e.FullName AS RegisteredByName
                             FROM Customers c
                             LEFT JOIN Employee e ON c.RegisteredBy = e.EmpID";

            using (var cmd = new MySqlCommand(query, _db.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        CustID = Convert.ToInt64(reader["CustID"]),
                        FullName = reader["FullName"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Address = reader["Address"].ToString(),
                        RegisteredByEmpID = reader["RegisteredBy"] != DBNull.Value
                            ? Convert.ToInt64(reader["RegisteredBy"])
                            : 0,
                        RegisteredByName = reader["RegisteredByName"] != DBNull.Value
                            ? reader["RegisteredByName"].ToString()
                            : "N/A"
                    };

                    if (!(reader["DriversLicensePic"] is DBNull))
                        customer.Picture = (byte[])reader["DriversLicensePic"];

                    customers.Add(customer);
                }
            }

            _db.Close();
            return customers;
        }



        public void AddCustomer(Customer cs)
        {
            _db.Open();

            string query = @"INSERT INTO Customers 
                             (FullName, Gender, PhoneNumber, Address, RegisteredBy, DriversLicensePic)
                             VALUES (@FullName, @Gender, @PhoneNumber, @Address, @RegisteredBy, @Picture)";

            using (var cmd = new MySqlCommand(query, _db.Connection))
            {
                cmd.Parameters.AddWithValue("@FullName", cs.FullName);
                cmd.Parameters.AddWithValue("@Gender", cs.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", cs.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", cs.Address);
                cmd.Parameters.AddWithValue("@RegisteredBy", cs.RegisteredByEmpID);

                if (cs.Picture != null && cs.Picture.Length > 0)
                    cmd.Parameters.AddWithValue("@Picture", cs.Picture);
                else
                    cmd.Parameters.AddWithValue("@Picture", DBNull.Value);

                cmd.ExecuteNonQuery();
            }

            _db.Close();
        }

        public void UpdateCustomer(Customer cs)
        {
            _db.Open();

            string query = @"UPDATE Customers SET 
                             FullName=@FullName, Gender=@Gender, PhoneNumber=@PhoneNumber, Address=@Address, DriversLicensePic=@Picture
                             WHERE CustID=@CustID";

            using (var cmd = new MySqlCommand(query, _db.Connection))
            {
                cmd.Parameters.AddWithValue("@CustID", cs.CustID);
                cmd.Parameters.AddWithValue("@FullName", cs.FullName);
                cmd.Parameters.AddWithValue("@Gender", cs.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", cs.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", cs.Address);

                if (cs.Picture != null && cs.Picture.Length > 0)
                    cmd.Parameters.AddWithValue("@Picture", cs.Picture);
                else
                    cmd.Parameters.AddWithValue("@Picture", DBNull.Value);

                cmd.ExecuteNonQuery();
            }

            _db.Close();
        }

        public long GetNextCustomerId()
        {
            _db.Open();
            long nextId = 1;

            string query = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Customers'";
            using (var cmd = new MySqlCommand(query, _db.Connection))
            {
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nextId = Convert.ToInt64(result);
            }

            _db.Close();
            return nextId;
        }
    }
}
