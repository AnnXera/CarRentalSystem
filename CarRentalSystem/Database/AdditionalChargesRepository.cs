using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public AdditionalCharges GetContractChargesInfo(long billingId)
        {
            if (billingId <= 0)
                throw new ArgumentException("Invalid Billing ID");

            var result = new AdditionalCharges
            {
                AdditionalChargesTable = new DataTable()
            };

            _db.Open();

            try
            {
                long contractId = 0;

                // 1️⃣ Get ContractID from BillingID
                using (var cmd = new MySqlCommand(
                    "SELECT ContractID FROM billing WHERE BillingID = @BillingID",
                    _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@BillingID", billingId);

                    object res = cmd.ExecuteScalar();
                    if (res == null)
                        throw new Exception("Billing record not found.");

                    contractId = Convert.ToInt64(res);
                }

                // 2️⃣ Get Security Deposit
                using (var cmd = new MySqlCommand(
                    "SELECT DepositAmount FROM securitydeposit WHERE ContractID = @ContractID",
                    _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ContractID", contractId);

                    object dep = cmd.ExecuteScalar();
                    result.SecurityDeposit = dep != null ? Convert.ToDecimal(dep) : 0m;
                }

                // 3️⃣ Get Additional Charges
                string queryCharges = @"
                    SELECT 
                        ac.ChargeID,
                        ac.ChargeType,
                        ac.Amount,
                        ac.Quantity,
                        ac.ChargeDate,
                        p.PartName AS DamagedPart
                    FROM additionalcharges ac
                    LEFT JOIN carparts p ON ac.PartsID = p.PartsID
                    WHERE ac.ContractID = @ContractID
                    ORDER BY ac.ChargeDate DESC";

                using (var cmd = new MySqlCommand(queryCharges, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ContractID", contractId);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(result.AdditionalChargesTable);
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return result;
        }
    }
}
