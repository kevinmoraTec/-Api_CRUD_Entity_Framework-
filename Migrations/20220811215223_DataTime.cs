using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class DataTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 11, 16, 52, 22, 74, DateTimeKind.Local).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 11, 16, 52, 22, 73, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 11, 16, 52, 22, 73, DateTimeKind.Local).AddTicks(9640));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 8, 11, 16, 52, 22, 74, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 11, 16, 39, 55, 341, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 11, 16, 39, 55, 341, DateTimeKind.Local).AddTicks(1630));
        }
    }
}
