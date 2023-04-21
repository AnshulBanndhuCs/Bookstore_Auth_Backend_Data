using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore_Auth_Backend_API_DataAccess.Migrations
{
    public partial class editDescriptionColInBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "discription",
                table: "books",
                newName: "description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "books",
                newName: "discription");
        }
    }
}
