using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGameCRUD.Data.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "score");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "score", "userName" },
                values: new object[] { 1, "Example 1 hello world", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "score", "userName" },
                values: new object[] { 2, "Example 2 hello world", "Post 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "userName",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Posts",
                newName: "Content");
        }
    }
}
