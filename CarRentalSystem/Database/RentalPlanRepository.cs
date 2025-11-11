using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    public class RentalPlanRepository
    {
        private readonly SQLDBHelper _db;

        public RentalPlanRepository()
        {
            _db = SQLDBHelper.Instance;
        }

        public List<RentalPlan> GetAllPlans()
        {
            var plans = new List<RentalPlan>();
            _db.Open();

            string query = "SELECT * FROM RentalPlans ORDER BY PlanName ASC";

            using (var cmd = new MySqlCommand(query, _db.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var plan = new RentalPlan
                    {
                        PlanID = Convert.ToInt64(reader["PlanID"]),
                        PlanName = reader["PlanName"].ToString(),
                        MileageLimitPerDay = reader["MileageLimitPerDay"] != DBNull.Value
                            ? Convert.ToInt64(reader["MileageLimitPerDay"])
                            : (long?)null,
                        ExcessFeePerKm = Convert.ToDecimal(reader["ExcessFeePerKm"]),
                        DailyRate = Convert.ToDecimal(reader["DailyRate"]),
                        Description = reader["Description"].ToString()
                    };
                    plans.Add(plan);
                }
            }

            _db.Close();
            return plans;
        }
    }
}
