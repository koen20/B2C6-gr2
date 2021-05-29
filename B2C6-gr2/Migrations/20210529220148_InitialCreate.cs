using Microsoft.EntityFrameworkCore.Migrations;

namespace B2C6_gr2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikelNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtikelSoortId = table.Column<int>(type: "int", nullable: false),
                    ArtikelPunten = table.Column<int>(type: "int", nullable: false),
                    Serienummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
