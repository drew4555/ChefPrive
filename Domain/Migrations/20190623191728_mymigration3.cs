using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class mymigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientIngredients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ClientId",
                table: "Ingredients",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Clients_ClientId",
                table: "Ingredients",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Clients_ClientId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ClientId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "ClientIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientIngredients_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientIngredients_ClientId",
                table: "ClientIngredients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientIngredients_IngredientId",
                table: "ClientIngredients",
                column: "IngredientId");
        }
    }
}
