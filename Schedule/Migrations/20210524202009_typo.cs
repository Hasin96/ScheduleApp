using Microsoft.EntityFrameworkCore.Migrations;

namespace Schedule.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcon_IconId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskFontAwesomeIcon",
                table: "TaskFontAwesomeIcon");

            migrationBuilder.RenameTable(
                name: "TaskFontAwesomeIcon",
                newName: "TaskFontAwesomeIcons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskFontAwesomeIcons",
                table: "TaskFontAwesomeIcons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcons_IconId",
                table: "Tasks",
                column: "IconId",
                principalTable: "TaskFontAwesomeIcons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcons_IconId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskFontAwesomeIcons",
                table: "TaskFontAwesomeIcons");

            migrationBuilder.RenameTable(
                name: "TaskFontAwesomeIcons",
                newName: "TaskFontAwesomeIcon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskFontAwesomeIcon",
                table: "TaskFontAwesomeIcon",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcon_IconId",
                table: "Tasks",
                column: "IconId",
                principalTable: "TaskFontAwesomeIcon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
