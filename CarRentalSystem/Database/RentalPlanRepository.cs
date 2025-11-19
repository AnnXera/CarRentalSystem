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
                        MileageLimit = reader["MileageLimit"] != DBNull.Value
                            ? Convert.ToInt64(reader["MileageLimit"])
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

        public bool IsPlanNameTaken(string planName, long? excludePlanID = null)
        {
            bool taken = false;
            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = _db.Connection;

                    if (excludePlanID.HasValue)
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM RentalPlans WHERE PlanName = @PlanName AND PlanID != @PlanID";
                        cmd.Parameters.AddWithValue("@PlanID", excludePlanID.Value);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM RentalPlans WHERE PlanName = @PlanName";
                    }

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
                    cmd.Parameters.AddWithValue("@p_MileageLimit", plan.MileageLimit.HasValue ? plan.MileageLimit.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_ExcessFeePerKm", plan.ExcessFeePerKm);
                    cmd.Parameters.AddWithValue("@p_DailyRate", plan.DailyRate);
                    cmd.Parameters.AddWithValue("@p_Description", plan.Description);

                    // Output parameter
                    var outParam = new MySqlParameter("@p_NewPlanID", MySqlDbType.Int64)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the newly inserted PlanID
                    newPlanId = Convert.ToInt64(outParam.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add rental plan: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }

            return newPlanId;
        }

        public void EditRentalPlan(RentalPlan plan)
        {
            try
            {
                _db.Open();

                using (var cmd = new MySqlCommand("EditRentalPlan", _db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Input parameters
                    cmd.Parameters.AddWithValue("@p_PlanID", plan.PlanID);
                    cmd.Parameters.AddWithValue("@p_PlanName", plan.PlanName);
                    cmd.Parameters.AddWithValue("@p_MileageLimit", plan.MileageLimit.HasValue ? plan.MileageLimit.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_ExcessFeePerKm", plan.ExcessFeePerKm);
                    cmd.Parameters.AddWithValue("@p_DailyRate", plan.DailyRate);
                    cmd.Parameters.AddWithValue("@p_Description", plan.Description);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error editing rental plan: " + ex.Message);
            }
            finally
            {
                _db.Close();
            }
        }

    }
}
