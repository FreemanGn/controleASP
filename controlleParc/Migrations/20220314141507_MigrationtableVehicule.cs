using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace controlleParc.Migrations
{
    public partial class MigrationtableVehicule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    ImmatriculeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puissance = table.Column<int>(type: "int", nullable: false),
                    Carburant = table.Column<int>(type: "int", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConducteurID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.ImmatriculeId);
                    table.ForeignKey(
                        name: "FK_Vehicules_Conducteurs_ConducteurID",
                        column: x => x.ConducteurID,
                        principalTable: "Conducteurs",
                        principalColumn: "ConducteurID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_ConducteurID",
                table: "Vehicules",
                column: "ConducteurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicules");
        }
    }
}
