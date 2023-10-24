using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52a17159-4ec2-4213-ba5e-e89f5d158c68", "AQAAAAIAAYagAAAAELPiP6VXPmkpBym6GkO/UHy8h+7gNLptCDPgtgHVHnUnJ0FI0fnTdRFNZd0VaHTK1w==", "b048f73a-5a55-4892-84bf-48b1ce3ab4b5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b672b5-7e9f-4be1-91e4-15953b086255", "AQAAAAIAAYagAAAAEH9HoRvpT0JOGExYbyV6eVqlnExWqY6YEIshuEWiYad8muu+yA516Hk750HY+3Fwxw==", "7512d91c-e6d3-49d2-b5f8-c7db7c3d1e75" });
        }
    }
}
