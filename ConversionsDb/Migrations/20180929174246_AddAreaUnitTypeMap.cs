using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class AddAreaUnitTypeMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Units",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitId" },
                values: new object[,]
                {
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                schema: "Units",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitId" },
                keyValues: new object[] { 2, 20 });
        }
    }
}
