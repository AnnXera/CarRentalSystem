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

        public long CreateContract(Contracts contract)
        {
            string sql = @"INSERT INTO Contracts
                   (CustID, EmpID, CarID, StartDate, ReturnDate, DaysRented, StartMileage, Status)
                   VALUES
                   (@CustID, @EmpID, @CarID, @StartDate, @ReturnDate, @DaysRented, @StartMileage, @Status);
                   SELECT LAST_INSERT_ID();";

            try
            {
                _db.Open();
                using (var cmd = new MySqlCommand(sql, _db.Connection))
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
                MessageBox.Show("Error adding contract: " + ex.Message);
                return -1;
            }
            finally
            {
                _db.Close();
            }
        }

    }
}
