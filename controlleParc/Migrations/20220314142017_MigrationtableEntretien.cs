using Microsoft.EntityFrameworkCore.Migrations;

namespace controlleParc.Migrations
{
    public partial class MigrationtableEntretien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entretiens",
                columns: table => new
                {
                    EntretienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEntretien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequence = table.Column<int>(type: "int", nullable: false),
                    Periode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kilometrage = table.Column<int>(type: "int", nullable: false),
                    Montant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entretiens", x => x.EntretienId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entretiens");
        }
    }
}
