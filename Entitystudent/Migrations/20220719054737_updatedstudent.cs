using Microsoft.EntityFrameworkCore.Migrations;

namespace Entitystudent.Migrations
{
    public partial class updatedstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "student",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "student");
        }
    }
}
