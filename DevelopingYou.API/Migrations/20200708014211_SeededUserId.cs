using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class SeededUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Goal 
            ");

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
