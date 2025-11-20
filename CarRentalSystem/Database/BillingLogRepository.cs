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

        public List<BillingLog> GetAllBillingLogs()
        {
            var logs = new List<BillingLog>();

            try
            {
                _db.Open();
                string sql = @"
                    SELECT bl.BillLogID, bl.BillingID, bl.TransactionDate, bl.PaymentMethod, bl.TransactionType, bl.Amount, bl.Notes
                    FROM billinglog bl
                    JOIN billing b ON bl.BillingID = b.BillingID
                    ORDER BY bl.TransactionDate DESC;";

                using (var cmd = new MySqlCommand(sql, _db.Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add(new BillingLog
                        {
                            BillLogID = reader.GetInt64("BillLogID"),
                            BillingID = reader.GetInt64("BillingID"),
                            TransactionDate = reader.GetDateTime("TransactionDate"),
                            PaymentMethod = reader.GetString("PaymentMethod"),
                            TransactionType = reader.GetString("TransactionType"),
                            Amount = reader.GetDecimal("Amount"),
                            Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? "" : reader.GetString("Notes")
                        });
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return logs;
        }

        public decimal GetRevenueMTD()
        {
            decimal revenue = 0m;
            try
            {
                _db.Open();
                string sql = @"
                    SELECT IFNULL(SUM(Amount), 0) 
                    FROM billinglog bl
                    JOIN billing b ON bl.BillingID = b.BillingID
                    JOIN contracts c ON b.ContractID = c.ContractID
                    WHERE bl.TransactionType = 'Payment'
                      AND bl.TransactionDate >= DATE_FORMAT(CURDATE(), '%Y-%m-01')
                      AND bl.TransactionDate < CURDATE() + INTERVAL 1 DAY;";

                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    revenue = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            finally
            {
                _db.Close();
            }

            return revenue;
        }

        public decimal GetAvgDailyRate()
        {
            decimal avgRate = 0m;
            try
            {
                _db.Open();
                string sql = @"
                    SELECT 
                        IFNULL(SUM(bl.Amount) / SUM(DATEDIFF(c.ReturnDate, c.StartDate) + 1), 0) AS AvgDailyRate
                    FROM billinglog bl
                    JOIN billing b ON bl.BillingID = b.BillingID
                    JOIN contracts c ON b.ContractID = c.ContractID
                    WHERE bl.TransactionType = 'Payment'
                      AND c.Status IN ('Completed', 'Active')
                      AND MONTH(c.StartDate) = MONTH(CURDATE())
                      AND YEAR(c.StartDate) = YEAR(CURDATE());";

                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    avgRate = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            finally
            {
                _db.Close();
            }

            return avgRate;
        }


    }
}
