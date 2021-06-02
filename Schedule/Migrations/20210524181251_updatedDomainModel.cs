using Microsoft.EntityFrameworkCore.Migrations;

namespace Schedule.Migrations
{
    public partial class updatedDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IconId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TaskFontAwesomeIcon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskFontAwesomeIcon", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_IconId",
                table: "Tasks",
                column: "IconId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcon_IconId",
                table: "Tasks",
                column: "IconId",
                principalTable: "TaskFontAwesomeIcon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskFontAwesomeIcon_IconId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskFontAwesomeIcon");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_IconId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IconId",
                table: "Tasks");
        }
    }
}
