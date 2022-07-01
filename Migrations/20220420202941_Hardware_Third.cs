using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class Hardware_Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "Cpu",
                columns: table => new
                {
                    CpuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpu", x => x.CpuId);
                });

            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {
                    GpuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpu", x => x.GpuId);
                });

            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    MemoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.MemoryId);
                });

            migrationBuilder.CreateTable(
                name: "Motherboard",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboard", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "Psu",
                columns: table => new
                {
                    PsuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psu", x => x.PsuId);
                });

            migrationBuilder.CreateTable(
                name: "Storge",
                columns: table => new
                {
                    StorgeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storge", x => x.StorgeId);
                });

            migrationBuilder.CreateTable(
                name: "PcBuilder",
                columns: table => new
                {
                    PcBuilderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CpuId = table.Column<int>(type: "INTEGER", nullable: false),
                    MotherboardId = table.Column<int>(type: "INTEGER", nullable: false),
                    MemoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    StorgeId = table.Column<int>(type: "INTEGER", nullable: false),
                    GpuId = table.Column<int>(type: "INTEGER", nullable: false),
                    CaseId = table.Column<int>(type: "INTEGER", nullable: false),
                    PsuId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcBuilder", x => x.PcBuilderId);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "CaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Cpu_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpu",
                        principalColumn: "CpuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Gpu_GpuId",
                        column: x => x.GpuId,
                        principalTable: "Gpu",
                        principalColumn: "GpuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Memory_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memory",
                        principalColumn: "MemoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "MotherboardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Psu_PsuId",
                        column: x => x.PsuId,
                        principalTable: "Psu",
                        principalColumn: "PsuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcBuilder_Storge_StorgeId",
                        column: x => x.StorgeId,
                        principalTable: "Storge",
                        principalColumn: "StorgeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_CaseId",
                table: "PcBuilder",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_CpuId",
                table: "PcBuilder",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_GpuId",
                table: "PcBuilder",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_MemoryId",
                table: "PcBuilder",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_MotherboardId",
                table: "PcBuilder",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_PsuId",
                table: "PcBuilder",
                column: "PsuId");

            migrationBuilder.CreateIndex(
                name: "IX_PcBuilder_StorgeId",
                table: "PcBuilder",
                column: "StorgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PcBuilder");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Cpu");

            migrationBuilder.DropTable(
                name: "Gpu");

            migrationBuilder.DropTable(
                name: "Memory");

            migrationBuilder.DropTable(
                name: "Motherboard");

            migrationBuilder.DropTable(
                name: "Psu");

            migrationBuilder.DropTable(
                name: "Storge");
        }
    }
}
