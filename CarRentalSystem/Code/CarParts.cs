using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem.Code
{
    public class CarParts
    {
        public long PartID { get; set; }
        public long CarID { get; set; }
        public string PartName { get; set; }
        public decimal ReplacementCost { get; set; }
        public string Status { get; set; }

        public bool IsDamaged
        {
            get { return Status == "Damaged"; }
            set { Status = value ? "Damaged" : "Good"; }
        }

        public int Quantity { get; set; } = 1; // default quantity
    }

    public class CarPartsFactory : IModalFactory<CarParts>
    {
        private readonly CarPartsRepository _repo;

        public CarPartsFactory()
        {
            _repo = new CarPartsRepository();
        }

        public long Add(CarParts entity)
        {
            return _repo.AddCarPart(entity);
        }

        public void Edit(CarParts entity)
        {
            _repo.UpdateCarPart(entity);
        }

        public List<CarParts> ViewAll()
        {
            throw new NotImplementedException();
        }

        public List<CarParts> ViewByCar(long carId)
        {
            return _repo.GetPartsByCarId(carId);
        }
    }
}
