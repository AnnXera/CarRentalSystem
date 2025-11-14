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
                            CurrentMileage = reader.GetDecimal("CurrentMileage"),
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
                                CurrentMileage = reader.GetDecimal("CurrentMileage"),
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
            string query = @"
                        INSERT INTO Car
                            (PlanID, CarPicture, VIN, PlateNumber, Brand, Model, Year,
                             Transmission, Seats, EngineType, FuelType, CurrentMileage,
                             ReplacementValue, Status)
                        VALUES
                            (@PlanID, @CarPicture, @VIN, @PlateNumber, @Brand, @Model, @Year,
                             @Transmission, @Seats, @EngineType, @FuelType, @CurrentMileage,
                             @ReplacementValue, @Status);
                        SELECT LAST_INSERT_ID();";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
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
                    cmd.Parameters.AddWithValue("@Status", car.Status);

                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding car: " + ex.Message);
                return -1;
            }
            finally
            {
                _db.Close();
            }
        }

        public void UpdateCar(Cars car)
        {
            string query = @"
                    UPDATE Car
                    SET 
                        PlanID = @PlanID,
                        CarPicture = @CarPicture,
                        VIN = @VIN,
                        PlateNumber = @PlateNumber,
                        Brand = @Brand,
                        Model = @Model,
                        Year = @Year,
                        Transmission = @Transmission,
                        Seats = @Seats,
                        EngineType = @EngineType,
                        FuelType = @FuelType,
                        CurrentMileage = @CurrentMileage,
                        ReplacementValue = @ReplacementValue,
                        Status = @Status
                    WHERE CarID = @CarID;";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", car.CarID);
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
                    cmd.Parameters.AddWithValue("@Status", car.Status);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Car updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating car: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }
        }

        public long AddAndReturnID(Cars car)
        {
            string query = @"
                        INSERT INTO Car
                            (PlanID, CarPicture, VIN, PlateNumber, Brand, Model, Year, 
                             Transmission, Seats, EngineType, FuelType, CurrentMileage, 
                             ReplacementValue, Status)
                        VALUES
                            (@PlanID, @CarPicture, @VIN, @PlateNumber, @Brand, @Model, @Year,
                             @Transmission, @Seats, @EngineType, @FuelType, @CurrentMileage,
                             @ReplacementValue, @Status);
                        SELECT LAST_INSERT_ID();";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
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
                    cmd.Parameters.AddWithValue("@Status", car.Status);

                    var newId = cmd.ExecuteScalar();
                    return Convert.ToInt64(newId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding car: " + ex.Message);
                return 0;
            }
            finally
            {
                _db.Close();
            }
        }

        public void UpdateCarStatus(long carId, string status)
        {
            string query = @"UPDATE Car SET Status = @Status WHERE CarID = @CarID;";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating car status: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }
        }


    }
}
