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
    public class BillingRepository
    {
        private readonly SQLDBHelper _db;

        public BillingRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long AddBilling(Billing bill, MySqlTransaction transaction = null)
        {
            string sql = @"INSERT INTO Billing 
                   (ContractID, BaseRate, TotalCharges, SecurityDepUsed, TotalAmount, AmountPaid, RemainingBalance, PaymentStatus, BillingDate, Remarks)
                   VALUES (@ContractID, @BaseRate, @TotalCharges, @SecurityDepUsed, @TotalAmount, @AmountPaid, @RemainingBalance, @PaymentStatus, @BillingDate, @Remarks);
                   SELECT LAST_INSERT_ID();";
            try
            {
                using (var cmd = new MySqlCommand(sql, _db.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@ContractID", bill.ContractID);
                    cmd.Parameters.AddWithValue("@BaseRate", bill.BaseRate);
                    cmd.Parameters.AddWithValue("@TotalCharges", bill.TotalCharges);
                    cmd.Parameters.AddWithValue("@SecurityDepUsed", bill.SecurityDepUsed);
                    cmd.Parameters.AddWithValue("@TotalAmount", bill.TotalAmount);
                    cmd.Parameters.AddWithValue("@AmountPaid", bill.AmountPaid);
                    cmd.Parameters.AddWithValue("@RemainingBalance", bill.RemainingBalance);
                    cmd.Parameters.AddWithValue("@PaymentStatus", bill.PaymentStatus);
                    cmd.Parameters.AddWithValue("@BillingDate", bill.BillingDate);
                    cmd.Parameters.AddWithValue("@Remarks", bill.Remarks);

                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding billing record: " + ex.Message);
            }
        }


    }
}
