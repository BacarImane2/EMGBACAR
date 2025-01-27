using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class userConnexopn11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECA7HwXO6IRn3mwj0xx3lZGs8xLRArfkhOnE2q/5BJ+d8HaT9jdlqw0qq9b1vpjMtA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN08oRnB7IhalglGGUE92nKQNdc5OSu2XAvC0f40g/advdG2gQvNlIS85VVqbvSV2w==");
        }
    }
}
