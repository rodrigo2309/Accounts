using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountWebMVC.Migrations
{
    public partial class LocalIDLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginID",
                table: "Local",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginID",
                table: "Local");
        }
    }
}
