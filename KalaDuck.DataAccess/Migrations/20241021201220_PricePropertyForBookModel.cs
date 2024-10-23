using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalaDuck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PricePropertyForBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ReleaseDateTime" },
                values: new object[] { 0m, new DateTime(2024, 10, 21, 23, 42, 19, 139, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ReleaseDateTime" },
                values: new object[] { 0m, new DateTime(2024, 10, 21, 23, 42, 19, 139, DateTimeKind.Local).AddTicks(9021) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDateTime",
                value: new DateTime(2024, 10, 7, 15, 17, 27, 388, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDateTime",
                value: new DateTime(2024, 10, 7, 15, 17, 27, 388, DateTimeKind.Local).AddTicks(7704));
        }
    }
}
