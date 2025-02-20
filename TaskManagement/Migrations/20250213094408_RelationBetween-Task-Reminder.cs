using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenTaskReminder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reminders_TaskId",
                table: "Reminders",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Tasks_TaskId",
                table: "Reminders",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Tasks_TaskId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_TaskId",
                table: "Reminders");
        }
    }
}
