using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScaffoldLesPractice.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "article");

            migrationBuilder.DropTable(
                name: "author");
        }
    }
}
