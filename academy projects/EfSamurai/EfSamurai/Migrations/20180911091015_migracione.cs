using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Migrations
{
    public partial class migracione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    brutal = table.Column<bool>(nullable: false),
                    startDate = table.Column<DateTime>(nullable: false),
                    endDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SamuraisToBattle",
                columns: table => new
                {
                    samuraiId = table.Column<int>(nullable: false),
                    battleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraisToBattle", x => new { x.samuraiId, x.battleId });
                    table.ForeignKey(
                        name: "FK_SamuraisToBattle_Battle_battleId",
                        column: x => x.battleId,
                        principalTable: "Battle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraisToBattle_Samurais_samuraiId",
                        column: x => x.samuraiId,
                        principalTable: "Samurais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraisToBattle");

            migrationBuilder.DropTable(
                name: "Battle");
        }
    }
}
