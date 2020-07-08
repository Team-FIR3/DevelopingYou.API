using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class SeededUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_AspNetUsers_UserId",
                table: "Goal");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Goal",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Goal",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "33332c90 - d0f3 - 4cc3 - beb0 - b71ce674c7db");

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_AspNetUsers_UserId",
                table: "Goal",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_AspNetUsers_UserId",
                table: "Goal");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Goal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Goal",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_AspNetUsers_UserId",
                table: "Goal",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
