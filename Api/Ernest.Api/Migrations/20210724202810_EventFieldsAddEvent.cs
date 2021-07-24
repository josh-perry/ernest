using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class EventFieldsAddEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "EventStringFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "EventIntegerFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "EventDecimalFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "EventBooleanFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFields_EventID",
                table: "EventStringFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFields_EventID",
                table: "EventIntegerFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFields_EventID",
                table: "EventDecimalFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFields_EventID",
                table: "EventBooleanFields",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventBooleanFields_Events_EventID",
                table: "EventBooleanFields",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDecimalFields_Events_EventID",
                table: "EventDecimalFields",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventIntegerFields_Events_EventID",
                table: "EventIntegerFields",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventStringFields_Events_EventID",
                table: "EventStringFields",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventBooleanFields_Events_EventID",
                table: "EventBooleanFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDecimalFields_Events_EventID",
                table: "EventDecimalFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventIntegerFields_Events_EventID",
                table: "EventIntegerFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventStringFields_Events_EventID",
                table: "EventStringFields");

            migrationBuilder.DropIndex(
                name: "IX_EventStringFields_EventID",
                table: "EventStringFields");

            migrationBuilder.DropIndex(
                name: "IX_EventIntegerFields_EventID",
                table: "EventIntegerFields");

            migrationBuilder.DropIndex(
                name: "IX_EventDecimalFields_EventID",
                table: "EventDecimalFields");

            migrationBuilder.DropIndex(
                name: "IX_EventBooleanFields_EventID",
                table: "EventBooleanFields");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "EventStringFields");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "EventIntegerFields");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "EventDecimalFields");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "EventBooleanFields");
        }
    }
}
