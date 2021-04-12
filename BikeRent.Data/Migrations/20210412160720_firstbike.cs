using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRent.Data.Migrations
{
    public partial class firstbike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "BicycleId", "BicyclePrice" },
                values: new object[] { 1, 300f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "BicycleId",
                keyValue: 1);
        }
    }
}
