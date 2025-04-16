using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserExtended : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b68cdf2-e152-4bc6-b03a-9946b2c20e24", "", "", "AQAAAAIAAYagAAAAEDmjppgfg78dwgjiaT2gH2lgALhiOHRLeXIdrNgeGZQAW0VvCTW1KdcZHK0ExG0bjw==", "575a79ef-7435-424f-86ba-313f197ca569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "Firstname", "Lastname", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5271d33-aae1-4dc3-937e-8d7aa6f262ed", "", "", "AQAAAAIAAYagAAAAEC/VR6sg+Od2ZBwDe6xDwZZ1Sv+bmNUmtzim9OBOjpwapV+pjowj8ZAY1muwxV1Fig==", "b00cf604-3392-4d2e-b2a5-13c249d00348" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

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
        }
    }
}
