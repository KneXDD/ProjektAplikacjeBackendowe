using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class Hardware : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfWorkers",
                table: "Studios",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "EnginesEngineId",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Developer = table.Column<string>(type: "TEXT", nullable: false),
                    License = table.Column<string>(type: "TEXT", nullable: false),
                    EngineDescription = table.Column<string>(type: "TEXT", nullable: false),
                    EngineLogo = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.EngineId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_EnginesEngineId",
                table: "Games",
                column: "EnginesEngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Engines_EnginesEngineId",
                table: "Games",
                column: "EnginesEngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Engines_EnginesEngineId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Games_EnginesEngineId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "EnginesEngineId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfWorkers",
                table: "Studios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
