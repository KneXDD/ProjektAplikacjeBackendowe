using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class FixDropppppppppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Engines_EnginesEngineId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudiosStudioId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "StudiosStudioId",
                table: "Games",
                newName: "StudioId");

            migrationBuilder.RenameColumn(
                name: "EnginesEngineId",
                table: "Games",
                newName: "EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_StudiosStudioId",
                table: "Games",
                newName: "IX_Games_StudioId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_EnginesEngineId",
                table: "Games",
                newName: "IX_Games_EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Engines_EngineId",
                table: "Games",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudioId",
                table: "Games",
                column: "StudioId",
                principalTable: "Studios",
                principalColumn: "StudioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Engines_EngineId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudioId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "StudioId",
                table: "Games",
                newName: "StudiosStudioId");

            migrationBuilder.RenameColumn(
                name: "EngineId",
                table: "Games",
                newName: "EnginesEngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_StudioId",
                table: "Games",
                newName: "IX_Games_StudiosStudioId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_EngineId",
                table: "Games",
                newName: "IX_Games_EnginesEngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Engines_EnginesEngineId",
                table: "Games",
                column: "EnginesEngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudiosStudioId",
                table: "Games",
                column: "StudiosStudioId",
                principalTable: "Studios",
                principalColumn: "StudioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
