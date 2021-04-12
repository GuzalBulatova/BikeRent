using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRent.Data.Migrations
{
    public partial class firstcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "RentalId" },
                values: new object[] { 1, "a.tornberg@fake.com", "Anna", "Tornberg", "0765009080", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }
    }
}
