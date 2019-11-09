using Microsoft.EntityFrameworkCore.Migrations;

namespace Chimerical.Conversions.Db.Migrations
{
    public partial class Astronomical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Unit",
                columns: new[] { "Symbol", "DisplayName" },
                values: new object[] { "pc", "Parsec" });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Unit",
                columns: new[] { "Symbol", "DisplayName" },
                values: new object[] { "ly", "LightYear" });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Unit",
                columns: new[] { "Symbol", "DisplayName" },
                values: new object[] { "au", "AstronomicalUnit" });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[] { "pc", "ly", 3.2616 });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[] { "au", "m", 149597870700.0 });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[] { "pc", "au", 206265.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "au", "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "pc", "au" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "pc", "ly" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "au");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ly");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "pc");
        }
    }
}
