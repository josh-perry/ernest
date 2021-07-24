using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class EventFieldsRemoveEventType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventBooleanFields_EventTypes_EventTypeID",
                table: "EventBooleanFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDecimalFields_EventTypes_EventTypeID",
                table: "EventDecimalFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventIntegerFields_EventTypes_EventTypeID",
                table: "EventIntegerFields");

            migrationBuilder.DropForeignKey(
                name: "FK_EventStringFields_EventTypes_EventTypeID",
                table: "EventStringFields");

            migrationBuilder.DropIndex(
                name: "IX_EventStringFields_EventTypeID",
                table: "EventStringFields");

            migrationBuilder.DropIndex(
                name: "IX_EventIntegerFields_EventTypeID",
                table: "EventIntegerFields");

            migrationBuilder.DropIndex(
                name: "IX_EventDecimalFields_EventTypeID",
                table: "EventDecimalFields");

            migrationBuilder.DropIndex(
                name: "IX_EventBooleanFields_EventTypeID",
                table: "EventBooleanFields");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "EventStringFields");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "EventIntegerFields");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "EventDecimalFields");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "EventBooleanFields");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventTypeID",
                table: "EventStringFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeID",
                table: "EventIntegerFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeID",
                table: "EventDecimalFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeID",
                table: "EventBooleanFields",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFields_EventTypeID",
                table: "EventStringFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFields_EventTypeID",
                table: "EventIntegerFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFields_EventTypeID",
                table: "EventDecimalFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFields_EventTypeID",
                table: "EventBooleanFields",
                column: "EventTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventBooleanFields_EventTypes_EventTypeID",
                table: "EventBooleanFields",
                column: "EventTypeID",
                principalTable: "EventTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDecimalFields_EventTypes_EventTypeID",
                table: "EventDecimalFields",
                column: "EventTypeID",
                principalTable: "EventTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventIntegerFields_EventTypes_EventTypeID",
                table: "EventIntegerFields",
                column: "EventTypeID",
                principalTable: "EventTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventStringFields_EventTypes_EventTypeID",
                table: "EventStringFields",
                column: "EventTypeID",
                principalTable: "EventTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
