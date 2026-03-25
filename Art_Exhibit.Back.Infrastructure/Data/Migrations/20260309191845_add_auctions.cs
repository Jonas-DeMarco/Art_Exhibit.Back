using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class add_auctions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encheres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date_debut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Date_fin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OeuvreId = table.Column<int>(type: "INTEGER", nullable: false),
                    Prix_reserve = table.Column<float>(type: "REAL", nullable: false),
                    Incr_mini = table.Column<float>(type: "REAL", nullable: false),
                    Duree_antisniping = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encheres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encheres_Oeuvres_OeuvreId",
                        column: x => x.OeuvreId,
                        principalTable: "Oeuvres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encheres_OeuvreId",
                table: "Encheres",
                column: "OeuvreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encheres");
        }
    }
}
