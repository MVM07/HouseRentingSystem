using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdminAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+3598854888888");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1d99aa-1dcc-435c-ab62-af9a98215b5e", "Guest", "Guestov", "AQAAAAIAAYagAAAAEGMLdpCcymLfP1gTi8AIzNBbSyastpo94ywB2gMnEOYwA1CmOc65hV0+JHhX2v2cHA==", "e70c8eca-4e20-4eb8-aff9-dfc2c3ad42b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb7d4fb5-6f8e-4721-96d1-52a5e15508b7", "Agent", "Agentov", "AQAAAAIAAYagAAAAEEUkOMherz0x/bDaOovEzJBKjd4lXI5c0XlqnX7T41nh+Ga5ALMtoJ76ZTuVlbmvYQ==", "d6c0df94-d2f7-46e0-bc4d-393169aba039" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "08677d8c-0cfe-4ff4-8122-03a4ae261278", 0, "4d2af666-9799-4e12-9cff-8476c78beabf", "admin@mail.com", false, "Admin", "Adminov", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", null, null, false, "d6450333-8366-4dff-bcb5-7d41c63b803a", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359888888128", "08677d8c-0cfe-4ff4-8122-03a4ae261278" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08677d8c-0cfe-4ff4-8122-03a4ae261278");

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+359888888888");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a192cf7d-454a-43af-9bdd-f03eb7883efc", "", "", "AQAAAAIAAYagAAAAEA+gcD56Ys1kxmfnj6bs4MQUwwQIW2UmltY3RqPHaRj3tC9aAC0Rsnw8EnhZH9a5zw==", "da1b5803-6e9b-4323-96b2-a6028e017d3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44373d7e-0ad1-401e-8e4f-cadea9650123", "", "", "AQAAAAIAAYagAAAAEOyRoxwbH+oQe60edqT0tdJdQipa4U/5wInmjodmBW4+7fUzqaJ20p8SXFosRpMnbg==", "56565b48-3b45-4193-9c5d-ce2a3009ec90" });
        }
    }
}
