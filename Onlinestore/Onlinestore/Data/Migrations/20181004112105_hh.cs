using Microsoft.EntityFrameworkCore.Migrations;

namespace Onlinestore.Data.Migrations
{
    public partial class hh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shell",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shell",
                table: "Product");
        }
    }
}
