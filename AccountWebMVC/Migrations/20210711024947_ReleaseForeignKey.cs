using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountWebMVC.Migrations
{
    public partial class ReleaseForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Release",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Release");
        }
    }
}
