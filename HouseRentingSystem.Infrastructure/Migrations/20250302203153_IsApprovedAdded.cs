using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IsApprovedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin.");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08677d8c-0cfe-4ff4-8122-03a4ae261278",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fca1306-7687-4068-b617-dde88bc76de7", "AQAAAAIAAYagAAAAEJaPQEQVoEbkdJnwZKLaYDzDu5KD7kxdBuFzhNMnwD2LkqT+XuCS8OHZkngNE0/4lg==", "f8fffe88-18bc-4852-bb74-ebe1809dbf49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522839e5-99cf-495b-acaa-67bbc832e949", "AQAAAAIAAYagAAAAEHwMiPuksSmMZfJpY6FtjepxYVes5DV4NqhemroJmJ8Onl2sn/CF9YesS42mBQGstA==", "54ad4fac-2e8c-4f7e-8e93-6c67c75254d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84821a17-cdf2-4ffd-83b2-e0229b544320", "AQAAAAIAAYagAAAAEMxW9EX+XkfizdpuZl5a0U2Y/vQ3kYaJgUnxCpN5KD8ZMsqf2VbQTFCiyBiWLaokug==", "c2b36c35-94a6-4330-a80f-6848af03b9cb" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsApproved",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

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
    }
}
