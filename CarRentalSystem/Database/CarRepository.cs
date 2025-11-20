using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CarRentalSystem.Code;

namespace CarRentalSystem.Database
{
    internal class CarRepository
    {
        private readonly SQLDBHelper _db;

        public CarRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public List<Cars> GetAllCars()
        {
            var cars = new List<Cars>();

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("GetAllCars", _db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var car = new Cars
                            {
                                CarID = reader.GetInt64("CarID"),
                                PlanID = reader.GetInt64("PlanID"),
                                PlanName = reader.IsDBNull(reader.GetOrdinal("PlanName")) ? "" : reader.GetString("PlanName"),
                                CarPicture = reader.IsDBNull(reader.GetOrdinal("CarPicture")) ? null : (byte[])reader["CarPicture"],
                                Brand = reader.GetString("Brand"),
                                Model = reader.GetString("Model"),
                                Year = reader.GetInt32("Year"),
                                Seats = reader.GetInt32("Seats"),
                                PlateNumber = reader.GetString("PlateNumber"),
                                VIN = reader.GetString("VIN"),
                                EngineType = reader.GetString("EngineType"),
                                FuelType = reader.GetString("FuelType"),
                                Transmission = reader.GetString("Transmission"),
                                CurrentMileage = reader.GetInt64("CurrentMileage"),
                                ReplacementValue = reader.GetDecimal("ReplacementValue"),
                                Status = reader.GetString("Status")
                            };

                            car.CarDescription = $"{car.Year} {car.Brand} {car.Model}";
                            cars.Add(car);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return cars;
        }

        public Cars GetCarById(long carId)
        {
            Cars car = null;

            string query = @"
                    SELECT c.*, rp.PlanName
                    FROM Car c
                    LEFT JOIN RentalPlans rp ON c.PlanID = rp.PlanID
                    WHERE c.CarID = @CarID;";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            car = new Cars
                            {
                                CarID = reader.GetInt64("CarID"),
                                PlanID = reader.GetInt64("PlanID"),
                                PlanName = reader.IsDBNull(reader.GetOrdinal("PlanName")) ? "" : reader.GetString("PlanName"),
                                CarPicture = reader.IsDBNull(reader.GetOrdinal("CarPicture")) ? null : (byte[])reader["CarPicture"],
                                Brand = reader.GetString("Brand"),
                                Model = reader.GetString("Model"),
                                Year = reader.GetInt32("Year"),
                                Seats = reader.GetInt32("Seats"),
                                PlateNumber = reader.GetString("PlateNumber"),
                                VIN = reader.GetString("VIN"),
                                EngineType = reader.GetString("EngineType"),
                                FuelType = reader.GetString("FuelType"),
                                Transmission = reader.GetString("Transmission"),
                                CurrentMileage = reader.GetInt64("CurrentMileage"),
                                ReplacementValue = reader.GetDecimal("ReplacementValue"),
                                Status = reader.GetString("Status"),
                            };

                            car.CarDescription = $"{car.Year} {car.Brand} {car.Model}";
                        }
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return car;
        }

        public long AddCar(Cars car)
        {
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = _db.Connection;

                    // Inline query with Status explicitly set to 'Available'
                    cmd.CommandText = @"
                INSERT INTO Car
                    (PlanID, CarPicture, VIN, PlateNumber, Brand, Model, Year,
                     Transmission, Seats, EngineType, FuelType, CurrentMileage,
                     ReplacementValue, Status)
                VALUES
                    (@PlanID, @CarPicture, @VIN, @PlateNumber, @Brand, @Model, @Year,
                     @Transmission, @Seats, @EngineType, @FuelType, @CurrentMileage,
                     @ReplacementValue, 'Available');
                SELECT LAST_INSERT_ID();
            ";

                    cmd.Parameters.AddWithValue("@PlanID", car.PlanID);
                    cmd.Parameters.AddWithValue("@CarPicture", car.CarPicture ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VIN", car.VIN);
                    cmd.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
                    cmd.Parameters.AddWithValue("@Brand", car.Brand);
                    cmd.Parameters.AddWithValue("@Model", car.Model);
                    cmd.Parameters.AddWithValue("@Year", car.Year);
                    cmd.Parameters.AddWithValue("@Transmission", car.Transmission);
                    cmd.Parameters.AddWithValue("@Seats", car.Seats);
                    cmd.Parameters.AddWithValue("@EngineType", car.EngineType);
                    cmd.Parameters.AddWithValue("@FuelType", car.FuelType);
                    cmd.Parameters.AddWithValue("@CurrentMileage", car.CurrentMileage);
                    cmd.Parameters.AddWithValue("@ReplacementValue", car.ReplacementValue);

                    // ExecuteScalar returns the last inserted ID
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt64(result);
                }
            }
            finally
            {
                _db.Close();
            }
        }

        public void UpdateCar(Cars car)
        {
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("UpdateCar", _db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_CarID", car.CarID);
                    cmd.Parameters.AddWithValue("@p_PlanID", car.PlanID);
                    cmd.Parameters.AddWithValue("@p_CarPicture", car.CarPicture ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_VIN", car.VIN);
                    cmd.Parameters.AddWithValue("@p_PlateNumber", car.PlateNumber);
                    cmd.Parameters.AddWithValue("@p_Brand", car.Brand);
                    cmd.Parameters.AddWithValue("@p_Model", car.Model);
                    cmd.Parameters.AddWithValue("@p_Year", car.Year);
                    cmd.Parameters.AddWithValue("@p_Transmission", car.Transmission);
                    cmd.Parameters.AddWithValue("@p_Seats", car.Seats);
                    cmd.Parameters.AddWithValue("@p_EngineType", car.EngineType);
                    cmd.Parameters.AddWithValue("@p_FuelType", car.FuelType);
                    cmd.Parameters.AddWithValue("@p_ReplacementValue", car.ReplacementValue);
                    cmd.Parameters.AddWithValue("@p_Status", car.Status);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _db.Close();
            }
        }

        public int GetAvailableCarsToday()
        {
            int count = 0;

            string query = @"
                SELECT COUNT(*) AS AvailableCars
                FROM Car c
                WHERE c.Status = 'Available'
                AND c.CarID NOT IN (
                        SELECT ct.CarID
                        FROM Contracts ct
                        WHERE CURDATE() BETWEEN ct.StartDate AND ct.ReturnDate
                        AND ct.Status = 'Active')";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return count;
        }

        public decimal GetFleetUtilization()
        {
            decimal utilization = 0m;

            try
            {
                _db.Open();
                string sql = @"
                    SELECT 
                        COUNT(DISTINCT ct.CarID) AS RentedCars,
                        (SELECT COUNT(*) FROM car) AS TotalCars
                    FROM contracts ct
                    WHERE (ct.Status = 'Completed' OR ct.Status = 'Active')
                      AND CURDATE() BETWEEN ct.StartDate AND ct.ReturnDate;
                ";

                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int rentedCars = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            int totalCars = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            if (totalCars > 0)
                                utilization = ((decimal)rentedCars / totalCars) * 100m;
                        }
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return Math.Round(utilization, 2);
        }
    }
}
