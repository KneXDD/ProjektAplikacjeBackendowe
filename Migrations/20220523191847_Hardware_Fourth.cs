using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHelperApp.Migrations
{
    public partial class Hardware_Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Storge",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Interface",
                table: "Storge",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Storge",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Storge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReadSpeed",
                table: "Storge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "SSD",
                table: "Storge",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StorgeName",
                table: "Storge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WriteSpeed",
                table: "Storge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Cabling",
                table: "Psu",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "Psu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Psu",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PsuModel",
                table: "Psu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Rgb",
                table: "Psu",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CaseType",
                table: "Motherboard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherboardName",
                table: "Motherboard",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Motherboard",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Motherboard",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Rgb",
                table: "Motherboard",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SocketNumber",
                table: "Motherboard",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Delays",
                table: "Memory",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MemoryName",
                table: "Memory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Modules",
                table: "Memory",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Memory",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Memory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Ram",
                table: "Memory",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Rgb",
                table: "Memory",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Timing",
                table: "Memory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Gpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GpuModel",
                table: "Gpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Memory",
                table: "Gpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Gpu",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Rgb",
                table: "Gpu",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SupportedMemoriesGPU",
                table: "Gpu",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CoreClock",
                table: "Cpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CpuModel",
                table: "Cpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PhysicalCores",
                table: "Cpu",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cpu",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SocketNumber",
                table: "Cpu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SupportedMemories",
                table: "Cpu",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CaseType",
                table: "Case",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GraphicsCardLength",
                table: "Case",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Case",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFans",
                table: "Case",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Case",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Case",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Rgb",
                table: "Case",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "Interface",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "ReadSpeed",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "SSD",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "StorgeName",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "WriteSpeed",
                table: "Storge");

            migrationBuilder.DropColumn(
                name: "Cabling",
                table: "Psu");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Psu");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Psu");

            migrationBuilder.DropColumn(
                name: "PsuModel",
                table: "Psu");

            migrationBuilder.DropColumn(
                name: "Rgb",
                table: "Psu");

            migrationBuilder.DropColumn(
                name: "CaseType",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "MotherboardName",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "Rgb",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "SocketNumber",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "Delays",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "MemoryName",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Modules",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Rgb",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Timing",
                table: "Memory");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "GpuModel",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "Rgb",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "SupportedMemoriesGPU",
                table: "Gpu");

            migrationBuilder.DropColumn(
                name: "CoreClock",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "CpuModel",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "PhysicalCores",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "SocketNumber",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "SupportedMemories",
                table: "Cpu");

            migrationBuilder.DropColumn(
                name: "CaseType",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "GraphicsCardLength",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "NumberOfFans",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Rgb",
                table: "Case");
        }
    }
}
