using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexion5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee0ea63d-6d32-4a3b-beb0-f9648c7c3fad", "AQAAAAIAAYagAAAAED9TiWcWaJx2q7WMrS6Yuhpsz+nGstYElEdLakcT5cwfOPg5hoJpUXsoubvRXC+Xlw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "348bb39d-0d09-4780-89d2-dc01f1e28a5c", "AQAAAAIAAYagAAAAEM/78kcR2jgE/rwMagxJkh7K3/SdTgy3WDR6JW6Knws0OGlX4bn5AGFKAx/jR0GCQg==" });
        }
    }
}
