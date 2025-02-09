using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UniqueAgentPhoneNumberConstraintAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba3fb79-aa5c-4142-b222-05e8233e506c", "AQAAAAIAAYagAAAAEFVpv2/lfhnZer7K8U41r5Xg98/omXcZs/ANG9T//2WSNM7zaevEIdomehv9/grz0Q==", "bdf2db20-e87e-4c26-9947-7ab3414ed71d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b453a0-78ae-4425-8aa5-50dc44e4394e", "AQAAAAIAAYagAAAAENQTFyplZscylemtbhvpwY4NrPW65ugjY4unmL4ozWbjx2uRR+kqDC9a2E/XGINLrA==", "c563bdf5-bbbe-46aa-ba83-338bc4406f9b" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

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
    }
}
