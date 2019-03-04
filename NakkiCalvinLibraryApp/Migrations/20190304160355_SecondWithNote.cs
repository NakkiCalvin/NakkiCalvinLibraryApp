using Microsoft.EntityFrameworkCore.Migrations;

namespace NakkiCalvinLibraryApp.Migrations
{
    public partial class SecondWithNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Student");
        }
    }
}
