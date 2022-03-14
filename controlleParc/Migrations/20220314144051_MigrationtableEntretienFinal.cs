using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace controlleParc.Migrations
{
    public partial class MigrationtableEntretienFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntretienVehicules",
                columns: table => new
                {
                    EntretienVehiculeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImmatriculationId = table.Column<int>(type: "int", nullable: false),
                    EntretienId = table.Column<int>(type: "int", nullable: false),
                    DateEntretien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometreVehicule = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntretienVehicules", x => x.EntretienVehiculeId);
                    table.ForeignKey(
                        name: "FK_EntretienVehicules_Entretiens_EntretienId",
                        column: x => x.EntretienId,
                        principalTable: "Entretiens",
                        principalColumn: "EntretienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntretienVehicules_Vehicules_ImmatriculationId",
                        column: x => x.ImmatriculationId,
                        principalTable: "Vehicules",
                        principalColumn: "ImmatriculeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntretienVehicules_EntretienId",
                table: "EntretienVehicules",
                column: "EntretienId");

            migrationBuilder.CreateIndex(
                name: "IX_EntretienVehicules_ImmatriculationId",
                table: "EntretienVehicules",
                column: "ImmatriculationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntretienVehicules");
        }
    }
}
