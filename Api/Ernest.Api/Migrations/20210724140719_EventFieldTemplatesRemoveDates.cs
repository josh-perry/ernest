using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class EventFieldTemplatesRemoveDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "EventStringFieldTemplates");

            migrationBuilder.DropColumn(
                name: "LastEditedDateTime",
                table: "EventStringFieldTemplates");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "EventIntegerFieldTemplates");

            migrationBuilder.DropColumn(
                name: "LastEditedDateTime",
                table: "EventIntegerFieldTemplates");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "EventDecimalFieldTemplates");

            migrationBuilder.DropColumn(
                name: "LastEditedDateTime",
                table: "EventDecimalFieldTemplates");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "EventBooleanFieldTemplates");

            migrationBuilder.DropColumn(
                name: "LastEditedDateTime",
                table: "EventBooleanFieldTemplates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "EventStringFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDateTime",
                table: "EventStringFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "EventIntegerFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDateTime",
                table: "EventIntegerFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "EventDecimalFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDateTime",
                table: "EventDecimalFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "EventBooleanFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDateTime",
                table: "EventBooleanFieldTemplates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
