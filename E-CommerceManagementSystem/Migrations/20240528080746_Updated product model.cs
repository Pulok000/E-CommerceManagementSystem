using Microsoft.EntityFrameworkCore.Migrations;

namespace E_CommerceManageMentSystem.Migrations
{
    public partial class Updatedproductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProDuctPictureURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProDuctPictureURL",
                table: "Products");
        }
    }
}
