using Microsoft.EntityFrameworkCore.Migrations;

namespace ScaffoldLesPractice.Migrations
{
    public partial class AddAgetoAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "author",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "author");
        }
    }
}
