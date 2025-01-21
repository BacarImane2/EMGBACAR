using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class AjoutMarque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 3, "Ford" },
                    { 4, "Chevrolet" },
                    { 5, "Nissan" },
                    { 6, "BMW" },
                    { 7, "Mercedes-Benz" },
                    { 8, "Hyundai" },
                    { 9, "Kia" },
                    { 10, "Volkswagen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
