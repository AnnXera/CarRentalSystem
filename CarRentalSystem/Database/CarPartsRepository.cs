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

        public long AddCarPart(CarParts part)
        {
            long newId = -1;
            _db.Open();

            using (var cmd = new MySqlCommand("AddCarPart", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_CarID", part.CarID);
                cmd.Parameters.AddWithValue("@p_PartName", part.PartName);
                cmd.Parameters.AddWithValue("@p_ReplacementCost", part.ReplacementCost);
                cmd.Parameters.AddWithValue("@p_Status", part.Status);

                var outParam = new MySqlParameter("@p_NewPartID", MySqlDbType.Int64)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();
                newId = Convert.ToInt64(outParam.Value);
            }

            _db.Close();
            return newId;
        }

        public void UpdateCarPart(CarParts part)
        {
            _db.Open();

            using (var cmd = new MySqlCommand("UpdateCarPart", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_PartsID", part.PartID);
                cmd.Parameters.AddWithValue("@p_PartName", part.PartName);
                cmd.Parameters.AddWithValue("@p_ReplacementCost", part.ReplacementCost);
                cmd.Parameters.AddWithValue("@p_Status", part.Status);

                cmd.ExecuteNonQuery();
            }

            _db.Close();
        }

        public List<CarParts> GetPartsByCarId(long carId)
        {
            var parts = new List<CarParts>();
            _db.Open();

            using (var cmd = new MySqlCommand("GetPartsByCarId", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_CarID", carId);

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

            _db.Close();
            return parts;
        }
    }
}
