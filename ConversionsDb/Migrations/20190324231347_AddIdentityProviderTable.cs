using Microsoft.EntityFrameworkCore.Migrations;

namespace Chimerical.Conversions.Db.Migrations
{
    public partial class AddIdentityProviderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.CreateTable(
                name: "IdentityProvider",
                schema: "Auth",
                columns: table => new
                {
                    ClientId = table.Column<string>(maxLength: 2000, nullable: false),
                    ClientSecret = table.Column<string>(maxLength: 2000, nullable: false),
                    DiscoveryUrl = table.Column<string>(maxLength: 2000, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    IconUrl = table.Column<string>(maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityProvider", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityProvider",
                schema: "Auth");
        }
    }
}
