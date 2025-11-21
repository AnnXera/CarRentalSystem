using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class AdditionalCharges
    {
        public decimal SecurityDeposit { get; set; }
        public decimal SecurityDepUsed { get; set; }
        public DataTable AdditionalChargesTable { get; set; }
    }

    public class AdditionalChargesFactory : IModalFactory<AdditionalCharges>
    {
        private readonly AdditionalChargesRepository _repo;

        public AdditionalChargesFactory()
        {
            _repo = new AdditionalChargesRepository();
        }

        // Factory method to get the breakdown for a contract
        public (decimal PartsTotal, decimal LostTotal, decimal MileageTotal, decimal LateFeeTotal)
            GetChargeBreakdown(long contractId)
        {
            return _repo.GetChargeBreakdown(contractId);
        }

        // Factory method to get detailed charges for a billing
        public AdditionalCharges GetChargesInfo(long billingId)
        {
            return _repo.GetContractChargesInfo(billingId);
        }

        // Required by IModalFactory but not meaningful in this context
        public long Add(AdditionalCharges entity)
        {
            throw new NotImplementedException("AdditionalCharges are generated from repositories; no direct add.");
        }

        public void Edit(AdditionalCharges entity)
        {
            throw new NotImplementedException("Editing AdditionalCharges directly is not supported.");
        }

        public List<AdditionalCharges> ViewAll()
        {
            throw new NotImplementedException("Viewing all AdditionalCharges is not implemented.");
        }
    }
}
