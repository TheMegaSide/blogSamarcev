using Microsoft.EntityFrameworkCore.Migrations;

namespace blogSamarcev.Migrations
{
    public partial class add_blogPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Adress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employees",
                newName: "Address");
        }
    }
}
