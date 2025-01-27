using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexopn9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPsrf8LMEibZy5XYgvBk3WDHshKi2kuWm45Rfi2ZP0tuX8gzV7Zu20KSqig0sBbfPQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMjXKoI9kDCHzM8Delchy4SpR9RThDi91lWR1adX14thKr4yIXLFQulBjFfHc0v7sA==");
        }
    }
}
