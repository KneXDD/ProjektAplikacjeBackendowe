using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseType = table.Column<int>(type: "int", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFans = table.Column<int>(type: "int", nullable: false),
                    GraphicsCardLength = table.Column<int>(type: "int", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "Cpu",
                columns: table => new
                {
                    CpuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpuModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocketNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreClock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalCores = table.Column<int>(type: "int", nullable: false),
                    SupportedMemories = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpu", x => x.CpuId);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineLogo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.EngineId);
                });

            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {
                    GpuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportedMemoriesGPU = table.Column<int>(type: "int", nullable: false),
                    GpuModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    Memory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpu", x => x.GpuId);
                });

            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    MemoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    Modules = table.Column<int>(type: "int", nullable: false),
                    Timing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    Delays = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.MemoryId);
                });

            migrationBuilder.CreateTable(
                name: "Motherboard",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotherboardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocketNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    CaseType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboard", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "Psu",
                columns: table => new
                {
                    PsuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PsuModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabling = table.Column<int>(type: "int", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psu", x => x.PsuId);
                });

            migrationBuilder.CreateTable(
                name: "Storge",
                columns: table => new
                {
                    StorgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorgeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSD = table.Column<bool>(type: "bit", nullable: false),
                    ReadSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriteSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interface = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storge", x => x.StorgeId);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfEstablishment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    CompanyDescriptiopn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfWorkers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PcBuilder",
                columns: table => new
                {
                    PcBuilderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpuId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    MemoryId = table.Column<int>(type: "int", nullable: false),
                    StorgeId = table.Column<int>(type: "int", nullable: false),
                    GpuId = table.Column<int>(type: "int", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    PsuId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudioId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "EngineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "StudioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_EngineId",
                table: "Games",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_StudioId",
                table: "Games",
                column: "StudioId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "PcBuilder");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Studios");

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
