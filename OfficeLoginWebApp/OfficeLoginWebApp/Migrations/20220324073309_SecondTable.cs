using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeLoginWebApp.Migrations
{
    public partial class SecondTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
