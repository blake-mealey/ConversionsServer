using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class AddAreaBaseUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Units",
                table: "BaseUnitMap",
                columns: new[] { "UnitTypeId", "BaseUnitId" },
                values: new object[] { 2, 13 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Units",
                table: "BaseUnitMap",
                keyColumns: new[] { "UnitTypeId", "BaseUnitId" },
                keyValues: new object[] { 2, 13 });
        }
    }
}
