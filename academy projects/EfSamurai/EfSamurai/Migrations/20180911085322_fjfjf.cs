using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Migrations
{
    public partial class fjfjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "haircut",
                table: "Samurais",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SecretIdentity",
                columns: table => new
                {
                    name = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    samuraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentity", x => x.id);
                    table.ForeignKey(
                        name: "FK_SecretIdentity_Samurais_samuraiId",
                        column: x => x.samuraiId,
                        principalTable: "Samurais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentity_samuraiId",
                table: "SecretIdentity",
                column: "samuraiId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecretIdentity");

            migrationBuilder.AlterColumn<string>(
                name: "haircut",
                table: "Samurais",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
