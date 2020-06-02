using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class initialround2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    StartValue = table.Column<decimal>(nullable: false),
                    TargetValue = table.Column<decimal>(nullable: false),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Category", "StartValue", "TargetValue", "Title", "UserId" },
                values: new object[] { 1, 4, 5m, 2m, "Less social media", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
