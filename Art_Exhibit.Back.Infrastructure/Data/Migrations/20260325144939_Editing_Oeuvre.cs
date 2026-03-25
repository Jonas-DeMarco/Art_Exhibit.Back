using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Editing_Oeuvre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exemplaire",
                table: "Oeuvres");

            migrationBuilder.DropColumn(
                name: "Nbre_exemplaire",
                table: "Oeuvres");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Exemplaire",
                table: "Oeuvres",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nbre_exemplaire",
                table: "Oeuvres",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
