using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeLoginWebApp.Migrations
{
    public partial class SecondTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OfficeLogger",
                table: "OfficeLogger");

            migrationBuilder.RenameTable(
                name: "OfficeLogger",
                newName: "officeLoggers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_officeLoggers",
                table: "officeLoggers",
                column: "LoggerId");

            migrationBuilder.CreateTable(
                name: "userSigninLogs",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoggerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPAddressLocal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSigninLogs", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userSigninLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_officeLoggers",
                table: "officeLoggers");

            migrationBuilder.RenameTable(
                name: "officeLoggers",
                newName: "OfficeLogger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfficeLogger",
                table: "OfficeLogger",
                column: "LoggerId");
        }
    }
}
