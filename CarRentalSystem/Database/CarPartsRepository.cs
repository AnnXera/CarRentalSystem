using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class CarPartsRepository
    {
        private readonly SQLDBHelper _db;

        public CarPartsRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public void AddCarPart(CarParts part)
        {
            string query = @"INSERT INTO CarParts (CarID, PartName, ReplacementCost, Status)
                     VALUES (@CarID, @PartName, @ReplacementCost, @Status)";
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", part.CarID);
                    cmd.Parameters.AddWithValue("@PartName", part.PartName);
                    cmd.Parameters.AddWithValue("@ReplacementCost", part.ReplacementCost);
                    cmd.Parameters.AddWithValue("@Status", part.Status);
                    cmd.ExecuteNonQuery();
                }
            }
            finally { _db.Close(); }
        }

        public void UpdateCarPart(CarParts part)
        {
            string query = @"UPDATE CarParts 
                     SET PartName = @PartName, ReplacementCost = @ReplacementCost, Status = @Status
                     WHERE PartsID = @PartsID";
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@PartName", part.PartName);
                    cmd.Parameters.AddWithValue("@ReplacementCost", part.ReplacementCost);
                    cmd.Parameters.AddWithValue("@Status", part.Status);
                    cmd.Parameters.AddWithValue("@PartsID", part.PartID);
                    cmd.ExecuteNonQuery();
                }
            }
            finally { _db.Close(); }
        }

        public void DeleteCarPart(long partId)
        {
            string query = "DELETE FROM CarParts WHERE PartsID = @PartID";
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@PartID", partId);
                    cmd.ExecuteNonQuery();
                }
            }
            finally { _db.Close(); }
        }

        public List<CarParts> GetPartsByCarId(long carId)
        {
            var parts = new List<CarParts>();
            string query = "SELECT * FROM CarParts WHERE CarID = @CarID;";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(query, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            parts.Add(new CarParts
                            {
                                PartID = reader.GetInt64("PartsID"),
                                CarID = reader.GetInt64("CarID"),
                                PartName = reader.GetString("PartName"),
                                ReplacementCost = reader.GetDecimal("ReplacementCost"),
                                Status = reader.GetString("Status")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving car parts: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return parts;
        }
    }
}
