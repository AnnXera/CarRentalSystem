using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class BillingRepository
    {
        private readonly SQLDBHelper _db;

        public BillingRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public void EditBilling()
        {

        }

        public List<Billing>ViewAll()
        {
            var billingList = new List<Billing>();

            try
            {
                _db.Open();

                string query = @"
                    SELECT 
                        b.BillingID,
                        b.ContractID,
                        con.CustID,
                        c.FullName AS CustomerName,
                        CONCAT(car.Year, ' ', car.Brand, ' ', car.Model) AS CarName,
                        con.Status AS ContractStatus,
                        b.BaseRate,
                        b.TotalCharges,
                        b.SecurityDepUsed,
                        b.TotalAmount,
                        b.AmountPaid,
                        b.RemainingBalance,
                        b.PaymentStatus,
                        b.BillingDate,
                        b.Remarks
                    FROM billing b
                    JOIN contracts con ON b.ContractID = con.ContractID
                    JOIN customers c ON con.CustID = c.CustID
                    JOIN car ON con.CarID = car.CarID  
                    ORDER BY b.BillingDate DESC;
                ";

                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bill = new Billing
                            {
                                BillingId = reader.GetInt64("BillingID"),
                                ContractId = reader.GetInt64("ContractID"),
                                CustID = reader.GetInt64("CustID"),
                                CustomerName = reader.GetString("CustomerName"),
                                CarName = reader.GetString("CarName"),
                                ContractStatus = reader.GetString("ContractStatus"),
                                BaseRate = reader.GetDecimal("BaseRate"),
                                TotalCharges = reader.IsDBNull(reader.GetOrdinal("TotalCharges")) ? 0 : reader.GetDecimal("TotalCharges"),
                                SecurityDepUsed = reader.IsDBNull(reader.GetOrdinal("SecurityDepUsed")) ? 0 : reader.GetDecimal("SecurityDepUsed"),
                                TotalAmount = reader.GetDecimal("TotalAmount"),
                                AmountPaid = reader.GetDecimal("AmountPaid"),
                                RemainingBalance = reader.GetDecimal("RemainingBalance"),
                                PaymentStatus = reader.GetString("PaymentStatus"),
                                BillingDate = reader.GetDateTime("BillingDate"),
                                Remarks = reader.IsDBNull(reader.GetOrdinal("Remarks")) ? "" : reader.GetString("Remarks")
                            };

                            billingList.Add(bill);
                        }
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return billingList;
        }

        public void UpdateBillingPayment(long billingId, decimal amountPaid, string paymentMethod, string transactionType = "Payment", string notes = "")
        {
            try
            {
                _db.Open();

                using (var transaction = _db.Connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update billing
                        string updateBillingQuery = @"
                            UPDATE billing
                            SET AmountPaid = AmountPaid + @AmountPaid,
                                RemainingBalance = TotalAmount - (AmountPaid + @AmountPaid),
                                PaymentStatus = CASE 
                                    WHEN TotalAmount - (AmountPaid + @AmountPaid) <= 0 THEN 'Paid'
                                    WHEN AmountPaid + @AmountPaid > 0 THEN 'Partial'
                                    ELSE 'Pending'
                                END
                            WHERE BillingID = @BillingID;
                        ";

                        using (var cmd = new MySqlCommand(updateBillingQuery, _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                            cmd.Parameters.AddWithValue("@BillingID", billingId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Insert into billing log
                        string insertLogQuery = @"
                            INSERT INTO billinglog
                            (BillingID, TransactionDate, PaymentMethod, TransactionType, Amount, Notes)
                            VALUES
                            (@BillingID, NOW(), @PaymentMethod, @TransactionType, @Amount, @Notes);
                        ";

                        using (var cmd = new MySqlCommand(insertLogQuery, _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@BillingID", billingId);
                            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            cmd.Parameters.AddWithValue("@TransactionType", transactionType);
                            cmd.Parameters.AddWithValue("@Amount", amountPaid);
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit if all went well
                        transaction.Commit();
                    }
                    catch
                    {
                        // Rollback if any error occurs
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            finally
            {
                _db.Close();
            }
        }


    }
}
