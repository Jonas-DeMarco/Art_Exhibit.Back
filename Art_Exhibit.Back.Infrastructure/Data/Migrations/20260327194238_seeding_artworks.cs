using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeding_artworks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Oeuvres",
                columns: new[] { "Id", "AuteurId", "CategorieCat", "Description", "IsAuthentified", "Largeur", "Longueur", "Profondeur", "StatutStat", "Titre" },
                values: new object[,]
                {
                    { 1, 2, "Painting", "A painting of a blue sky", false, 13f, 12f, 2f, "Waiting", "Blue sky" },
                    { 2, 2, "Painting", "a painting of a red sky", false, 32f, 25f, 2f, "Waiting", "red sky" },
                    { 3, 3, "Sculpture", "A sculpture of a man with a Hat", false, 150f, 60f, 45f, "Waiting", "The Man" },
                    { 4, 3, "Sculpture", "A sculpture of a robot with a Hat", false, 45f, 150f, 60f, "Waiting", "The Machine" },
                    { 5, 4, "Print", "A printed copy of a digital art of my wife", false, 24f, 24f, 1f, "Waiting", "Love of my life" },
                    { 6, 4, "Other", "A smile with a pretty face", false, 234f, 24f, 1222f, "Waiting", "A smile with a pretty face" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Oeuvres",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
