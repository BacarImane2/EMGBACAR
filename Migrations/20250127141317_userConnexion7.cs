using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexion7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "SEEDED_CONCURRENCY_STAMP", "AQAAAAIAAYagAAAAELbSwHhHHNYB8PRUUYkIBqaF5DCS5dNGYYc+1SqtIXvRBUDfMGMUbtg9QqpYE6A67Q==", "SEEDED_SECURITY_STAMP" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87729a4a-526f-4f5e-a187-fe176713550b", "AQAAAAIAAYagAAAAEBAiFRH2uOuueG8hj7P9YGy4Zn8tIqi4WZpE1IkFKhMn79AdEF4cRVVn2MlTX2KR8w==", "d1a3b2c4-5678-4f90-abcd-1234567890ef" });
        }
    }
}
