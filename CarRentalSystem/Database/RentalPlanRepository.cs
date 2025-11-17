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

        public bool IsPlanNameTaken(string planName)
        {
            bool taken = false;
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM RentalPlans WHERE PlanName = @PlanName", _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@PlanName", planName);
                    taken = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            finally
            {
                _db.Close();
            }
            return taken;
        }


        public long AddRentalPlan(RentalPlan plan)
        {
            long newPlanId = 0;

            try
            {
                _db.Open();

                using (var cmd = new MySqlCommand("AddRentalPlan", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Input parameters
                    cmd.Parameters.AddWithValue("@p_PlanName", plan.PlanName);
                    cmd.Parameters.AddWithValue("@p_MileageLimitPerDay", plan.MileageLimitPerDay.HasValue ? plan.MileageLimitPerDay.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_ExcessFeePerKm", plan.ExcessFeePerKm);
                    cmd.Parameters.AddWithValue("@p_DailyRate", plan.DailyRate);
                    cmd.Parameters.AddWithValue("@p_Description", plan.Description);

                    // Output parameter
                    var outputParam = new MySqlParameter("@p_NewPlanID", MySqlDbType.Int64)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    // Execute
                    cmd.ExecuteNonQuery();

                    // Get the newly inserted PlanID
                    newPlanId = Convert.ToInt64(outputParam.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding rental plan: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return newPlanId;
        }
    }
}
