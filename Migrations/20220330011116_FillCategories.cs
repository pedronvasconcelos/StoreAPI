using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    public partial class FillCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Category (Name, ImageUrl) Values('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("Insert into Category (Name, ImageUrl) Values('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("Insert into Category (Name, ImageUrl) Values('Sobremesas', 'sobremesas.jpg')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Category");
        }
    }
}
