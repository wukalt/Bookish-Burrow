using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookishBurrow.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Family", "Name", "ShortBio" },
                values: new object[,]
                {
                    { 1, 43, "Matthes", "Eric", "Eric Matthes teaches math and science at a small alternative school in southeast Alaska. He has lived in New Hampshire, New York City, and Alaska. " },
                    { 2, 35, "Price", "Mark. J", "Mark J. Price is a Microsoft Specialist: Programming in C# and Architecting Microsoft Azure Solutions, with over 20 years' experience." }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "ImageUrl", "Point", "Price", "ReleaseDateTime", "Title" },
                values: new object[,]
                {
                    { 1, 1, "One of the most visited book for python in 2024.A Guid Line of learning python", "https://m.media-amazon.com/images/I/71uiG3qqKaL._AC_UF1000,1000_QL80_.jpg", 0f, 0m, new DateTime(2024, 11, 14, 15, 19, 53, 613, DateTimeKind.Local).AddTicks(6873), "Python Crash Course" },
                    { 2, 2, "One of the most visited book for C# in 2024.A Guid Line of learning C#", "https://m.media-amazon.com/images/I/61YKrMbrdGL._AC_UF1000,1000_QL80_.jpg", 0f, 0m, new DateTime(2024, 11, 14, 15, 19, 53, 615, DateTimeKind.Local).AddTicks(1527), "C# 12 And .NET 8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
