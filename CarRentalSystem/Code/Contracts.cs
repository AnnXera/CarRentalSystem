using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class Contracts
    {
        public long ContractID { get; set; }
        public long CustID { get; set; }
        public long EmpID { get; set; }
        public long CarID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int DaysRented { get; set; }
        public long StartMileage { get; set; }
        public long? EndMileage { get; set; }

        public string Status { get; set; }
    }

    public class ContractFactory : IModalFactory<Contracts>
    {
        private readonly Contract_Repository _repo;

        public ContractFactory()
        {
            _repo = new Contract_Repository();
        }

        public long Add(Contracts entity)
        {
            return _repo.CreateContract(entity);
        }

        public void Edit(Contracts entity)
        {
            throw new NotImplementedException();
        }

        public List<Contracts> ViewAll()
        {
            throw new NotImplementedException();

            //return _repo.GetAllCars();
        }
    }
}
