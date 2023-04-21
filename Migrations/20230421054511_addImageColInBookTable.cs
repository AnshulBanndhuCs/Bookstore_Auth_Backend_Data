using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore_Auth_Backend_API_DataAccess.Migrations
{
    public partial class addImageColInBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "discreption",
                table: "books",
                newName: "image");

            migrationBuilder.AddColumn<string>(
                name: "discription",
                table: "books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discription",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "books",
                newName: "discreption");
        }
    }
}
