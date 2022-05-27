using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeLoginWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "officeLoggers",
                columns: table => new
                {
                    LoggerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoggerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_officeLoggers", x => x.LoggerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "officeLoggers");
        }
    }
}
