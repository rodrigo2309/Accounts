using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountWebMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    TipoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Local_Tipo_TipoID",
                        column: x => x.TipoID,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Release",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocalID = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Release", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Release_Local_LocalID",
                        column: x => x.LocalID,
                        principalTable: "Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Local_TipoID",
                table: "Local",
                column: "TipoID");

            migrationBuilder.CreateIndex(
                name: "IX_Release_LocalID",
                table: "Release",
                column: "LocalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Release");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "Tipo");
        }
    }
}
