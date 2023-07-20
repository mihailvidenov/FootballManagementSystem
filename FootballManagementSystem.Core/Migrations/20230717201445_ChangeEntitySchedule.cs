using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManagementSystem.Core.Migrations
{
    public partial class ChangeEntitySchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "EventTypes");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Schedules",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Schedules");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "EventTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
