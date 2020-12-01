using Microsoft.EntityFrameworkCore.Migrations;

namespace DrinkAndGo.Migrations
{
    public partial class TableNameModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Drinks");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CategoryId",
                table: "Drinks",
                newName: "IX_Drinks_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drinks",
                table: "Drinks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Categories_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Categories_CategoryId",
                table: "Drinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drinks",
                table: "Drinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Drinks",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Languages");

            migrationBuilder.RenameIndex(
                name: "IX_Drinks_CategoryId",
                table: "Books",
                newName: "IX_Books_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
