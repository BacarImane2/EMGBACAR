using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMGBACAR.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIdentityToUtilisateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Utilisateurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Utilisateurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Utilisateurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Utilisateurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Utilisateurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Utilisateurs",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Utilisateurs");
        }
    }
}
