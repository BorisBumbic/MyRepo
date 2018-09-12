using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Migrations
{
    public partial class mmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SamuraisToBattle_battleId",
                table: "SamuraisToBattle");

            migrationBuilder.DropIndex(
                name: "IX_SamuraisToBattle_samuraiId",
                table: "SamuraisToBattle");

            migrationBuilder.CreateIndex(
                name: "IX_SamuraisToBattle_battleId",
                table: "SamuraisToBattle",
                column: "battleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SamuraisToBattle_battleId",
                table: "SamuraisToBattle");

            migrationBuilder.CreateIndex(
                name: "IX_SamuraisToBattle_battleId",
                table: "SamuraisToBattle",
                column: "battleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SamuraisToBattle_samuraiId",
                table: "SamuraisToBattle",
                column: "samuraiId",
                unique: true);
        }
    }
}
