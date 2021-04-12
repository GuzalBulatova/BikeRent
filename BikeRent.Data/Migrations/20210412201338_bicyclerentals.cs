using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRent.Data.Migrations
{
    public partial class bicyclerentals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BicycleRental",
                columns: new[] { "BicycleId", "RentalId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "RentalId", "CustomerId", "RentalEndDate", "RentalStartDate" },
                values: new object[] { 2, 2, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BicycleRental",
                columns: new[] { "BicycleId", "RentalId" },
                values: new object[] { 10, 2 });

            migrationBuilder.InsertData(
                table: "BicycleRental",
                columns: new[] { "BicycleId", "RentalId" },
                values: new object[] { 9, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BicycleRental",
                keyColumns: new[] { "BicycleId", "RentalId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BicycleRental",
                keyColumns: new[] { "BicycleId", "RentalId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "BicycleRental",
                keyColumns: new[] { "BicycleId", "RentalId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "RentalId",
                keyValue: 2);
        }
    }
}
