using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class GoalCompletedColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Goal",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Goal");
        }
    }
}
