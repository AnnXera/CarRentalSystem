using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystem.Database
{
    public class Contract_Repository
    {
        private readonly SQLDBHelper _db;
        public Contract_Repository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long CreateContract(Contracts contract, MySqlTransaction transaction = null)
        {
            string sql = @"INSERT INTO Contracts 
                   (CustID, EmpID, CarID, StartDate, ReturnDate, DaysRented, StartMileage, Status)
                   VALUES (@CustID, @EmpID, @CarID, @StartDate, @ReturnDate, @DaysRented, @StartMileage, @Status);
                   SELECT LAST_INSERT_ID();";
            try
            {
                if (_db.Connection.State != System.Data.ConnectionState.Open)
                    _db.Open();

                using (var cmd = new MySqlCommand(sql, _db.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@CustID", contract.CustID);
                    cmd.Parameters.AddWithValue("@EmpID", contract.EmpID);
                    cmd.Parameters.AddWithValue("@CarID", contract.CarID);
                    cmd.Parameters.AddWithValue("@StartDate", contract.StartDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", contract.ReturnDate);
                    cmd.Parameters.AddWithValue("@DaysRented", contract.DaysRented);
                    cmd.Parameters.AddWithValue("@StartMileage", contract.StartMileage);
                    cmd.Parameters.AddWithValue("@Status", contract.Status);

                    return Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding contract: " + ex.Message);
            }
        }


    }
}
