using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRent.Data.Migrations
{
    public partial class firstrental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "RentalId", "CustomerId", "RentalEndDate", "RentalStartDate" },
                values: new object[] { 1, 1, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "RentalId",
                keyValue: 1);
        }
    }
}
