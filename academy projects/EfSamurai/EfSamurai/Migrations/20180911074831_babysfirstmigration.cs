using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Migrations
{
    public partial class babysfirstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "haircut",
                table: "Samurais",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "haircut",
                table: "Samurais");
        }
    }
}
