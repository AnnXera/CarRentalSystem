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

        public long AddSecurityDeposit(SecurityDeposit deposit)
        {
            string sql = @"
                INSERT INTO SecurityDeposit 
                    (ContractID, DepositAmount, Status, DepositDate)
                VALUES 
                    (@ContractID, @Amount, @Status, @DepositDate);
                SELECT LAST_INSERT_ID();";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ContractID", deposit.ContractID);
                    cmd.Parameters.AddWithValue("@Amount", deposit.Amount);
                    cmd.Parameters.AddWithValue("@Status", deposit.Status);
                    cmd.Parameters.AddWithValue("@DepositDate", deposit.DepositDate.Date); // only date portion

                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt64(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding security deposit: " + ex.Message);
                return -1;
            }
            finally
            {
                _db.Close();
            }
        }
    }
}
