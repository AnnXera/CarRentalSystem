using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class Contract_Repository
    {
        private readonly SQLDBHelper _db;
        public Contract_Repository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long CreateContract(Contracts contract, SecurityDeposit deposit, decimal baseRate, string paymentMethod, string customerName)
        {
            if (contract == null) throw new ArgumentNullException(nameof(contract));
            if (deposit == null) throw new ArgumentNullException(nameof(deposit));

            long newContractID = 0;

            _db.Open();

            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    using (var cmd = new MySqlCommand("CreateFullContract", _db.Connection, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Contract parameters
                        cmd.Parameters.AddWithValue("@p_CustID", contract.CustID);
                        cmd.Parameters.AddWithValue("@p_EmpID", contract.EmpID);
                        cmd.Parameters.AddWithValue("@p_CarID", contract.CarID);
                        cmd.Parameters.AddWithValue("@p_StartDate", contract.StartDate);
                        cmd.Parameters.AddWithValue("@p_ReturnDate", contract.ReturnDate);
                        cmd.Parameters.AddWithValue("@p_DaysRented", contract.DaysRented);
                        cmd.Parameters.AddWithValue("@p_StartMileage", contract.StartMileage);
                        cmd.Parameters.AddWithValue("@p_Status", contract.Status);

                        // Deposit parameters
                        cmd.Parameters.AddWithValue("@p_DepositAmount", deposit.Amount);
                        cmd.Parameters.AddWithValue("@p_DepositStatus", deposit.Status);

                        // Billing parameters
                        cmd.Parameters.AddWithValue("@p_PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@p_BaseRate", baseRate);
                        cmd.Parameters.AddWithValue("@p_CustomerName", customerName);

                        // Output parameter
                        var outParam = new MySqlParameter("@p_NewContractID", MySqlDbType.Int64)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        // Execute
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected <= 0)
                            throw new Exception("No rows were inserted. Check stored procedure or input parameters.");

                        // Commit the transaction
                        transaction.Commit();

                        // Get the new ContractID
                        if (outParam.Value != DBNull.Value)
                            newContractID = Convert.ToInt64(outParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                        // ignore rollback errors
                    }

                    throw new Exception("Error creating contract: " + ex.Message, ex);
                }
                finally
                {
                    _db.Close();
                }
            }

            return newContractID;
        }

        public List<Contracts> GetActiveContractCustomers()
        {
            List<Contracts> list = new List<Contracts>();
            _db.Open();

            using (var cmd = new MySqlCommand("GetActiveContractCustomers", _db.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Contracts
                        {
                            ContractID = reader.GetInt64("ContractID"),
                            CustID = reader.GetInt64("CustID"),
                            CustomerName = reader.GetString("CustomerName"),
                            CarName = reader.GetString("CarName"),
                            EmployeeName = reader.GetString("EmployeeName"),
                            DepositAmount = reader.IsDBNull(reader.GetOrdinal("DepositAmount"))
                                ? 0 : reader.GetDecimal("DepositAmount"),
                            BaseRate = reader.IsDBNull(reader.GetOrdinal("BaseRate"))
                                ? 0 : reader.GetDecimal("BaseRate")
                        });
                    }
                }
            }

            _db.Close();
            return list;
        }


    }
}
