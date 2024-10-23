using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KalaDuck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    ShortBio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Point = table.Column<float>(type: "real", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
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
                    { 1, 1, "One of the most visited book for python in 2024.A Guid Line of learning python", "https://m.media-amazon.com/images/I/71uiG3qqKaL._AC_UF1000,1000_QL80_.jpg", 0f, 0m, new DateTime(2024, 10, 23, 12, 27, 4, 382, DateTimeKind.Local).AddTicks(7513), "Python Crash Course" },
                    { 2, 2, "One of the most visited book for C# in 2024.A Guid Line of learning C#", "https://m.media-amazon.com/images/I/61YKrMbrdGL._AC_UF1000,1000_QL80_.jpg", 0f, 0m, new DateTime(2024, 10, 23, 12, 27, 4, 382, DateTimeKind.Local).AddTicks(7526), "C# 12 And .NET 8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
