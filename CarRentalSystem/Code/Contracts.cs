using CarRentalSystem.Database;
using MySql.Data.MySqlClient;
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
        public string CustName { get; set; }
        public long EmpID { get; set; }
        public string EmpName { get; set; }
        public long CarID { get; set; }
        public string CarName { get; set; }

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

        public long Add(Contracts entity, SecurityDeposit deposit, decimal baseRate, string paymentMethod, string customerName)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            if (deposit == null)
                throw new ArgumentNullException(nameof(deposit));

            return _repo.CreateContract(entity, deposit, baseRate, paymentMethod, customerName);
        }

        public long Add(Contracts entity)
        {
            throw new NotImplementedException("Use the Add method with deposit, baseRate, paymentMethod, and customerName.");
        }

        public void Edit(Contracts entity)
        {
            throw new NotImplementedException();
        }

        public List<Contracts> ViewAll()
        {
            return _repo.GetAllContracts();
        }
    }

}
