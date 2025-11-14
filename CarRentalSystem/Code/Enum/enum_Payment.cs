using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.WindowsForm;

namespace CarRentalSystem.Code.Enum
{
    public class enum_Payment
    {
        public enum  PaymentMethod
        {
            Cash,
            Card,
            EWallet
        }

        public enum PaymentStatus
        {
            Pending,
            Completed,
            Partial,
            Refunded
        }

        public enum TransactionType
        {
            Payment,
            Deposit,
            Refund
        }

        public enum SecurityDepositStatus
        {
            Held,
            Refunded,
            Forfeited
        }
    }
}
