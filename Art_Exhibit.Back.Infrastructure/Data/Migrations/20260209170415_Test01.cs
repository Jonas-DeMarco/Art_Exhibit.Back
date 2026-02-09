using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeUser", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TypeID",
                table: "Users",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TypeUser_TypeID",
                table: "Users",
                column: "TypeID",
                principalTable: "TypeUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_TypeUser_TypeID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "TypeUser");

            migrationBuilder.DropIndex(
                name: "IX_Users_TypeID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
