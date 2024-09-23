using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoDocumento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(7615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(6682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Estados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoDocumento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(2275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(1883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Estados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 14, 58, 33, 352, DateTimeKind.Local).AddTicks(2705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8944));
        }
    }
}
