using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code.Enum
{
    public class enum_Car
    {
        public enum TransmissionType
        {
            Automatic,
            Manual
        }

        public enum FuelType
        {
            Gasoline,
            Diesel,
            Hybrid,
            Electric
        }

        public enum CarStatus
        {
            Available,
            Rented,
            Maintenance,
            Lost
        }

        public enum CarBrand
        {
            Toyota,
            Chevrolet,
            Honda,
            Ford,
            Nissan,
            Hyundai,
            Mitsubishi,
            Suzuki,
            Kia,
            BMW,
            MercedesBenz,
            Audi,
            Volkswagen,
            Isuzu,
            Mazda
        }

        public enum SeatCount
        {
            Two = 2,
            Four = 4,
            Five = 5,
            Seven = 7,
            Eight = 8,
            Ten = 10
        }

        public enum CarPartStatus
        {
            Good,
            Damaged,
            Replaced
        }

    }
}
