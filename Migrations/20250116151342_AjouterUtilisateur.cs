using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class AjouterUtilisateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Marques",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    MotDePasse = table.Column<string>(type: "TEXT", nullable: false),
                    EstAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Marques",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
