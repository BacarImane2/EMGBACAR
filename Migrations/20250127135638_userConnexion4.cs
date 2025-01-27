using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexion4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "admin-id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "348bb39d-0d09-4780-89d2-dc01f1e28a5c", "AQAAAAIAAYagAAAAEM/78kcR2jgE/rwMagxJkh7K3/SdTgy3WDR6JW6Knws0OGlX4bn5AGFKAx/jR0GCQg==", "some-static-security-stamp" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "admin-id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac8f0247-9327-4d74-a60a-6295d1818148", "AQAAAAIAAYagAAAAEKxYRFKf9zlmLPR6WAa+ZMmsBnzptvXTExgIfDnD6h6IghOocOU01nVWQtWbzXb6fQ==", "b658a122-62b4-4b19-ae0b-f51663c45edd" });
        }
    }
}
