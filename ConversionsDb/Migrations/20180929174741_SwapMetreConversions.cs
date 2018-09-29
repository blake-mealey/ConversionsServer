using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class SwapMetreConversions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[,]
                {
                    { 2, 3, 10.0 },
                    { 2, 4, 100.0 },
                    { 2, 5, 1000.0 },
                    { 2, 6, 1000000.0 },
                    { 2, 7, 1000000000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "Conversion",
                keyColumns: new[] { "FromUnitId", "ToUnitId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[,]
                {
                    { 3, 2, 0.1 },
                    { 4, 2, 0.01 },
                    { 5, 2, 0.001 },
                    { 6, 2, 1E-06 },
                    { 7, 2, 1E-09 }
                });
        }
    }
}
