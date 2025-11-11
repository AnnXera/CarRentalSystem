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
        public decimal CurrentMileage { get; set; }
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

        public void Add(Cars entity)
        {
            _repo.AddCar(entity);
        }

        public void Edit(Cars entity)
        {
            _repo.UpdateCar(entity); 
        }

        public List<Cars> ViewAll()
        {
            return _repo.GetAllCars();
        }

        public long AddAndReturnID(Cars entity)
        {
            try
            {
                return _repo.AddAndReturnID(entity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding car: " + ex.Message);
                return 0;
            }
        }

    }

}
