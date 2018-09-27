using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class FixFootToInchConversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[] { 10, 11, 12.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[] { 11, 10, 12.0 });
        }
    }
}
