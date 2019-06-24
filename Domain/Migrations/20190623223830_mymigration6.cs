using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class mymigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealDay",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MealNumber",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealDay",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "MealNumber",
                table: "Recipes");
        }
    }
}
