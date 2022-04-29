using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    public partial class FillProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                             "Values ('Coca-Cola', 'coca.jpg', 5.44, 'Refrigerante de Coca', 100, now(), 1)");

            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                "Values ('Fanta', 'fanta.jpg', 5.44, 'Refrigerante de Fanta', 100, now(), 1)");
            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                "Values ('Hotdog', 'Hotdog.jpg', 7.44, 'Cachorro Quente', 100, now(), 2)");
            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                 "Values ('Pizza', 'pizza.jpg', 27.00, 'Pizza', 100, now(), 2)");
            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                 "Values ('Sorvete de Leite Ninho', 'leiteninho.jpg', 15.44, 'Sorvete de Leite Ninho', 100, now(), 3)");
            migrationBuilder.Sql("Insert into Products(Name, ImageUrl, Price, Description, Stock, RegisterDate, CategoryId)" +
                "Values ('Sorvete de Morango', 'morango.jpg', 15.44, 'Sorvete de Morango', 100, now(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
