using CarRentalSystem.Code;
using CarRentalSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            using (var cmd = new MySqlCommand("GetAllCustomers", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

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
                            RegisteredByEmpID = reader["RegisteredBy"] != DBNull.Value ? Convert.ToInt64(reader["RegisteredBy"]) : 0,
                            RegisteredByName = reader["RegisteredByName"] != DBNull.Value ? reader["RegisteredByName"].ToString() : "N/A",
                            Picture = reader["DriversLicensePic"] is DBNull ? null : (byte[])reader["DriversLicensePic"]
                        };

                        customers.Add(customer);
                    }
                }
            }

            _db.Close();
            return customers;
        }

        public long AddCustomer(Customer cs)
        {
            long newId = -1;
            _db.Open();

            using (var cmd = new MySqlCommand("AddCustomer", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_FullName", cs.FullName);
                cmd.Parameters.AddWithValue("@p_Gender", cs.Gender);
                cmd.Parameters.AddWithValue("@p_PhoneNumber", cs.PhoneNumber);
                cmd.Parameters.AddWithValue("@p_Address", cs.Address);
                cmd.Parameters.AddWithValue("@p_RegisteredBy", cs.RegisteredByEmpID);
                cmd.Parameters.AddWithValue("@p_Picture", cs.Picture ?? (object)DBNull.Value);

                var outParam = new MySqlParameter("@p_NewCustID", MySqlDbType.Int64)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();
                newId = Convert.ToInt64(outParam.Value);
            }

            _db.Close();
            return newId;
        }

        public void UpdateCustomer(Customer cs)
        {
            _db.Open();

            using (var cmd = new MySqlCommand("UpdateCustomer", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_CustID", cs.CustID);
                cmd.Parameters.AddWithValue("@p_FullName", cs.FullName);
                cmd.Parameters.AddWithValue("@p_Gender", cs.Gender);
                cmd.Parameters.AddWithValue("@p_PhoneNumber", cs.PhoneNumber);
                cmd.Parameters.AddWithValue("@p_Address", cs.Address);
                cmd.Parameters.AddWithValue("@p_Picture", cs.Picture ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }

            _db.Close();
        }

        public long GetNextCustomerId()
        {
            long nextId = 1;
            _db.Open();

            using (var cmd = new MySqlCommand("GetNextCustomerId", _db.Connection))
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

    }
}
