using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class ColumPesoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Categoria",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Categoria");
        }
    }
}
