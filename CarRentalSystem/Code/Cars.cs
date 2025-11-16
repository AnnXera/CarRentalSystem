using CarRentalSystem.Code;
using CarRentalSystem.Database;
using CarRentalSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Code
{
    public class Cars
    {
        public long CarID { get; set; }
        public long PlanID { get; set; }           // match DB
        public string PlanName { get; set; }       // from RentalPlans table
        public byte[] CarPicture { get; set; }     // match DB
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string CarDescription { get; set; }
        public int Seats { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
        public string EngineType { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public long CurrentMileage { get; set; }
        public decimal ReplacementValue { get; set; }
        public string Status { get; set; }
    }

    public class CarFactory : IModalFactory<Cars>
    {
        private readonly CarRepository _repo;

        public CarFactory()
        {
            _repo = new CarRepository();
        }

        public long Add(Cars entity)
        {
            return _repo.AddCar(entity);
        }

        public void Edit(Cars entity)
        {
            _repo.UpdateCar(entity); 
        }

        public List<Cars> ViewAll()
        {
            return _repo.GetAllCars();
        }

        public void UpdateStatus(long carId, string status, MySql.Data.MySqlClient.MySqlTransaction transaction = null)
        {
            _repo.UpdateStatus(carId, status, transaction);
        }

    }

}
