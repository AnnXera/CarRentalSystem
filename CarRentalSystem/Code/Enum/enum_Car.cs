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
            Manual,
            CVT
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

    }
}
