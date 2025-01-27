using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexion6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87729a4a-526f-4f5e-a187-fe176713550b", "AQAAAAIAAYagAAAAEBAiFRH2uOuueG8hj7P9YGy4Zn8tIqi4WZpE1IkFKhMn79AdEF4cRVVn2MlTX2KR8w==", "d1a3b2c4-5678-4f90-abcd-1234567890ef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0ea63d-6d32-4a3b-beb0-f9648c7c3fad", "AQAAAAIAAYagAAAAED9TiWcWaJx2q7WMrS6Yuhpsz+nGstYElEdLakcT5cwfOPg5hoJpUXsoubvRXC+Xlw==", "some-static-security-stamp" });
        }
    }
}
