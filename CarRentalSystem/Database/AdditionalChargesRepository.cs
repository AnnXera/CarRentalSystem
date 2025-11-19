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

        public void AddCharge(long contractId, long? partId, string chargeType, decimal amount, int quantity, string notes)
        {
            _db.Open();

            using (var cmd = new MySqlCommand("AddAdditionalCharge", _db.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ContractID", contractId);
                cmd.Parameters.AddWithValue("@p_PartsID", partId);
                cmd.Parameters.AddWithValue("@p_ChargeType", chargeType);
                cmd.Parameters.AddWithValue("@p_Amount", amount);
                cmd.Parameters.AddWithValue("@p_Quantity", quantity);
                cmd.Parameters.AddWithValue("@p_Notes", notes);

                cmd.ExecuteNonQuery();
            }

            _db.Close();
        }
    }
}
