using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class FixHectareAndAcreDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DisplayName",
                value: "Hectare");

            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DisplayName",
                value: "Acre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DisplayName",
                value: "Square Hectare");

            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DisplayName",
                value: "Square Acre");
        }
    }
}
