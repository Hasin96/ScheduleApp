using Microsoft.EntityFrameworkCore.Migrations;

namespace Schedule.Migrations
{
    public partial class updatedTaskFontAwesomeIconPropertyFolderUriAddedMaxLength55FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FolderUrl",
                table: "TaskFontAwesomeIcons",
                type: "varchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FolderUrl",
                table: "TaskFontAwesomeIcons",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(55)",
                oldMaxLength: 55);
        }
    }
}
