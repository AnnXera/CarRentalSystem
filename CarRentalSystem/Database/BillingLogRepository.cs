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

        public bool UpdatePayment(long billingId, decimal amountToAdd, decimal newRemainingBalance, string paymentStatus)
        {
            try
            {
                _db.Open();
                string query = @"
                UPDATE billing 
                SET AmountPaid = AmountPaid + @AmountToAdd,
                RemainingBalance = @NewRemaining,
                PaymentStatus = @PaymentStatus,
                BillingDate = NOW()
                WHERE BillingID = @BillingID";

                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AmountToAdd", amountToAdd);
                    cmd.Parameters.AddWithValue("@NewRemaining", newRemainingBalance);
                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    cmd.Parameters.AddWithValue("@BillingID", billingId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;  // ← Returns true ONLY if database was actually updated
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Update Failed: " + ex.Message);
                return false;
            }
            finally
            {
                _db.Close();
            }
        }
    }
}
