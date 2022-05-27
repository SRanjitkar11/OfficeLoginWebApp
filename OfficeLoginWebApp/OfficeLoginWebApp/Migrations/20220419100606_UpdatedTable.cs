using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeLoginWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogginTime",
                table: "userSigninLogs",
                newName: "LoginTime");

            migrationBuilder.RenameColumn(
                name: "LogginTime",
                table: "officeLoggers",
                newName: "LoginTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "LogoutTime",
                table: "userSigninLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LogoutTime",
                table: "officeLoggers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoutTime",
                table: "userSigninLogs");

            migrationBuilder.DropColumn(
                name: "LogoutTime",
                table: "officeLoggers");

            migrationBuilder.RenameColumn(
                name: "LoginTime",
                table: "userSigninLogs",
                newName: "LogginTime");

            migrationBuilder.RenameColumn(
                name: "LoginTime",
                table: "officeLoggers",
                newName: "LogginTime");
        }
    }
}
