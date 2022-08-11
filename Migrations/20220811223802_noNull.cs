using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class noNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(9400),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 8, 11, 16, 52, 22, 74, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                columns: new[] { "Descripcion", "FechaCreacion" },
                values: new object[] { "Resumir con Cuadros Sipnoticos", new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                columns: new[] { "Descripcion", "FechaCreacion" },
                values: new object[] { "Realizarlas con una hoja de papel Bom", new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(4360) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 11, 16, 52, 22, 74, DateTimeKind.Local).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                columns: new[] { "Descripcion", "FechaCreacion" },
                values: new object[] { null, new DateTime(2022, 8, 11, 16, 52, 22, 73, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                columns: new[] { "Descripcion", "FechaCreacion" },
                values: new object[] { null, new DateTime(2022, 8, 11, 16, 52, 22, 73, DateTimeKind.Local).AddTicks(9640) });
        }
    }
}
