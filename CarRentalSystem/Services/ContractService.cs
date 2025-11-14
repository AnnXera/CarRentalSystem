using CarRentalSystem.Code;
using CarRentalSystem.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CarRentalSystem.Code.Enum.enum_Payment;

namespace CarRentalSystem.Services
{
    public class ContractService
    {
        public void CreateContractWithBilling(
        Contracts contract,
        SecurityDeposit deposit,
        string paymentMethod,
        decimal baseRate,
        string customerName)
        {
            using (var scope = new TransactionScope())
            {
                // ---- Create Contract via Factory ----
                var contractFactory = new ContractFactory();
                long contractId = contractFactory.Add(contract);
                if (contractId <= 0)
                    throw new Exception("Failed to create contract.");
                contract.ContractID = contractId;

                // ---- Add Security Deposit via Factory ----
                deposit.ContractID = contractId;
                var depositFactory = new SecurityDepositFactory();
                long depositId = depositFactory.Add(deposit);
                if (depositId <= 0)
                    throw new Exception("Failed to add security deposit.");

                // ---- Add Billing via Factory ----
                var billingFactory = new BillingFactory();
                var billing = new Billing
                {
                    ContractID = contractId,
                    BaseRate = baseRate,
                    TotalCharges = 0,
                    SecurityDepUsed = 0,
                    TotalAmount = baseRate,
                    AmountPaid = 0,
                    RemainingBalance = baseRate,
                    PaymentStatus = "Pending",
                    BillingDate = DateTime.Now.Date,
                    Remarks = "Initial billing"
                };
                long billingId = billingFactory.Add(billing);
                if (billingId <= 0)
                    throw new Exception("Failed to create billing record.");

                // ---- Add Deposit to Billing Log via Factory ----
                var billingLogFactory = new BillingLogFactory();
                var depositLog = new BillingLog
                {
                    BillingID = billingId,
                    TransactionDate = DateTime.Now,
                    PaymentMethod = paymentMethod,
                    TransactionType = "Deposit",
                    Amount = deposit.Amount,
                    Notes = $"{customerName}'s deposit"
                };
                billingLogFactory.Add(depositLog);

                // ---- Update Car Status via Factory ----
                var carFactory = new CarFactory();
                carFactory.UpdateStatus(contract.CarID, "Rented");

                // ---- Complete transaction ----
                scope.Complete();
            }
        }
    }
}
