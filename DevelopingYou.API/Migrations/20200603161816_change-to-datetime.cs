using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DevelopingYou.API.Migrations
{
    public partial class changetodatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Instance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Instance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 13, 4, 45, 12, 0, DateTimeKind.Utc), new DateTime(2020, 6, 13, 4, 30, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 13, 7, 0, 12, 0, DateTimeKind.Utc), new DateTime(2020, 6, 13, 6, 5, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 13, 10, 0, 12, 0, DateTimeKind.Utc), new DateTime(2020, 6, 13, 9, 0, 12, 0, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Instance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "Instance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { "2020-06-01 13:41:23", "2020-06-01 09:41:23" });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { "2020-06-02 12:41:23", "2020-06-02 11:41:23" });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { "2020-06-02 9:41:33", "2020-06-02 07:15:11" });
        }
    }
}
