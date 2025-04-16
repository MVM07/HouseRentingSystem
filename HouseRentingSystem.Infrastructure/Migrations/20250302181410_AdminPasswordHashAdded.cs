using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdminPasswordHashAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08677d8c-0cfe-4ff4-8122-03a4ae261278",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "844f9069-7636-41ad-a2c8-c338b7515ea8", "AQAAAAIAAYagAAAAEJrxXqS+JoEQvNiCIBq3l7wHmoU5Endcgt5b9U0k+aU2lhce8zcvjm3kOntCh5LOOw==", "ae48f35d-ba7e-48b8-981e-e4c6f0cfaeb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d26584e4-0eef-40a0-b195-922f1d88f2ea", "AQAAAAIAAYagAAAAELNAQyUvzwnroMFZBo5+BtMdwWv2/R5xc7niPM3YC28rqQVK1jvs2bUBH4HdHuICxw==", "fc601936-0616-4bef-a6e1-206707512162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c41dd848-ba67-4795-8f21-44bfe387f026", "AQAAAAIAAYagAAAAEIzmUJXadCl73cKePEOgGdkB81dyhbo7k1E2I+8GT4BiinmxBSoR0l5FxnPJ8BKzJw==", "5a4757ae-9561-461e-8942-97c76a3fb42a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08677d8c-0cfe-4ff4-8122-03a4ae261278",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d2af666-9799-4e12-9cff-8476c78beabf", null, "d6450333-8366-4dff-bcb5-7d41c63b803a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1d99aa-1dcc-435c-ab62-af9a98215b5e", "AQAAAAIAAYagAAAAEGMLdpCcymLfP1gTi8AIzNBbSyastpo94ywB2gMnEOYwA1CmOc65hV0+JHhX2v2cHA==", "e70c8eca-4e20-4eb8-aff9-dfc2c3ad42b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb7d4fb5-6f8e-4721-96d1-52a5e15508b7", "AQAAAAIAAYagAAAAEEUkOMherz0x/bDaOovEzJBKjd4lXI5c0XlqnX7T41nh+Ga5ALMtoJ76ZTuVlbmvYQ==", "d6c0df94-d2f7-46e0-bc4d-393169aba039" });
        }
    }
}
