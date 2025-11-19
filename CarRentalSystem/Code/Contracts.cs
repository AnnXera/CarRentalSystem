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
        // CONTRACT
        public long ContractID { get; set; }
        public long CustID { get; set; }
        public long EmpID { get; set; }
        public long CarID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public long DaysRented { get; set; }
        public DateTime? DateProcessed { get; set; }
        public bool IsOverdue { get; set; }
        public long StartMileage { get; set; }
        public long? EndMileage { get; set; }
        public string Status { get; set; }

        // CUSTOMER
        public string CustomerName { get; set; }
        public byte[] DriversLicensePic { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // EMPLOYEE
        public string EmployeeName { get; set; }

        // CAR
        public string CarName { get; set; }
        public byte[] CarPicture { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
        public decimal ReplacementValue { get; set; }

        // RENTAL PLAN
        public long PlanID { get; set; }
        public string PlanName { get; set; }
        public long MileageLimit { get; set; }
        public decimal ExcessFeePerKm { get; set; }
        public decimal DailyRate { get; set; }
        public string PlanDescription { get; set; }

        // SECURITY DEPOSIT
        public decimal DepositAmount { get; set; }
        public string DepositStatus { get; set; }
        public DateTime? DepositDate { get; set; }

        // BILLING
        public decimal? BaseRate { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? SecurityDepUsed { get; set; }
        public decimal? TotalAmount { get; set; }
        public string PaymentStatus { get; set; }

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

        public List<Contracts> GetActiveContracts()
        {
            return _repo.GetActiveContractCustomers();
        }
    }
}
