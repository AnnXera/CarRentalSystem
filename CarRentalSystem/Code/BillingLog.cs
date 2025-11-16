using CarRentalSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class BillingLog
    {
        public long BillLogID { get; set; }
        public long BillingID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PaymentMethod { get; set; } // Cash, Card, EWallet
        public string TransactionType { get; set; } // Payment, Refund, Deposit
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}
