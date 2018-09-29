using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class AddAreaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Units",
                table: "Unit",
                columns: new[] { "Id", "DisplayName", "Symbol" },
                values: new object[,]
                {
                    { 13, "Square Kilometre", "km²" },
                    { 14, "Square Metre", "m²" },
                    { 15, "Square Mile", "mi²" },
                    { 16, "Square Yard", "yd²" },
                    { 17, "Square Foot", "ft²" },
                    { 18, "Square Inch", "in²" },
                    { 19, "Square Hectare", "ha" },
                    { 20, "Square Acre", "ac" }
                });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "UnitType",
                columns: new[] { "Id", "DisplayName" },
                values: new object[] { 2, "Area" });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[,]
                {
                    { 13, 14, 10000000.0 },
                    { 15, 13, 2.58999 },
                    { 15, 16, 3097600.0 },
                    { 15, 17, 27878400.0 },
                    { 15, 18, 4014489600.0 },
                    { 13, 19, 100.0 },
                    { 15, 20, 640.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 13, 19 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 15, 20 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
