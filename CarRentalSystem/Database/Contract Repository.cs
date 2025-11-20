using CarRentalSystem.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CarRentalSystem.Database
{
    public class Contract_Repository
    {
        private readonly SQLDBHelper _db;
        public Contract_Repository()
        {
            _db = SQLDBHelper.Instance;
        }

        public long CreateFullContract(Contracts contract, SecurityDeposit deposit, decimal baseRate, string paymentMethod, string customerName)
        {
            if (contract == null) throw new ArgumentNullException(nameof(contract));
            if (deposit == null) throw new ArgumentNullException(nameof(deposit));

            long newContractID = 0;

            _db.Open();

            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    // 1. Get current mileage of the car
                    long carCurrentMileage = 0;
                    string selectMileageQuery = "SELECT CurrentMileage FROM Car WHERE CarID = @CarID FOR UPDATE;";
                    using (var cmd = new MySqlCommand(selectMileageQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CarID", contract.CarID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                carCurrentMileage = reader.GetInt64("CurrentMileage");
                            }
                            else
                            {
                                throw new Exception("Car not found.");
                            }
                        }
                    }

                    // 2. Insert Contract
                    string insertContractQuery = @"
                        INSERT INTO Contracts
                        (CustID, EmpID, CarID, StartDate, ReturnDate, DaysRented, StartMileage, Status)
                        VALUES
                        (@CustID, @EmpID, @CarID, @StartDate, @ReturnDate, @DaysRented, @StartMileage, @Status);
                        SELECT LAST_INSERT_ID();
                        ";
                    using (var cmd = new MySqlCommand(insertContractQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CustID", contract.CustID);
                        cmd.Parameters.AddWithValue("@EmpID", contract.EmpID);
                        cmd.Parameters.AddWithValue("@CarID", contract.CarID);
                        cmd.Parameters.AddWithValue("@StartDate", contract.StartDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", contract.ReturnDate);
                        cmd.Parameters.AddWithValue("@DaysRented", contract.DaysRented);
                        cmd.Parameters.AddWithValue("@StartMileage", carCurrentMileage);
                        cmd.Parameters.AddWithValue("@Status", contract.Status);

                        newContractID = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    // 3. Insert Security Deposit
                    string insertDepositQuery = @"
                        INSERT INTO SecurityDeposit
                        (ContractID, DepositAmount, Status, DepositDate)
                        VALUES
                        (@ContractID, @DepositAmount, @DepositStatus, CURDATE());
                        ";
                    using (var cmd = new MySqlCommand(insertDepositQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", newContractID);
                        cmd.Parameters.AddWithValue("@DepositAmount", deposit.Amount);
                        cmd.Parameters.AddWithValue("@DepositStatus", deposit.Status);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Insert Billing
                    long newBillingID = 0;
                    string insertBillingQuery = @"
                        INSERT INTO Billing
                        (ContractID, BaseRate, TotalCharges, SecurityDepUsed, TotalAmount, AmountPaid, RemainingBalance, PaymentStatus, BillingDate, Remarks)
                        VALUES
                        (@ContractID, @BaseRate, 0, 0, @BaseRate, 0, @BaseRate, 'Pending', CURDATE(), 'Initial billing');
                        SELECT LAST_INSERT_ID();
                        ";
                    using (var cmd = new MySqlCommand(insertBillingQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", newContractID);
                        cmd.Parameters.AddWithValue("@BaseRate", baseRate);

                        newBillingID = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    // 5. Insert Billing Log for Deposit
                    string insertBillingLogQuery = @"
                        INSERT INTO BillingLog
                        (BillingID, TransactionDate, PaymentMethod, TransactionType, Amount, Notes)
                        VALUES
                        (@BillingID, NOW(), @PaymentMethod, 'Deposit', @Amount, @Notes);
                        ";
                    using (var cmd = new MySqlCommand(insertBillingLogQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BillingID", newBillingID);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@Amount", deposit.Amount);
                        cmd.Parameters.AddWithValue("@Notes", $"{customerName} deposit");
                        cmd.ExecuteNonQuery();
                    }

                    // 6. Update Car status to Rented
                    string updateCarStatusQuery = "UPDATE Car SET Status = 'Rented' WHERE CarID = @CarID;";
                    using (var cmd = new MySqlCommand(updateCarStatusQuery, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CarID", contract.CarID);
                        cmd.ExecuteNonQuery();
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

            return newContractID;
        }

        public List<Contracts> GetAllContracts()
        {
            var contracts = new List<Contracts>();
            string sql = "GetAllContracts";

            _db.Open();
            using (var cmd = new MySqlCommand(sql, _db.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new Contracts
                        {
                            ContractID = reader.GetInt64("ContractID"),
                            CustID = reader.GetInt64("CustID"),
                            CustomerName = reader.IsDBNull(reader.GetOrdinal("CustomerName")) ? string.Empty : reader.GetString("CustomerName"),  // Handles null FullName
                            EmpID = reader.GetInt64("EmpID"),
                            EmployeeName = reader.IsDBNull(reader.GetOrdinal("EmployeeName")) ? string.Empty : reader.GetString("EmployeeName"),  // Handles null FullName
                            CarID = reader.GetInt64("CarID"),
                            CarName = reader.IsDBNull(reader.GetOrdinal("CarName")) ? string.Empty : reader.GetString("CarName"),  // Handles null CONCAT result
                            StartDate = reader.GetDateTime("StartDate"),
                            ReturnDate = reader.GetDateTime("ReturnDate"),
                            DaysRented = reader.GetInt32("DaysRented"),
                            StartMileage = reader.GetInt64("StartMileage"),
                            EndMileage = reader.IsDBNull(reader.GetOrdinal("EndMileage")) ? (long?)null : reader.GetInt64("EndMileage"),
                            DateProcessed = reader.IsDBNull(reader.GetOrdinal("DateProcessed")) ? (DateTime?)null : reader.GetDateTime("DateProcessed"),
                            IsOverdue = reader.GetBoolean("IsOverdue"),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? string.Empty : reader.GetString("Status")
                        });

                    }
                }
            }
            _db.Close();
            return contracts;
        }

        public List<Contracts> GetActiveContractCustomers()
        {
            List<Contracts> list = new List<Contracts>();
            try
            {
                _db.Open();

                using (var cmd = new MySqlCommand("GetActiveContractCustomers", _db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Contracts
                            {
                                ContractID = reader.GetInt64("ContractID"),
                                CustID = reader.GetInt64("CustID"),
                                EmpID = reader.GetInt64("EmpID"),
                                CarID = reader.GetInt64("CarID"),
                                StartDate = reader.GetDateTime("StartDate"),
                                ReturnDate = reader.GetDateTime("ReturnDate"),
                                DaysRented = reader.GetInt64("DaysRented"),
                                DateProcessed = reader.IsDBNull(reader.GetOrdinal("DateProcessed")) ? null : (DateTime?)reader.GetDateTime("DateProcessed"),
                                IsOverdue = reader.GetBoolean("IsOverdue"),
                                StartMileage = reader.GetInt64("StartMileage"),
                                EndMileage = reader.IsDBNull(reader.GetOrdinal("EndMileage")) ? null : (long?)reader.GetInt64("EndMileage"),
                                Status = reader.GetString("Status"),

                                CustomerName = reader.GetString("CustomerName"),
                                DriversLicensePic = reader["DriversLicensePic"] as byte[],

                                CarName = reader.GetString("CarName"),
                                ReplacementValue = reader.GetDecimal("ReplacementValue"),
                                CarPicture = reader["CarPicture"] as byte[],

                                EmployeeName = reader.GetString("EmployeeName"),

                                PlanName = reader.GetString("PlanName"),
                                MileageLimit = reader.IsDBNull(reader.GetOrdinal("MileageLimit")) ? 0 : reader.GetInt64("MileageLimit"),
                                ExcessFeePerKm = reader.IsDBNull(reader.GetOrdinal("ExcessFeePerKm")) ? 0 : reader.GetDecimal("ExcessFeePerKm"),
                                BaseRate = reader.IsDBNull(reader.GetOrdinal("BaseRate")) ? 0 : reader.GetDecimal("BaseRate"),
                                DepositAmount = reader.IsDBNull(reader.GetOrdinal("DepositAmount")) ? 0 : reader.GetDecimal("DepositAmount")
                            });
                        }
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return list;
        }

        public List<Contracts> GetActiveRentalsSimple()
        {
            var list = new List<Contracts>();

            try
            {
                _db.Open();
                string sql = @"
                    SELECT 
                        ct.ContractID AS ContractNum,
                        c.CarID AS CarNo,
                        cust.FullName AS CustomerName,
                        ct.ReturnDate
                    FROM contracts ct
                    INNER JOIN car c ON ct.CarID = c.CarID
                    INNER JOIN customers cust ON ct.CustID = cust.CustID
                    WHERE ct.Status = 'Active'
                    ORDER BY ct.ReturnDate ASC;
                ";

                using (var cmd = new MySqlCommand(sql, _db.Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Contracts
                        {
                            ContractID = reader.GetInt64("ContractNum"),
                            CarID = reader.GetInt64("CarNo"),
                            CustomerName = reader.GetString("CustomerName"),
                            ReturnDate = reader.GetDateTime("ReturnDate")
                        });
                    }
                }
            }
            finally
            {
                _db.Close();
            }

            return list;
        }

        public decimal CompleteContractReturn(
            long contractId,
            long extraMileage,
            decimal mileageFee,
            decimal lateFee,
            decimal lostFee,
            decimal securityDepUsed,
            List<(long PartID, int Quantity, decimal Cost)> damagedParts)
        {
            if (contractId <= 0) throw new ArgumentException("Invalid contract ID");

            decimal totalAmount = 0m;

            _db.Open();
            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    // 1️⃣ Get contract and car info
                    long startMileage = 0;
                    long currentCarMileage = 0;
                    long carID = 0;

                    using (var cmd = new MySqlCommand(@"
                        SELECT c.StartMileage, ca.CurrentMileage, ca.CarID
                        FROM contracts c
                        JOIN car ca ON c.CarID = ca.CarID
                        WHERE c.ContractID = @ContractID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                startMileage = reader.GetInt64("StartMileage");
                                currentCarMileage = reader.GetInt64("CurrentMileage");
                                carID = reader.GetInt64("CarID");
                            }
                            else
                            {
                                throw new Exception("Contract not found.");
                            }
                        }
                    }

                    // 2️⃣ Calculate mileage
                    long distanceTraveled = Math.Max(0, extraMileage);
                    long endMileage = startMileage + distanceTraveled;
                    long newCarMileage = currentCarMileage + distanceTraveled;

                    // 3️⃣ Update contract
                    string updateContract = @"
                        UPDATE contracts
                        SET EndMileage = @EndMileage,
                            Status = 'Completed',
                            DateProcessed = NOW(),
                            IsOverdue = IF(DATEDIFF(NOW(), ReturnDate) > 0, 1, 0)
                        WHERE ContractID = @ContractID";

                    using (var cmd = new MySqlCommand(updateContract, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@EndMileage", endMileage);
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.ExecuteNonQuery();
                    }

                    // 4️⃣ Insert damaged parts charges
                    if (damagedParts != null && damagedParts.Count > 0)
                    {
                        string insertCharge = @"
                            INSERT INTO additionalcharges (ContractID, PartsID, ChargeType, Amount, Quantity, ChargeDate, Notes)
                            VALUES (@ContractID, @PartsID, 'Part Damage', @Amount, @Quantity, CURDATE(), @Notes)";

                        using (var cmd = new MySqlCommand(insertCharge, _db.Connection, transaction))
                        {
                            foreach (var part in damagedParts)
                            {
                                if (part.PartID <= 0 || part.Quantity <= 0) continue;

                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@ContractID", contractId);
                                cmd.Parameters.AddWithValue("@PartsID", part.PartID);
                                cmd.Parameters.AddWithValue("@Amount", part.Cost);
                                cmd.Parameters.AddWithValue("@Quantity", part.Quantity);
                                cmd.Parameters.AddWithValue("@Notes", $"Damaged PartID {part.PartID}, Qty {part.Quantity}");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 5️⃣ Insert non-part charges
                    void InsertNonPartCharge(string type, decimal amount, string notes)
                    {
                        if (amount <= 0) return;
                        using (var cmd = new MySqlCommand(@"
                            INSERT INTO additionalcharges (ContractID, PartsID, ChargeType, Amount, Quantity, ChargeDate, Notes)
                            VALUES (@ContractID, NULL, @ChargeType, @Amount, 1, CURDATE(), @Notes)", _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ContractID", contractId);
                            cmd.Parameters.AddWithValue("@ChargeType", type);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    InsertNonPartCharge("Exceed Mileage", mileageFee, "Excess mileage fee");
                    InsertNonPartCharge("LateFee", lateFee, "Late return fee");
                    InsertNonPartCharge("Lost", lostFee, "Car lost");

                    // 6️⃣ Compute total charges
                    decimal totalCharges = 0m;
                    using (var cmd = new MySqlCommand(
                        "SELECT IFNULL(SUM(Amount * IFNULL(Quantity,1)), 0) FROM additionalcharges WHERE ContractID=@ContractID",
                        _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        totalCharges = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    // 7️⃣ Update billing (use correct column SecurityDepUsed)
                    string updateBilling = @"
                        UPDATE billing
                        SET TotalCharges = @TotalCharges,
                            SecurityDepUsed = @SecurityDepUsed,
                            TotalAmount = BaseRate + @TotalCharges - @SecurityDepUsed,
                            RemainingBalance = (BaseRate + @TotalCharges - @SecurityDepUsed) - AmountPaid,
                            PaymentStatus = CASE 
                                WHEN (BaseRate + @TotalCharges - @SecurityDepUsed - AmountPaid) = 0 THEN 'Paid'
                                WHEN (BaseRate + @TotalCharges - @SecurityDepUsed - AmountPaid) < (BaseRate + @TotalCharges - @SecurityDepUsed) THEN 'Partial'
                                ELSE 'Pending'
                            END
                        WHERE ContractID = @ContractID";

                    using (var cmd = new MySqlCommand(updateBilling, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.Parameters.AddWithValue("@TotalCharges", totalCharges);
                        cmd.Parameters.AddWithValue("@SecurityDepUsed", securityDepUsed);
                        cmd.ExecuteNonQuery();
                    }

                    totalAmount = totalCharges;

                    // 8️⃣ Update security deposit table
                    string updateDeposit = @"
                        UPDATE securitydeposit
                        SET Status = CASE 
                            WHEN @TotalCharges <= 0 THEN 'Forfeited'
                            WHEN @SecurityDepUsed = DepositAmount THEN 'AllUsed'
                            WHEN @SecurityDepUsed > 0 AND @SecurityDepUsed < DepositAmount THEN 'PartialRefunded'
                            ELSE 'Refunded'
                        END
                        WHERE ContractID = @ContractID";

                    using (var cmd = new MySqlCommand(updateDeposit, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@TotalCharges", totalCharges);
                        cmd.Parameters.AddWithValue("@SecurityDepUsed", securityDepUsed);
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.ExecuteNonQuery();
                    }

                    // 9️⃣ Optionally insert billing log for security deposit usage
                    if (securityDepUsed > 0)
                    {
                        string insertBillingLog = @"
                            INSERT INTO billinglog (BillingID, TransactionDate, PaymentMethod, TransactionType, Amount, Notes)
                            SELECT BillingID, NOW(), 'Cash', 'Deposit', @AmountUsed, 'Security deposit applied'
                            FROM billing
                            WHERE ContractID = @ContractID";

                        using (var cmd = new MySqlCommand(insertBillingLog, _db.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ContractID", contractId);
                            cmd.Parameters.AddWithValue("@AmountUsed", securityDepUsed);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 10️⃣ Update car mileage and status
                    bool hasDamages = (damagedParts != null && damagedParts.Count > 0) || lostFee > 0;
                    string updateCar = @"
                        UPDATE car
                        SET CurrentMileage = @NewMileage,
                            Status = CASE WHEN @HasDamages = 1 THEN 'Maintenance' ELSE 'Available' END
                        WHERE CarID = @CarID";

                    using (var cmd = new MySqlCommand(updateCar, _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@NewMileage", newCarMileage);
                        cmd.Parameters.AddWithValue("@HasDamages", hasDamages ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try { transaction.Rollback(); } catch { }
                    throw new Exception("Error completing contract return: " + ex.Message, ex);
                }
                finally
                {
                    _db.Close();
                }

                return totalAmount;
            }
        }


        public void UpdateContractStatus(long contractID, string newStatus)
        {
            if (contractID <= 0) throw new ArgumentException("Invalid contract ID");
            if (string.IsNullOrWhiteSpace(newStatus)) throw new ArgumentException("Invalid status");

            _db.Open();
            try
            {
                string sql = "UPDATE contracts SET Status = @Status WHERE ContractID = @ContractID";
                using (var cmd = new MySqlCommand(sql, _db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ContractID", contractID);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _db.Close();
            }
        }

        public void CancelContract(long contractId)
        {
            if (contractId <= 0) throw new ArgumentException("Invalid contract ID");

            _db.Open();
            using (var transaction = _db.Connection.BeginTransaction())
            {
                try
                {
                    // 1️⃣ Update contract status
                    using (var cmd = new MySqlCommand(@"
                        UPDATE contracts
                        SET Status = 'Canceled'
                        WHERE ContractID = @ContractID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2️⃣ Forfeit security deposit
                    using (var cmd = new MySqlCommand(@"
                        UPDATE securitydeposit
                        SET Status = 'Forfeited'
                        WHERE ContractID = @ContractID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.ExecuteNonQuery();
                    }

                    // 3️⃣ Get BaseRate, DepositAmount, and CarID
                    decimal baseRate = 0m;
                    decimal depositAmount = 0m;
                    long carId = 0;
                    long billingId = 0;

                    using (var cmd = new MySqlCommand(@"
                        SELECT b.BillingID, b.BaseRate, sd.DepositAmount, c.CarID
                        FROM billing b
                        JOIN contracts c ON b.ContractID = c.ContractID
                        JOIN securitydeposit sd ON sd.ContractID = c.ContractID
                        WHERE b.ContractID = @ContractID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                billingId = reader.GetInt64("BillingID");
                                baseRate = reader.GetDecimal("BaseRate");
                                depositAmount = reader.GetDecimal("DepositAmount"); // original deposit amount
                                carId = reader.GetInt64("CarID");
                            }
                            else
                            {
                                throw new Exception("Billing or deposit record not found for this contract.");
                            }
                        }
                    }

                    // Total refund = BaseRate + DepositAmount
                    decimal totalRefund = baseRate + depositAmount;

                    // 4️⃣ Update billing to 'Refunded' with remark
                    using (var cmd = new MySqlCommand(@"
                        UPDATE billing
                        SET PaymentStatus = 'Refunded',
                            RemainingBalance = 0,
                            Remarks = 'Refunded - Cancelled Contract'
                        WHERE ContractID = @ContractID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        cmd.ExecuteNonQuery();
                    }

                    // 5️⃣ Insert into billing log
                    using (var cmd = new MySqlCommand(@"
                        INSERT INTO billinglog (BillingID, TransactionDate, PaymentMethod, TransactionType, Amount, Notes)
                        VALUES (@BillingID, NOW(), 'Cash', 'Refund', @Amount, 'Refund for canceled contract')", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BillingID", billingId);
                        cmd.Parameters.AddWithValue("@Amount", totalRefund);
                        cmd.ExecuteNonQuery();
                    }

                    // 6️⃣ Set car status to Available
                    using (var cmd = new MySqlCommand(@"
                        UPDATE car
                        SET Status = 'Available'
                        WHERE CarID = @CarID", _db.Connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try { transaction.Rollback(); } catch { }
                    throw new Exception("Error canceling contract: " + ex.Message, ex);
                }
                finally
                {
                    _db.Close();
                }
            }
        }

        public int GetRentalsDueToday()
        {
            string sql = @"SELECT COUNT(*) 
                   FROM contracts 
                   WHERE StartDate = CURDATE()
                     AND Status = 'Pending'";

            _db.Open();
            using (var cmd = new MySqlCommand(sql, _db.Connection))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                _db.Close();
                return count;
            }
        }

        public int GetReturnsDueToday()
        {
            string sql = @"SELECT COUNT(*) 
                   FROM contracts 
                   WHERE ReturnDate = CURDATE()
                     AND Status = 'Active'";

            _db.Open();
            using (var cmd = new MySqlCommand(sql, _db.Connection))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                _db.Close();
                return count;
            }
        }

        public int GetOverdueVehicles()
        {
            string sql = @"SELECT COUNT(*) 
                   FROM contracts
                   WHERE ReturnDate < CURDATE()
                     AND Status = 'Active'";

            _db.Open();
            using (var cmd = new MySqlCommand(sql, _db.Connection))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                _db.Close();
                return count;
            }
        }
    }
}
