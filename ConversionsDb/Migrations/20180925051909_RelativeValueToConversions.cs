using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class RelativeValueToConversions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelativeValue",
                schema: "Units");

            migrationBuilder.CreateTable(
                name: "Conversion",
                schema: "Units",
                columns: table => new
                {
                    FromUnitId = table.Column<int>(nullable: false),
                    ToUnitId = table.Column<int>(nullable: false),
                    Multiplier = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversion", x => new { x.FromUnitId, x.ToUnitId });
                    table.ForeignKey(
                        name: "FK_Conversion_Unit_FromUnitId",
                        column: x => x.FromUnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversion_Unit_ToUnitId",
                        column: x => x.ToUnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "Conversion",
                columns: new[] { "FromUnitId", "ToUnitId", "Multiplier" },
                values: new object[,]
                {
                    { 1, 2, 1000.0 },
                    { 3, 2, 0.1 },
                    { 4, 2, 0.01 },
                    { 5, 2, 0.001 },
                    { 6, 2, 1E-06 },
                    { 7, 2, 1E-09 },
                    { 10, 2, 0.3048 },
                    { 8, 10, 5280.0 },
                    { 9, 10, 3.0 },
                    { 11, 10, 12.0 },
                    { 12, 10, 6076.12 }
                });

            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DisplayName",
                value: "Nautical Mile");

            migrationBuilder.CreateIndex(
                name: "IX_Conversion_ToUnitId",
                schema: "Units",
                table: "Conversion",
                column: "ToUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversion",
                schema: "Units");

            migrationBuilder.CreateTable(
                name: "RelativeValue",
                schema: "Units",
                columns: table => new
                {
                    BaseUnitId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeValue", x => new { x.BaseUnitId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_RelativeValue_Unit_BaseUnitId",
                        column: x => x.BaseUnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelativeValue_Unit_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Units",
                table: "RelativeValue",
                columns: new[] { "BaseUnitId", "UnitId", "Value" },
                values: new object[,]
                {
                    { 2, 1, 1000.0 },
                    { 2, 2, 1.0 },
                    { 2, 3, 0.1 },
                    { 2, 4, 0.01 },
                    { 2, 5, 0.001 },
                    { 2, 6, 1E-06 },
                    { 2, 7, 1E-09 },
                    { 2, 10, 0.3048 },
                    { 10, 8, 5280.0 },
                    { 10, 9, 3.0 },
                    { 10, 10, 1.0 },
                    { 10, 11, 0.083333333333333329 },
                    { 10, 12, 6076.12 }
                });

            migrationBuilder.UpdateData(
                schema: "Units",
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DisplayName",
                value: "NauticalMile");

            migrationBuilder.CreateIndex(
                name: "IX_RelativeValue_UnitId",
                schema: "Units",
                table: "RelativeValue",
                column: "UnitId");
        }
    }
}
