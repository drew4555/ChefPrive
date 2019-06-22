using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Ingredients",
                newName: "Original");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Original",
                table: "Ingredients",
                newName: "Name");
        }
    }
}
