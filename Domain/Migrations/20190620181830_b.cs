using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (1, 'www.1.com', 'true', 'false', 'true', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (2, 'www.2.com', 'true', 'true', 'false', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (3, 'www.3.com', 'true', 'false', 'true', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (4, 'www.4.com', 'false', 'false', 'true', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (5, 'www.5,com', 'false', 'false', 'false', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (6, 'www.6.com', 'true', 'false', 'false', 'thing', 1)");
            migrationBuilder.Sql("SET Identity_Insert Recipes ON INSERT INTO Recipes (Id, Url, MarkedAsFavorite, IsVegan, IsVegetarian, Title, ClientId) VALUES (7, 'www.7.com', 'false', 'true', 'true', 'thing', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
