using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using CarRentalSystem.Code;
using System.IO;

namespace CarRentalSystem.PDF
{
    public class pdf_Contract
    {
        public void GenerateContract(
            string filePath,
            string customerName,
            string customerID,
            string address,
            string phone,
            Cars car,
            RentalPlan rentalPlan,
            DateTime startDate,
            DateTime returnDate,
            int daysRented,
            decimal baseRate,
            decimal securityDeposit,
            string paymentMethod,
            string totalDue,
            string employeeName,
            string employeeID,
            long contractID)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // Header
                    page.Header()
                        .Text("CONTRACT AGREEMENT")
                        .SemiBold()
                        .FontSize(20)
                        .FontColor(Colors.Blue.Medium)
                        .AlignCenter();

                    // Content
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text($"Date Created: {DateTime.Now:MMMM dd, yyyy}");

                            x.Item().Text(
                                $"This Car Rental Contract Agreement is made on {DateTime.Now:MMMM dd, yyyy}, between the Rental Company and {customerName} " +
                                $"(Customer ID: {customerID}), residing at {address}, with contact number {phone}. The customer agrees to rent the vehicle described as {car.CarDescription}, " +
                                $"bearing plate number {car.PlateNumber}. The vehicle’s starting mileage at the time of release is {car.CurrentMileage} km.\n\n" +

                                $"The rental period begins on {startDate:MMMM dd, yyyy} and ends on {returnDate:MMMM dd, yyyy}, totaling {daysRented} day(s). " +
                                $"The rental plan selected is {rentalPlan.PlanName} with a daily rate of {rentalPlan.DailyRate:C}, resulting in a base rate of {baseRate:C}. " +
                                $"A security deposit of {securityDeposit:C} has been paid via {paymentMethod}. The total amount due is {totalDue}.\n\n" +

                                $"By signing this Agreement, the customer agrees to return the vehicle on or before the agreed return date in the same condition it was received. " +
                                $"The customer is responsible for any damages, late return penalties, or violations. The security deposit may be used to cover such charges. " +
                                $"The customer agrees to comply with all applicable traffic laws and not to engage in illegal or reckless activities with the vehicle.\n\n" +
                                $"This contract is effective upon signing by both the customer and the authorized employee.\n\n")
                              .AlignLeft();

                            // Signatures
                            x.Item().Row(row =>
                            {
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("______________________________");
                                    c.Item().Text($"Customer Signature");
                                    c.Item().Text($"{customerName}");
                                });

                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("______________________________");
                                    c.Item().Text($"Authorized Employee Signature");
                                    c.Item().Text($"{employeeName}");
                                });
                            });
                        });

                    // Footer
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();

                        });
                });
            })
            .GeneratePdf(filePath);
        }
    }
}
