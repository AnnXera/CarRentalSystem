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

        public void AddDamagedParts(long contractID, List<Tuple<long, int, decimal>> damagedParts)
        {
            if (damagedParts == null || damagedParts.Count == 0) return;

            _db.Open();
            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    foreach (var part in damagedParts)
                    {
                        using (var cmd = new MySqlCommand(@"
                        INSERT INTO additionalcharges (ContractID, ChargeType, Amount, ChargeDate, Notes)
                        VALUES (@ContractID, @ChargeType, @Amount, CURDATE(), @Notes)", _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ContractID", contractID);
                            cmd.Parameters.AddWithValue("@ChargeType", "Damaged Part");
                            cmd.Parameters.AddWithValue("@Amount", part.Item3 * part.Item2); // cost * quantity
                            cmd.Parameters.AddWithValue("@Notes", $"PartID {part.Item1}, Qty {part.Item2}");

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    _db.Close();
                }
            }
        }

        public List<CarParts> ViewByCar(long carID)
        {
            var list = new List<CarParts>();

            _db.Open();
            using (var cmd = new MySqlCommand("SELECT * FROM carparts WHERE CarID = @CarID", _db.Connection))
            {
                cmd.Parameters.AddWithValue("@CarID", carID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CarParts
                        {
                            PartID = reader.GetInt64("PartsID"),
                            PartName = reader.GetString("PartName"),
                            ReplacementCost = reader.GetDecimal("ReplacementCost"),
                            CarID = reader.GetInt64("CarID"),
                            IsDamaged = false
                        });
                    }
                }
            }
            _db.Close();

            return list;
        }

        public void UpdateCarStatusAfterReturn(long carID, bool hasDamagedParts, bool isLost)
        {
            string status = "Available";

            if (isLost)
                status = "Lost";
            else if (hasDamagedParts)
                status = "Maintenance";

            _db.Open();
            using (var cmd = new MySqlCommand("UPDATE car SET Status = @Status WHERE CarID = @CarID", _db.Connection))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.ExecuteNonQuery();
            }
            _db.Close();
        }

        public void UpdatePartStatus(long partId, string status)
        {
            _db.Open();
            using (var cmd = new MySqlCommand("UPDATE carparts SET Status = @Status WHERE PartsID = @PartsID", _db.Connection))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@PartsID", partId);
                cmd.ExecuteNonQuery();
            }
            _db.Close();
        }

        public void AddDamagedParts(long contractID, List<(long PartID, int Quantity, decimal Cost)> damagedParts)
        {
            if (damagedParts == null || damagedParts.Count == 0) return;

            _db.Open();
            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    foreach (var part in damagedParts)
                    {
                        using (var cmd = new MySqlCommand(@"
                    INSERT INTO additionalcharges (ContractID, PartsID, ChargeType, Amount, Quantity, ChargeDate, Notes)
                    VALUES (@ContractID, @PartsID, @ChargeType, @Amount, @Quantity, CURDATE(), @Notes)", _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ContractID", contractID);
                            cmd.Parameters.AddWithValue("@PartsID", part.PartID); // Add FK reference
                            cmd.Parameters.AddWithValue("@ChargeType", "Part Damage");
                            cmd.Parameters.AddWithValue("@Amount", part.Cost * part.Quantity);
                            cmd.Parameters.AddWithValue("@Quantity", part.Quantity);
                            cmd.Parameters.AddWithValue("@Notes", $"PartID {part.PartID}, Qty {part.Quantity}");

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    _db.Close();
                }
            }
        }



    }
}
