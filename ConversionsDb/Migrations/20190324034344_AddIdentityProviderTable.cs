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
                    ClientSecret = table.Column<string>(maxLength: 2000, nullable: true),
                    DiscoveryUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    IconUrl = table.Column<string>(maxLength: 2000, nullable: true)
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
