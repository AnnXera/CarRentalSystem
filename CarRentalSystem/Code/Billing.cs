using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Database;

namespace CarRentalSystem.Code
{
    public class Billing
    {
        public long BillingID { get; set; }
        public long ContractID { get; set; }
        public decimal BaseRate { get; set; }
        public decimal TotalCharges { get; set; }
        public decimal SecurityDepUsed { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemainingBalance { get; set; }
        public string PaymentStatus { get; set; } // Pending, Partial, Paid, Refunded
        public DateTime BillingDate { get; set; }
        public string Remarks { get; set; }
    }

    public class BillingFactory : IModalFactory<Billing>
    {
        private readonly BillingRepository _repo;
        public BillingFactory()
        {
            _repo = new BillingRepository();
        }
        public long Add(Billing entity)
        {
            return _repo.AddBilling(entity);
        }
        public long Add(Billing entity, MySql.Data.MySqlClient.MySqlTransaction transaction)
        {
            return _repo.AddBilling(entity, transaction);
        }
        public void Edit(Billing entity)
        {
            throw new NotImplementedException();
        }
        public List<Billing> ViewAll()
        {
            throw new NotImplementedException();
            //return _repo.GetAllBillings();
        }
    }
}
