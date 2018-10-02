using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class SeedDistanceAndAreaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Unit",
                columns: new[] { "Symbol", "DisplayName" },
                values: new object[,]
                {
                    { "km²", "Square Kilometre" },
                    { "nmi", "Nautical Mile" },
                    { "in", "Inch" },
                    { "ft", "Foot" },
                    { "yd", "Yard" },
                    { "mi", "Mile" },
                    { "nm", "Nanometre" },
                    { "μm", "Micrometre" },
                    { "mm", "Millimetre" },
                    { "cm", "Centimetre" },
                    { "dm", "Decimetre" },
                    { "m", "Metre" },
                    { "km", "Kilometre" },
                    { "ac", "Acre" },
                    { "ha", "Hectare" },
                    { "in²", "Square Inch" },
                    { "ft²", "Square Foot" },
                    { "yd²", "Square Yard" },
                    { "mi²", "Square Mile" },
                    { "m²", "Square Metre" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitType",
                columns: new[] { "Id", "DisplayName" },
                values: new object[,]
                {
                    { 2, "Area" },
                    { 1, "Distance" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "BaseUnitMap",
                columns: new[] { "UnitTypeId", "BaseUnitSymbol" },
                values: new object[,]
                {
                    { 2, "km²" },
                    { 1, "m" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[,]
                {
                    { "km²", "m²", 10000000.0 },
                    { "nmi", "ft", 6076.12 },
                    { "ft", "in", 12.0 },
                    { "yd", "ft", 3.0 },
                    { "ft", "m", 0.3048 },
                    { "m", "nm", 1000000000.0 },
                    { "m", "μm", 1000000.0 },
                    { "m", "mm", 1000.0 },
                    { "mi", "ft", 5280.0 },
                    { "m", "dm", 10.0 },
                    { "km", "m", 1000.0 },
                    { "mi²", "ac", 640.0 },
                    { "km²", "ha", 100.0 },
                    { "mi²", "in²", 4014489600.0 },
                    { "mi²", "ft²", 27878400.0 },
                    { "mi²", "yd²", 3097600.0 },
                    { "mi²", "km²", 2.58999 },
                    { "m", "cm", 100.0 }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitSymbol" },
                values: new object[,]
                {
                    { 1, "dm" },
                    { 1, "cm" },
                    { 1, "mm" },
                    { 1, "ft" },
                    { 1, "nm" },
                    { 1, "mi" },
                    { 1, "yd" },
                    { 1, "μm" },
                    { 1, "m" },
                    { 2, "km²" },
                    { 2, "ac" },
                    { 2, "ha" },
                    { 2, "in²" },
                    { 2, "ft²" },
                    { 2, "yd²" },
                    { 2, "mi²" },
                    { 2, "m²" },
                    { 1, "in" },
                    { 1, "km" },
                    { 1, "nmi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "ft", "in" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "ft", "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "km", "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "km²", "ha" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "km²", "m²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "cm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "dm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "mm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi", "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi²", "ac" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi²", "ft²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi²", "in²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi²", "km²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mi²", "yd²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "nmi", "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "yd", "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "cm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "dm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "in" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "km" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "mi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "mm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "nmi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "yd" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ac" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ft²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ha" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "in²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "km²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "m²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "mi²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "yd²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ac");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "cm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "dm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ft");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ft²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ha");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "in");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "in²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "km");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "km²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "m");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "m²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mi");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mi²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "nm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "nmi");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "yd");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "yd²");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "μm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
