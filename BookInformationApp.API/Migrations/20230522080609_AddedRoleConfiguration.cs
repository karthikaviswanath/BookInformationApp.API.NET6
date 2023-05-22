using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookInformationApp.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoleConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e7ffda8-4e47-41b6-a5c7-2f3799b03813", "2c038bb1-9045-4425-83ca-c2f1607dc3eb", "User", "USER" },
                    { "682581d0-10ad-4396-bf7a-0aeaea179f17", "b4bf1521-6b5a-46e5-89c7-ce06f63e7179", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e7ffda8-4e47-41b6-a5c7-2f3799b03813");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "682581d0-10ad-4396-bf7a-0aeaea179f17");
        }
    }
}
