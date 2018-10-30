using Microsoft.EntityFrameworkCore.Migrations;

namespace Onlinestore.Data.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shell",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shell",
                table: "Product",
                nullable: true);
        }
    }
}
