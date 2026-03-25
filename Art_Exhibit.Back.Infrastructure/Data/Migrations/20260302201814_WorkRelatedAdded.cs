using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class WorkRelatedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cat);
                });

            migrationBuilder.CreateTable(
                name: "Statuts",
                columns: table => new
                {
                    Stat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuts", x => x.Stat);
                });

            migrationBuilder.CreateTable(
                name: "Oeuvres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuteurId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategorieCat = table.Column<string>(type: "TEXT", nullable: true),
                    Exemplaire = table.Column<int>(type: "INTEGER", nullable: false),
                    Nbre_exemplaire = table.Column<int>(type: "INTEGER", nullable: false),
                    IsAuthentified = table.Column<bool>(type: "INTEGER", nullable: false),
                    Titre = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Longueur = table.Column<float>(type: "REAL", nullable: false),
                    Largeur = table.Column<float>(type: "REAL", nullable: false),
                    Profondeur = table.Column<float>(type: "REAL", nullable: false),
                    StatutStat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oeuvres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oeuvres_Categories_CategorieCat",
                        column: x => x.CategorieCat,
                        principalTable: "Categories",
                        principalColumn: "Cat");
                    table.ForeignKey(
                        name: "FK_Oeuvres_Statuts_StatutStat",
                        column: x => x.StatutStat,
                        principalTable: "Statuts",
                        principalColumn: "Stat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oeuvres_Users_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oeuvres_AuteurId",
                table: "Oeuvres",
                column: "AuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Oeuvres_CategorieCat",
                table: "Oeuvres",
                column: "CategorieCat");

            migrationBuilder.CreateIndex(
                name: "IX_Oeuvres_StatutStat",
                table: "Oeuvres",
                column: "StatutStat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oeuvres");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Statuts");
        }
    }
}
