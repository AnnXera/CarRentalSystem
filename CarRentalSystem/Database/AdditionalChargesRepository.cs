using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class AdditionalChargesRepository
    {
        private readonly SQLDBHelper _db;

        public AdditionalChargesRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public (decimal PartsTotal, decimal LostTotal, decimal MileageTotal, decimal LateFeeTotal)
        GetChargeBreakdown(long contractId)
        {
            decimal partsTotal = 0m;
            decimal lostTotal = 0m;
            decimal mileageTotal = 0m;
            decimal lateFeeTotal = 0m;

            _db.Open();

            string query = @"
                SELECT 
                    ChargeType,
                    IFNULL(SUM(Amount * IFNULL(Quantity, 1)), 0) AS TotalAmount
                FROM additionalcharges
                WHERE ContractID = @ContractID
                GROUP BY ChargeType;
            ";

            using (var cmd = new MySqlCommand(query, _db.Connection))
            {
                cmd.Parameters.AddWithValue("@ContractID", contractId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string chargeType = reader["ChargeType"].ToString();
                        decimal amount = Convert.ToDecimal(reader["TotalAmount"]);

                        switch (chargeType)
                        {
                            case "Part Damage":
                                partsTotal = amount;
                                break;

                            case "Lost":
                                lostTotal = amount;
                                break;

                            case "Exceed Mileage":
                                mileageTotal = amount;
                                break;

                            case "LateFee":
                                lateFeeTotal = amount;
                                break;
                        }
                    }
                }
            }

            _db.Close();

            return (partsTotal, lostTotal, mileageTotal, lateFeeTotal);
        }
    }
}
