using Microsoft.EntityFrameworkCore.Migrations;

namespace Schedule.Migrations
{
    public partial class updatedTaskFontAwesomeIconsDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "TaskFontAwesomeIcons",
                newName: "FileName");

            migrationBuilder.AddColumn<string>(
                name: "FolderUrl",
                table: "TaskFontAwesomeIcons",
                type: "varchar",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FolderUrl",
                table: "TaskFontAwesomeIcons");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "TaskFontAwesomeIcons",
                newName: "Url");
        }
    }
}
