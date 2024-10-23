using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalaDuck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PointPropertyForBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Point",
                table: "Books",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Point", "ReleaseDateTime" },
                values: new object[] { 0f, new DateTime(2024, 10, 21, 23, 47, 56, 541, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Point", "ReleaseDateTime" },
                values: new object[] { 0f, new DateTime(2024, 10, 21, 23, 47, 56, 541, DateTimeKind.Local).AddTicks(1889) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDateTime",
                value: new DateTime(2024, 10, 21, 23, 42, 19, 139, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDateTime",
                value: new DateTime(2024, 10, 21, 23, 42, 19, 139, DateTimeKind.Local).AddTicks(9021));
        }
    }
}
