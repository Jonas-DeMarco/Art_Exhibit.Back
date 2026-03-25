using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                column: "Cat",
                values: new object[]
                {
                    "Other",
                    "Painting",
                    "Print",
                    "Sculpture"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Cat",
                keyValue: "Other");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Cat",
                keyValue: "Painting");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Cat",
                keyValue: "Print");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Cat",
                keyValue: "Sculpture");
        }
    }
}
