using System;
using System.Collections.Generic;
using CarRentalSystem.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class SecurityDeposit
    {
        public long DepositID { get; set; }
        public long ContractID { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime DepositDate { get; set; }
    }

    public class SecurityDepositFactory : IModalFactory<SecurityDeposit>
    {
        private readonly SecurityDepositRepository _repo;
        public SecurityDepositFactory()
        {
            _repo = new SecurityDepositRepository();
        }

        public long Add(SecurityDeposit entity)
        {
            return _repo.AddSecurityDeposit(entity);
        }

        public void Edit(SecurityDeposit entity)
        {
            throw new NotImplementedException();
        }

        public List<SecurityDeposit> ViewAll()
        {
            throw new NotImplementedException();

            //return _repo.GetAllCars();
        }
    }
}
