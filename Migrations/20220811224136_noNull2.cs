using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    public partial class noNull2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 11, 17, 41, 36, 247, DateTimeKind.Local).AddTicks(2170),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                columns: new[] { "CategoriaId", "FechaCreacion" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), new DateTime(2022, 8, 11, 17, 41, 36, 246, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                columns: new[] { "CategoriaId", "FechaCreacion" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), new DateTime(2022, 8, 11, 17, 41, 36, 246, DateTimeKind.Local).AddTicks(5880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(9400),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 8, 11, 17, 41, 36, 247, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                columns: new[] { "CategoriaId", "FechaCreacion" },
                values: new object[] { new Guid("b8434f0f-ee49-40be-a825-ea72588af538"), new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                columns: new[] { "CategoriaId", "FechaCreacion" },
                values: new object[] { new Guid("b8434f0f-ee49-40be-a825-ea72588af538"), new DateTime(2022, 8, 11, 17, 38, 1, 568, DateTimeKind.Local).AddTicks(4360) });
        }
    }
}
