using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class ColumCategoriaFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), null, "Actividades personales", 50 },
                    { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "HorasOcupadas", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"), new Guid("b8434f0f-ee49-40be-a825-ea72588af538"), null, new DateTime(2022, 8, 11, 16, 39, 55, 341, DateTimeKind.Local).AddTicks(1590), 0, 2, "Lenguaje Resumen pg:50" },
                    { new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"), new Guid("b8434f0f-ee49-40be-a825-ea72588af538"), null, new DateTime(2022, 8, 11, 16, 39, 55, 341, DateTimeKind.Local).AddTicks(1630), 0, 0, "Matematicas Operaciones pg:90" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
