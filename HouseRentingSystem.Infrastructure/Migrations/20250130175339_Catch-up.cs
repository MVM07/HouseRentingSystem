using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Catchup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84d5db87-2025-46a9-a2c8-9cd5160327fd", "AQAAAAIAAYagAAAAEKpFsSa7JzehxTXZ0IpfRxfaaqoZ9+M9ESOaWimfWx1KN5MEkZSu91y2cLBVJRFOPw==", "c94a25d0-6aec-4698-9957-72bea3e6b281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ab1ce1d-3234-4eb7-89e2-950d171dba9c", "AQAAAAIAAYagAAAAEMjVwQQjdbLPPcvQkfZ+dFUnjTQQAOYG2xvAOJ4GIiYVzTTB9iiBEuNLIGsMNZ3Pkw==", "b8b39e77-5988-4dae-a19c-c21e9a1e00d8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d54657f-a26f-4f81-9028-d44a5c74fbd0", "AQAAAAIAAYagAAAAEEPRV595irxvh+HYKOSEh8fqbmyhfCsvlWeJBLGixn70unNP146tiesfGrZ+2Or4Vw==", "1c7c491c-4f62-4b31-916c-54a2d7b43f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bcf521b-338b-451f-bc04-41f815adaad5", "AQAAAAIAAYagAAAAEHOqCaT8XPxkHIz/PgJtIwLbrAhWbh3+XW+yYWfEot6QfwOtWulumQch1eGIU+Ayaw==", "0129bf68-507e-4b72-923c-0226a0ef12c5" });
        }
    }
}
