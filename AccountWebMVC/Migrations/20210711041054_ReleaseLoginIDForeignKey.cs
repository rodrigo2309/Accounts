using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountWebMVC.Migrations
{
    public partial class ReleaseLoginIDForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LoginId",
                table: "Release",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LoginId",
                table: "Release",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
