using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManagementSystem.Core.Migrations
{
    public partial class EventTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "EventTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_ScheduleId",
                table: "EventTypes",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventTypes_Schedules_ScheduleId",
                table: "EventTypes",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventTypes_Schedules_ScheduleId",
                table: "EventTypes");

            migrationBuilder.DropIndex(
                name: "IX_EventTypes_ScheduleId",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "EventTypes");
        }
    }
}
