using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class first_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oeuvres_Statuts_StatutStat",
                table: "Oeuvres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuts",
                table: "Statuts");

            migrationBuilder.RenameTable(
                name: "Statuts",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Stat");

            migrationBuilder.InsertData(
                table: "Status",
                column: "Stat",
                values: new object[]
                {
                    "Refused",
                    "Sold",
                    "Up for Auction",
                    "Waiting"
                });

            migrationBuilder.InsertData(
                table: "TypeUsers",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Artiste" },
                    { 3, "Admin" },
                    { 4, "Banned" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Oeuvres_Status_StatutStat",
                table: "Oeuvres",
                column: "StatutStat",
                principalTable: "Status",
                principalColumn: "Stat",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oeuvres_Status_StatutStat",
                table: "Oeuvres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Stat",
                keyValue: "Refused");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Stat",
                keyValue: "Sold");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Stat",
                keyValue: "Up for Auction");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Stat",
                keyValue: "Waiting");

            migrationBuilder.DeleteData(
                table: "TypeUsers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeUsers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeUsers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypeUsers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuts",
                table: "Statuts",
                column: "Stat");

            migrationBuilder.AddForeignKey(
                name: "FK_Oeuvres_Statuts_StatutStat",
                table: "Oeuvres",
                column: "StatutStat",
                principalTable: "Statuts",
                principalColumn: "Stat",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
