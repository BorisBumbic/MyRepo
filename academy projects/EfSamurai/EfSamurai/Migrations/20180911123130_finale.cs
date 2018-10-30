using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Migrations
{
    public partial class finale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "battleLogId",
                table: "Battle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BattleLog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BattleEvent",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order = table.Column<int>(nullable: false),
                    input = table.Column<string>(nullable: true),
                    battleLogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleEvent", x => x.id);
                    table.ForeignKey(
                        name: "FK_BattleEvent_BattleLog_battleLogId",
                        column: x => x.battleLogId,
                        principalTable: "BattleLog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battle_battleLogId",
                table: "Battle",
                column: "battleLogId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvent_battleLogId",
                table: "BattleEvent",
                column: "battleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattleLog_battleLogId",
                table: "Battle",
                column: "battleLogId",
                principalTable: "BattleLog",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattleLog_battleLogId",
                table: "Battle");

            migrationBuilder.DropTable(
                name: "BattleEvent");

            migrationBuilder.DropTable(
                name: "BattleLog");

            migrationBuilder.DropIndex(
                name: "IX_Battle_battleLogId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "battleLogId",
                table: "Battle");
        }
    }
}
