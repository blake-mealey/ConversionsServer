using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class SeedDistanceData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Units",
                table: "Unit",
                columns: new[] { "Id", "DisplayName", "Symbol" },
                values: new object[,]
                {
                    { 1, "Kilometre", "km" },
                    { 2, "Metre", "m" },
                    { 3, "Decimetre", "dm" },
                    { 4, "Centimetre", "cm" },
                    { 5, "Millimetre", "mm" },
                    { 6, "Micrometre", "μm" },
                    { 7, "Nanometre", "nm" },
                    { 8, "Mile", "mi" },
                    { 9, "Yard", "yd" },
                    { 10, "Foot", "ft" },
                    { 11, "Inch", "in" },
                    { 12, "NauticalMile", "nmi" }
                });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "UnitType",
                columns: new[] { "Id", "DisplayName" },
                values: new object[] { 1, "Distance" });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "BaseUnitMap",
                columns: new[] { "UnitTypeId", "BaseUnitId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "RelativeValue",
                columns: new[] { "BaseUnitId", "UnitId", "Value" },
                values: new object[,]
                {
                    { 2, 1, 1000.0 },
                    { 10, 11, 0.083333333333333329 },
                    { 10, 10, 1.0 },
                    { 10, 9, 3.0 },
                    { 10, 8, 5280.0 },
                    { 2, 10, 0.3048 },
                    { 10, 12, 6076.12 },
                    { 2, 6, 1e-06 },
                    { 2, 5, 0.001 },
                    { 2, 4, 0.01 },
                    { 2, 3, 0.1 },
                    { 2, 2, 1.0 },
                    { 2, 7, 1e-09 }
                });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitId" },
                values: new object[,]
                {
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 2 },
                    { 1, 1 },
                    { 1, 11 },
                    { 1, 5 },
                    { 1, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "BaseUnitMap",
                keyColumns: new[] { "UnitTypeId", "BaseUnitId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "RelativeValue",
                keyColumns: new[] { "BaseUnitId", "UnitId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
