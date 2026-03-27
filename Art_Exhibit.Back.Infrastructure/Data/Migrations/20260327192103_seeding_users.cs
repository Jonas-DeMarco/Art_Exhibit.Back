using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeding_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "TypeID", "Username" },
                values: new object[,]
                {
                    { 1, "Userman1@Userman.vom", "Userman1", 1, "Userman1" },
                    { 2, "Artisteman1@Artisteman.com", "Artisteman1", 2, "Artisteman1" },
                    { 3, "Artisteman2@Artisteman.com", "Artisteman2", 2, "Artisteman2" },
                    { 4, "Artisteman3@Artisteman.com", "Artisteman3", 2, "Artisteman3" },
                    { 5, "adminman@admin.com", "adminman", 3, "Amdinman" },
                    { 6, "BannedMan@Badman.evil", "Spooky", 4, "BannedMan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
