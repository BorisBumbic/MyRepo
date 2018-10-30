using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAlongDBquick.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaskettyBasketId",
                table: "Fruits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaskettyFruitId",
                table: "Fruits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BasketToFruit",
                columns: table => new
                {
                    FruitId = table.Column<int>(nullable: false),
                    BasketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketToFruit", x => new { x.BasketId, x.FruitId });
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BTFBasketId = table.Column<int>(nullable: true),
                    BTFFruitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basket_BasketToFruit_BTFBasketId_BTFFruitId",
                        columns: x => new { x.BTFBasketId, x.BTFFruitId },
                        principalTable: "BasketToFruit",
                        principalColumns: new[] { "BasketId", "FruitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fruits_BaskettyBasketId_BaskettyFruitId",
                table: "Fruits",
                columns: new[] { "BaskettyBasketId", "BaskettyFruitId" });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_BTFBasketId_BTFFruitId",
                table: "Basket",
                columns: new[] { "BTFBasketId", "BTFFruitId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_BasketToFruit_BaskettyBasketId_BaskettyFruitId",
                table: "Fruits",
                columns: new[] { "BaskettyBasketId", "BaskettyFruitId" },
                principalTable: "BasketToFruit",
                principalColumns: new[] { "BasketId", "FruitId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_BasketToFruit_BaskettyBasketId_BaskettyFruitId",
                table: "Fruits");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "BasketToFruit");

            migrationBuilder.DropIndex(
                name: "IX_Fruits_BaskettyBasketId_BaskettyFruitId",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "BaskettyBasketId",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "BaskettyFruitId",
                table: "Fruits");
        }
    }
}
