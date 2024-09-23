using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoDocumento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(9826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(8800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Estados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 156, DateTimeKind.Local).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Ciudades",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 156, DateTimeKind.Local).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoDocumento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(7615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(6682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 155, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Estados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 22, 15, 23, 49, 165, DateTimeKind.Local).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 156, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Ciudades",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 22, 15, 27, 32, 156, DateTimeKind.Local).AddTicks(594));
        }
    }
}
