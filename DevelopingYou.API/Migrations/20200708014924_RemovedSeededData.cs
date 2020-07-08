using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class RemovedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goal",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goal",
                columns: new[] { "Id", "Category", "Completed", "EndDate", "StartDate", "StartValue", "TargetValue", "Title", "UserId" },
                values: new object[] { 1, 4, false, new DateTime(2020, 6, 16, 1, 45, 12, 0, DateTimeKind.Utc), new DateTime(2020, 6, 12, 2, 45, 12, 0, DateTimeKind.Utc), 5m, 2m, "Less social media", "33332c90 - d0f3 - 4cc3 - beb0 - b71ce674c7db" });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "GoalTitle", "StartTime" },
                values: new object[] { 1, "Played Candy Crush instead of coding, could have utilized my time better", new DateTime(2020, 6, 13, 4, 45, 12, 0, DateTimeKind.Utc), 1, "Less social media", new DateTime(2020, 6, 13, 4, 30, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "GoalTitle", "StartTime" },
                values: new object[] { 2, "Video called sister and nephew, was fun", new DateTime(2020, 6, 13, 7, 0, 12, 0, DateTimeKind.Utc), 1, "Less social media", new DateTime(2020, 6, 13, 6, 5, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "GoalTitle", "StartTime" },
                values: new object[] { 3, "Coffee Zoom Meeting, beneficial networking", new DateTime(2020, 6, 13, 10, 0, 12, 0, DateTimeKind.Utc), 1, "Less social media", new DateTime(2020, 6, 13, 9, 0, 12, 0, DateTimeKind.Utc) });
        }
    }
}
