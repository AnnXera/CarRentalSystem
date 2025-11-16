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

            string query = @"
                SELECT 
                    c.CarID,
                    c.PlanID,
                    rp.PlanName,
                    c.CarPicture,
                    c.Brand,
                    c.Model,
                    c.Year,
                    c.Seats,
                    c.PlateNumber,
                    c.VIN,
                    c.EngineType,
                    c.FuelType,
                    c.Transmission,
                    c.CurrentMileage,
                    c.ReplacementValue,
                    c.Status
                FROM Car c
                LEFT JOIN RentalPlans rp ON c.PlanID = rp.PlanID;
            ";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
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
                            Status = reader.GetString("Status"),
                        };

                        // Combine Year + Brand + Model
                        car.CarDescription = $"{car.Year} {car.Brand} {car.Model}";

                        cars.Add(car);
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
                using (var cmd = new MySqlCommand("AddCar", _db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
                    cmd.Parameters.AddWithValue("@p_CurrentMileage", car.CurrentMileage);
                    cmd.Parameters.AddWithValue("@p_ReplacementValue", car.ReplacementValue);
                    cmd.Parameters.AddWithValue("@p_Status", car.Status);

                    var outParam = new MySqlParameter("@p_NewCarID", MySqlDbType.Int64)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();
                    return (long)outParam.Value;
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
                    cmd.Parameters.AddWithValue("@p_CurrentMileage", car.CurrentMileage);
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

        public void UpdateStatus(long carId, string status, MySqlTransaction transaction = null)
        {
            string sql = "UPDATE Car SET Status = @Status WHERE CarID = @CarID";
            using (var cmd = new MySqlCommand(sql, _db.Connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CarID", carId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
