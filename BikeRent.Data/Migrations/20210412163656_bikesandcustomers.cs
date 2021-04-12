using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRent.Data.Migrations
{
    public partial class bikesandcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "BicycleId", "BicyclePrice" },
                values: new object[,]
                {
                    { 2, 300f },
                    { 3, 300f },
                    { 4, 300f },
                    { 5, 300f },
                    { 6, 400f },
                    { 7, 400f },
                    { 8, 400f },
                    { 9, 500f },
                    { 10, 500f }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "RentalId" },
                values: new object[,]
                {
                    { 2, "theclint@fake.com", "Clint", "Eastwood", "0765432101", 0 },
                    { 3, "p.strom@fake.com", "Peter", "Ström", "0765559900", 0 },
                    { 4, "p.blomqvist@fake.com", "Pippi", "Blomqvist", "0767776655", 0 },
                    { 5, "r.dunger@fake.com", "Rebecca", "Dunger", "0764445511", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);
        }
    }
}
