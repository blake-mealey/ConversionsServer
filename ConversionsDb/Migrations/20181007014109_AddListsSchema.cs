using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversionsDb.Migrations
{
    public partial class AddListsSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lists");

            migrationBuilder.CreateTable(
                name: "Converter",
                schema: "Lists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UnitTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Converter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Converter_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalSchema: "Conversions",
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConverterIoType",
                schema: "Lists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConverterIoType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConverterList",
                schema: "Lists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConverterList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConverterIo",
                schema: "Lists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ConverterIoTypeId = table.Column<int>(nullable: false),
                    ConverterId = table.Column<Guid>(nullable: false),
                    UnitSymbol = table.Column<string>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConverterIo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConverterIo_Converter_ConverterId",
                        column: x => x.ConverterId,
                        principalSchema: "Lists",
                        principalTable: "Converter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConverterIo_ConverterIoType_ConverterIoTypeId",
                        column: x => x.ConverterIoTypeId,
                        principalSchema: "Lists",
                        principalTable: "ConverterIoType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConverterIo_Unit_UnitSymbol",
                        column: x => x.UnitSymbol,
                        principalSchema: "Conversions",
                        principalTable: "Unit",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConverterListMap",
                schema: "Lists",
                columns: table => new
                {
                    ConverterListId = table.Column<Guid>(nullable: false),
                    ConverterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConverterListMap", x => new { x.ConverterListId, x.ConverterId });
                    table.UniqueConstraint("AK_ConverterListMap_ConverterId_ConverterListId", x => new { x.ConverterId, x.ConverterListId });
                    table.ForeignKey(
                        name: "FK_ConverterListMap_Converter_ConverterId",
                        column: x => x.ConverterId,
                        principalSchema: "Lists",
                        principalTable: "Converter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConverterListMap_ConverterList_ConverterListId",
                        column: x => x.ConverterListId,
                        principalSchema: "Lists",
                        principalTable: "ConverterList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Lists",
                table: "ConverterIoType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Input" });

            migrationBuilder.InsertData(
                schema: "Lists",
                table: "ConverterIoType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Output" });

            migrationBuilder.CreateIndex(
                name: "IX_Converter_UnitTypeId",
                schema: "Lists",
                table: "Converter",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConverterIo_ConverterId",
                schema: "Lists",
                table: "ConverterIo",
                column: "ConverterId");

            migrationBuilder.CreateIndex(
                name: "IX_ConverterIo_ConverterIoTypeId",
                schema: "Lists",
                table: "ConverterIo",
                column: "ConverterIoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConverterIo_UnitSymbol",
                schema: "Lists",
                table: "ConverterIo",
                column: "UnitSymbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConverterIo",
                schema: "Lists");

            migrationBuilder.DropTable(
                name: "ConverterListMap",
                schema: "Lists");

            migrationBuilder.DropTable(
                name: "ConverterIoType",
                schema: "Lists");

            migrationBuilder.DropTable(
                name: "Converter",
                schema: "Lists");

            migrationBuilder.DropTable(
                name: "ConverterList",
                schema: "Lists");
        }
    }
}
