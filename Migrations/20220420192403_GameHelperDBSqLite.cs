using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class GameHelperDBSqLite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfEstablishment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Country = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyDescriptiopn = table.Column<string>(type: "TEXT", nullable: false),
                    Logo = table.Column<byte[]>(type: "BLOB", nullable: false),
                    NumberOfWorkers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<int>(type: "INTEGER", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cover = table.Column<byte[]>(type: "BLOB", nullable: false),
                    StudiosStudioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Studios_StudiosStudioId",
                        column: x => x.StudiosStudioId,
                        principalTable: "Studios",
                        principalColumn: "StudioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_StudiosStudioId",
                table: "Games",
                column: "StudiosStudioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
