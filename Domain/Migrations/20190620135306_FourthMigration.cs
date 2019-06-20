using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (1, 'www.1.com', 'true', 'false', 'true', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (2, 'www.2.com', 'true', 'true', 'false', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (3, 'www.3.com', 'true', 'false', 'true', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (4, 'www.4.com', 'false', 'false', 'true', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (5, 'www.5,com', 'false', 'false', 'false', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (6, 'www.6.com', 'true', 'false', 'false', 2)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, ClientId) VALUES (7, 'www.7.com', 'false', 'true', 'true', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
