using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class BillingLogRepository
    {
        private readonly SQLDBHelper _db;
        public BillingLogRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long AddDepositToBillingLog(BillingLog billLog, MySqlTransaction transaction = null)
        {
            string sql = @"INSERT INTO BillingLog
                   (BillingID, TransactionDate, PaymentMethod, TransactionType, Amount, Notes)
                   VALUES
                   (@BillingID, @TransactionDate, @PaymentMethod, @TransactionType, @Amount, @Notes);
                   SELECT LAST_INSERT_ID();";
            try
            {
                using (var cmd = new MySqlCommand(sql, _db.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@BillingID", billLog.BillingID);
                    cmd.Parameters.AddWithValue("@TransactionDate", billLog.TransactionDate);
                    cmd.Parameters.AddWithValue("@PaymentMethod", billLog.PaymentMethod);
                    cmd.Parameters.AddWithValue("@TransactionType", billLog.TransactionType);
                    cmd.Parameters.AddWithValue("@Amount", billLog.Amount);
                    cmd.Parameters.AddWithValue("@Notes", billLog.Notes);
                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding billing log: " + ex.Message);
            }
        }


    }
}
