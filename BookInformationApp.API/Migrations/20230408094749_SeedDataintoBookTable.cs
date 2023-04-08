using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookInformationApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataintoBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "Description", "Genre", "Language", "Pages", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Mark Twain", "This novel centres on a smart mischievous young boy living in a town along the Mississippi River.", "Fiction", "English", 244, new DateTime(1876, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Adventures of Tom Sawyer" },
                    { 2, "Agatha Christie", "Considered to be one of Agatha Christie's greatest, and also most controversial mysteries.", "Mystery Thriller", "English", 288, new DateTime(1926, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Murder of Roger Ackroyd" }
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
        }
    }
}
