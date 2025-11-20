using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class AdditionalCharges
    {
        public long ChargeID { get; set; }
        public long PartID { get; set; }
        public long ContractID { get; set; }
        public string ChargeType { get; set; }
        public decimal Amount  { get; set; }
        public int Quantity { get; set; }
        public DateTime ChargeDate { get; set; }
        public string Notes { get; set; }
    }
}
