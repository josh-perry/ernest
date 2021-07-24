using Microsoft.EntityFrameworkCore.Migrations;

namespace Ernest.Api.Migrations
{
    public partial class RemoveTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventBooleanFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDecimalFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_EventIntegerFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_EventStringFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates");

            migrationBuilder.DropTable(
                name: "EventTypeFieldTemplates");

            migrationBuilder.DropIndex(
                name: "IX_EventStringFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates");

            migrationBuilder.DropIndex(
                name: "IX_EventIntegerFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates");

            migrationBuilder.DropIndex(
                name: "IX_EventDecimalFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates");

            migrationBuilder.DropIndex(
                name: "IX_EventBooleanFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates");

            migrationBuilder.DropColumn(
                name: "EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates");

            migrationBuilder.DropColumn(
                name: "EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates");

            migrationBuilder.DropColumn(
                name: "EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates");

            migrationBuilder.DropColumn(
                name: "EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_EventStringFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventIntegerFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecimalFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventBooleanFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates",
                column: "EventTypeFieldTemplatesID");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypeFieldTemplates_EventTypeID",
                table: "EventTypeFieldTemplates",
                column: "EventTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventBooleanFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventBooleanFieldTemplates",
                column: "EventTypeFieldTemplatesID",
                principalTable: "EventTypeFieldTemplates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDecimalFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventDecimalFieldTemplates",
                column: "EventTypeFieldTemplatesID",
                principalTable: "EventTypeFieldTemplates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventIntegerFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventIntegerFieldTemplates",
                column: "EventTypeFieldTemplatesID",
                principalTable: "EventTypeFieldTemplates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventStringFieldTemplates_EventTypeFieldTemplates_EventTypeFieldTemplatesID",
                table: "EventStringFieldTemplates",
                column: "EventTypeFieldTemplatesID",
                principalTable: "EventTypeFieldTemplates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
