using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class EventFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventBooleanFields",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Boolean = table.Column<bool>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBooleanFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventBooleanFields_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
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
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecimalFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventDecimalFields_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
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
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventIntegerFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventIntegerFields_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
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
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStringFields", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventStringFields_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventTypeFieldTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypeFieldTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventTypeFieldTemplates_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventEventTag",
                columns: table => new
                {
                    EventTagsID = table.Column<int>(type: "INTEGER", nullable: false),
                    EventsID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEventTag", x => new { x.EventTagsID, x.EventsID });
                    table.ForeignKey(
                        name: "FK_EventEventTag_Events_EventsID",
                        column: x => x.EventsID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEventTag_EventTags_EventTagsID",
                        column: x => x.EventTagsID,
                        principalTable: "EventTags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventBooleanFieldTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeFieldTemplatesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBooleanFieldTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventBooleanFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                        column: x => x.EventTypeFieldTemplatesID,
                        principalTable: "EventTypeFieldTemplates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventBooleanFieldTemplates_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventDecimalFieldTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeFieldTemplatesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecimalFieldTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventDecimalFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                        column: x => x.EventTypeFieldTemplatesID,
                        principalTable: "EventTypeFieldTemplates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventDecimalFieldTemplates_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventIntegerFieldTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeFieldTemplatesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventIntegerFieldTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventIntegerFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                        column: x => x.EventTypeFieldTemplatesID,
                        principalTable: "EventTypeFieldTemplates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventIntegerFieldTemplates_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventStringFieldTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeFieldTemplatesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastEditedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventTypeID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStringFieldTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventStringFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                        column: x => x.EventTypeFieldTemplatesID,
                        principalTable: "EventTypeFieldTemplates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventStringFieldTemplates_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFields_EventTypeID",
                table: "EventBooleanFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFieldTemplates_EventTypeID",
                table: "EventBooleanFieldTemplates",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFields_EventTypeID",
                table: "EventDecimalFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFieldTemplates_EventTypeID",
                table: "EventDecimalFieldTemplates",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventEventTag_EventsID",
                table: "EventEventTag",
                column: "EventsID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFields_EventTypeID",
                table: "EventIntegerFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFieldTemplates_EventTypeID",
                table: "EventIntegerFieldTemplates",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeID",
                table: "Events",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFields_EventTypeID",
                table: "EventStringFields",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFieldTemplates_EventTypeID",
                table: "EventStringFieldTemplates",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypeFieldTemplates_EventTypeID",
                table: "EventTypeFieldTemplates",
                column: "EventTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventBooleanFields");

            migrationBuilder.DropTable(
                name: "EventBooleanFieldTemplates");

            migrationBuilder.DropTable(
                name: "EventDecimalFields");

            migrationBuilder.DropTable(
                name: "EventDecimalFieldTemplates");

            migrationBuilder.DropTable(
                name: "EventEventTag");

            migrationBuilder.DropTable(
                name: "EventIntegerFields");

            migrationBuilder.DropTable(
                name: "EventIntegerFieldTemplates");

            migrationBuilder.DropTable(
                name: "EventStringFields");

            migrationBuilder.DropTable(
                name: "EventStringFieldTemplates");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTags");

            migrationBuilder.DropTable(
                name: "EventTypeFieldTemplates");

            migrationBuilder.DropTable(
                name: "EventTypes");
        }
    }
}
