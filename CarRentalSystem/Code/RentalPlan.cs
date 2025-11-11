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
}
