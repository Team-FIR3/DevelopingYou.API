using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevelopingYou.API.Migrations
{
    public partial class RemovedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Goal 
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
