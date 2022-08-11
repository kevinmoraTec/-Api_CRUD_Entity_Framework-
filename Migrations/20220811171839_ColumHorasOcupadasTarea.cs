using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class ColumHorasOcupadasTarea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HorasOcupadas",
                table: "Tarea",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasOcupadas",
                table: "Tarea");
        }
    }
}
