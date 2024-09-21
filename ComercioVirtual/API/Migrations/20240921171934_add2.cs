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
                defaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(8421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(7296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(5724));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoDocumento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(6402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 21, 14, 18, 16, 376, DateTimeKind.Local).AddTicks(5724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 21, 14, 19, 33, 124, DateTimeKind.Local).AddTicks(7296));
        }
    }
}
