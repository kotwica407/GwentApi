using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GwentApi.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Provision = table.Column<int>(nullable: false),
                    Faction = table.Column<string>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Rarity = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Categories = table.Column<string>(nullable: true),
                    PrimaryCategory = table.Column<string>(nullable: true),
                    ArtUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
