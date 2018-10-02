using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Conversions");

            migrationBuilder.CreateTable(
                name: "Unit",
                schema: "Conversions",
                columns: table => new
                {
                    Symbol = table.Column<string>(maxLength: 8, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Symbol);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                schema: "Conversions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conversion",
                schema: "Conversions",
                columns: table => new
                {
                    FromUnitSymbol = table.Column<string>(maxLength: 8, nullable: false),
                    ToUnitSymbol = table.Column<string>(maxLength: 8, nullable: false),
                    Multiplier = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversion", x => new { x.FromUnitSymbol, x.ToUnitSymbol });
                    table.ForeignKey(
                        name: "FK_Conversion_Unit_FromUnitSymbol",
                        column: x => x.FromUnitSymbol,
                        principalSchema: "Conversions",
                        principalTable: "Unit",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversion_Unit_ToUnitSymbol",
                        column: x => x.ToUnitSymbol,
                        principalSchema: "Conversions",
                        principalTable: "Unit",
                        principalColumn: "Symbol");
                });

            migrationBuilder.CreateTable(
                name: "BaseUnitMap",
                schema: "Conversions",
                columns: table => new
                {
                    UnitTypeId = table.Column<int>(nullable: false),
                    BaseUnitSymbol = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUnitMap", x => x.UnitTypeId);
                    table.ForeignKey(
                        name: "FK_BaseUnitMap_Unit_BaseUnitSymbol",
                        column: x => x.BaseUnitSymbol,
                        principalSchema: "Conversions",
                        principalTable: "Unit",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseUnitMap_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalSchema: "Conversions",
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitTypeMap",
                schema: "Conversions",
                columns: table => new
                {
                    UnitTypeId = table.Column<int>(nullable: false),
                    UnitSymbol = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypeMap", x => new { x.UnitTypeId, x.UnitSymbol });
                    table.UniqueConstraint("AK_UnitTypeMap_UnitSymbol_UnitTypeId", x => new { x.UnitSymbol, x.UnitTypeId });
                    table.ForeignKey(
                        name: "FK_UnitTypeMap_Unit_UnitSymbol",
                        column: x => x.UnitSymbol,
                        principalSchema: "Conversions",
                        principalTable: "Unit",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitTypeMap_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalSchema: "Conversions",
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseUnitMap_BaseUnitSymbol",
                schema: "Conversions",
                table: "BaseUnitMap",
                column: "BaseUnitSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_Conversion_ToUnitSymbol",
                schema: "Conversions",
                table: "Conversion",
                column: "ToUnitSymbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseUnitMap",
                schema: "Conversions");

            migrationBuilder.DropTable(
                name: "Conversion",
                schema: "Conversions");

            migrationBuilder.DropTable(
                name: "UnitTypeMap",
                schema: "Conversions");

            migrationBuilder.DropTable(
                name: "Unit",
                schema: "Conversions");

            migrationBuilder.DropTable(
                name: "UnitType",
                schema: "Conversions");
        }
    }
}
