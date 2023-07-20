using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManagementSystem.Core.Migrations
{
    public partial class ChangeEventType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "EventTypeSchedule",
                columns: table => new
                {
                    EventTypesId = table.Column<int>(type: "int", nullable: false),
                    SchedulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypeSchedule", x => new { x.EventTypesId, x.SchedulesId });
                    table.ForeignKey(
                        name: "FK_EventTypeSchedule_EventTypes_EventTypesId",
                        column: x => x.EventTypesId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTypeSchedule_Schedules_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventTypeSchedule_SchedulesId",
                table: "EventTypeSchedule",
                column: "SchedulesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventTypeSchedule");

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
    }
}
