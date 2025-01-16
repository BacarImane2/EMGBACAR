using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class NouvelleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "Voitures",
                columns: new[] { "Id", "Annee", "Description", "EstIndisponible", "EstVendue", "MarqueId", "Nom", "Prix" },
                values: new object[,]
                {
                    { 1, 2022, "Voiture fiable", false, false, 1, "Corolla", 15000m },
                    { 2, 2023, "Compact moderne", false, false, 2, "Civic", 18000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voitures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
