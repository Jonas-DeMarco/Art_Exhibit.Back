using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Art_Exhibit.Back.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AAAAAAAAAAA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_TypeUser_TypeID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeUser",
                table: "TypeUser");

            migrationBuilder.RenameTable(
                name: "TypeUser",
                newName: "TypeUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeUsers",
                table: "TypeUsers",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TypeUsers_TypeID",
                table: "Users",
                column: "TypeID",
                principalTable: "TypeUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_TypeUsers_TypeID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeUsers",
                table: "TypeUsers");

            migrationBuilder.RenameTable(
                name: "TypeUsers",
                newName: "TypeUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeUser",
                table: "TypeUser",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TypeUser_TypeID",
                table: "Users",
                column: "TypeID",
                principalTable: "TypeUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
