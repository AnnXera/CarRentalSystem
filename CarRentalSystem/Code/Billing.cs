using CarRentalSystem.Code.Enum;
using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Code
{
    public class Billing
    {
        public long BillingId { get; set; }
        public long ContractId { get; set; }
        public long CustID { get; set; }
        public string CustomerName { get; set; }
        public string CarName { get; set; }
        public decimal BaseRate { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? SecurityDepUsed { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemainingBalance { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime BillingDate { get; set; }
        public string Remarks { get; set; }

        // Add
        public enum_Payment.PaymentMethod PaymentMethod { get; set; }
    }

    public class BillingFactory : IModalFactory<Billing>
    {
        private readonly BillingRepository _repo;
        public BillingFactory()
        {
            _repo = new BillingRepository();
        }

        public long Add(Billing billing)
        {
            throw new NotImplementedException();
        }

        public void Edit(Billing billing)
        {
            throw new NotImplementedException();
        }

        public List<Billing> ViewAll()
        {
            return _repo.ViewAll();
        }
        private Billing _currentBilling;

        public void SetCurrentBilling(Billing billing)
        {
            _currentBilling = billing;
        }

        public bool RecordPayment(Billing payment)
        {
            if (_currentBilling == null) return false;

            decimal newRemaining = _currentBilling.RemainingBalance - payment.AmountPaid;
            string newStatus = newRemaining <= 0 ? "Paid" : "Partially Paid";

            var repo = new BillingRepository();

            bool success = repo.UpdatePayment(
                billingId: payment.BillingId,
                amountToAdd: payment.AmountPaid,
                newRemainingBalance: Math.Max(0, newRemaining),
                paymentStatus: newStatus
            );

            if (success)
            {
                var log = new BillingLog
                {
                    BillingID = payment.BillingId,
                    TransactionDate = payment.BillingDate,
                    PaymentMethod = payment.PaymentMethod.ToString(),
                    TransactionType = "Payment",
                    Amount = payment.AmountPaid,
                    Notes = $"Payment received from {_currentBilling.CustomerName}"
                };
                //repo.SaveToBillingLog(log);  // Optional but recommended
            }

            return success;
        }
    }
}
