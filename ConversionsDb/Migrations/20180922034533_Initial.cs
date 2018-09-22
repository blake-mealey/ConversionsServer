using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Units");

            migrationBuilder.CreateTable(
                name: "Unit",
                schema: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    Symbol = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                schema: "Units",
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

            migrationBuilder.CreateTable(
                name: "BaseUnitMap",
                schema: "Units",
                columns: table => new
                {
                    UnitTypeId = table.Column<int>(nullable: false),
                    BaseUnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUnitMap", x => new { x.UnitTypeId, x.BaseUnitId });
                    table.UniqueConstraint("AK_BaseUnitMap_BaseUnitId_UnitTypeId", x => new { x.BaseUnitId, x.UnitTypeId });
                    table.ForeignKey(
                        name: "FK_BaseUnitMap_Unit_BaseUnitId",
                        column: x => x.BaseUnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseUnitMap_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalSchema: "Units",
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitTypeMap",
                schema: "Units",
                columns: table => new
                {
                    UnitTypeId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypeMap", x => new { x.UnitTypeId, x.UnitId });
                    table.UniqueConstraint("AK_UnitTypeMap_UnitId_UnitTypeId", x => new { x.UnitId, x.UnitTypeId });
                    table.ForeignKey(
                        name: "FK_UnitTypeMap_Unit_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "Units",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitTypeMap_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalSchema: "Units",
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelativeValue_UnitId",
                schema: "Units",
                table: "RelativeValue",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseUnitMap",
                schema: "Units");

            migrationBuilder.DropTable(
                name: "RelativeValue",
                schema: "Units");

            migrationBuilder.DropTable(
                name: "UnitTypeMap",
                schema: "Units");

            migrationBuilder.DropTable(
                name: "Unit",
                schema: "Units");

            migrationBuilder.DropTable(
                name: "UnitType",
                schema: "Units");
        }
    }
}
