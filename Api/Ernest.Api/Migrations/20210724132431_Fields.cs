using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventBooleanFields",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Boolean = table.Column<bool>(type: "INTEGER", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBooleanFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventBooleanFields_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventDecimalFields",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Decimal = table.Column<decimal>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecimalFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventDecimalFields_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventIntegerFields",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Integer = table.Column<int>(type: "INTEGER", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventIntegerFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventIntegerFields_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventStringFields",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    String = table.Column<string>(type: "TEXT", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStringFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventStringFields_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFields_EventID",
                table: "EventBooleanFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFields_EventID",
                table: "EventDecimalFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFields_EventID",
                table: "EventIntegerFields",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFields_EventID",
                table: "EventStringFields",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventBooleanFields");

            migrationBuilder.DropTable(
                name: "EventDecimalFields");

            migrationBuilder.DropTable(
                name: "EventIntegerFields");

            migrationBuilder.DropTable(
                name: "EventStringFields");
        }
    }
}
