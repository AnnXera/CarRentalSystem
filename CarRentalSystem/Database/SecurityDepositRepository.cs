using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class SecurityDepositRepository
    {
        private readonly SQLDBHelper _db;

        public SecurityDepositRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long AddSecurityDeposit(SecurityDeposit deposit, MySqlTransaction transaction = null)
        {
            string sql = @"INSERT INTO SecurityDeposit 
                   (ContractID, DepositAmount, Status, DepositDate)
                   VALUES (@ContractID, @Amount, @Status, @DepositDate);
                   SELECT LAST_INSERT_ID();";
            try
            {
                using (var cmd = new MySqlCommand(sql, _db.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@ContractID", deposit.ContractID);
                    cmd.Parameters.AddWithValue("@Amount", deposit.Amount);
                    cmd.Parameters.AddWithValue("@Status", deposit.Status);
                    cmd.Parameters.AddWithValue("@DepositDate", deposit.DepositDate);

                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding security deposit: " + ex.Message);
            }
        }

    }
}
