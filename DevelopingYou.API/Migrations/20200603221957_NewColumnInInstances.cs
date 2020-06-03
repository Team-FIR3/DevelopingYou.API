using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class NewColumnInInstances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoalTitle",
                table: "Instance",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 1,
                column: "GoalTitle",
                value: "Less social media");

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoalTitle",
                value: "Less social media");

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoalTitle",
                value: "Less social media");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalTitle",
                table: "Instance");
        }
    }
}
