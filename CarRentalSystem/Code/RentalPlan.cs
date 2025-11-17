using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class RentalPlan
    {
        public long PlanID { get; set; }
        public string PlanName { get; set; }
        public long? MileageLimitPerDay { get; set; }
        public decimal ExcessFeePerKm { get; set; }
        public decimal DailyRate { get; set; }
        public string Description { get; set; }
    }

    public class RentalPlanFactory : IModalFactory<RentalPlan>
    {
        private readonly RentalPlanRepository _repo;

        public RentalPlanFactory()
        {
            _repo = new RentalPlanRepository();
        }

        public List<RentalPlan> ViewAll()
        {
            return _repo.GetAllPlans();
        }

        public long Add(RentalPlan rentalPlan)
        {
            return _repo.AddRentalPlan(rentalPlan);
        }

        public void Edit(RentalPlan rentalPlan)
        {
            _repo.EditRentalPlan(rentalPlan);
        }

        public void Delete(RentalPlan rentalPlan)
        {
            throw new NotImplementedException();
        }

        public bool CheckPlanName(string planName, long? excludePlanID = null)
        {
            return _repo.IsPlanNameTaken(planName, excludePlanID);
        }
    }
}
