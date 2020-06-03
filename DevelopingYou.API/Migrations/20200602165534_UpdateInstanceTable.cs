using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DevelopingYou.API.Migrations
{
    public partial class UpdateInstanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Instance");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Instance",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "Instance",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "StartTime" },
                values: new object[] { 1, "Played Candy Crush instead of coding, could have utilized my time better", "2020-06-01 13:41:23", 1, "2020-06-01 09:41:23" });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "StartTime" },
                values: new object[] { 2, "Video called sister and nephew, was fun", "2020-06-02 12:41:23", 1, "2020-06-02 11:41:23" });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "Id", "Comment", "EndTime", "GoalId", "StartTime" },
                values: new object[] { 3, "Coffee Zoom Meeting, beneficial networking", "2020-06-02 9:41:33", 1, "2020-06-02 07:15:11" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Instance",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Instance",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Instance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
