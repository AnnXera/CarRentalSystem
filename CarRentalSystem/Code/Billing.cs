using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
