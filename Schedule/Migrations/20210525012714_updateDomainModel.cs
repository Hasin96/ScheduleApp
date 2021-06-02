using Microsoft.EntityFrameworkCore.Migrations;

namespace Schedule.Migrations
{
    public partial class updateDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TaskFontAwesomeIcons");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "TaskFontAwesomeIcons",
                type: "varchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "TaskFontAwesomeIcons");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TaskFontAwesomeIcons",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
