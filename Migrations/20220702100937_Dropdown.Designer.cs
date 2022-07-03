﻿// <auto-generated />
using System;
using GameHelperApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameHelperApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220702100937_Dropdown")]
    partial class Dropdown
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("GameHelperApp.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GameHelperApp.Models.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CaseType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GraphicsCardLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfFans")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rgb")
                        .HasColumnType("INTEGER");

                    b.HasKey("CaseId");

                    b.ToTable("Case");
                });

            modelBuilder.Entity("GameHelperApp.Models.Cpu", b =>
                {
                    b.Property<int>("CpuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoreClock")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CpuModel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhysicalCores")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocketNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SupportedMemories")
                        .HasColumnType("INTEGER");

                    b.HasKey("CpuId");

                    b.ToTable("Cpu");
                });

            modelBuilder.Entity("GameHelperApp.Models.Engines", b =>
                {
                    b.Property<int>("EngineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineLogo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("License")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("EngineId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("GameHelperApp.Models.Games", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EnginesEngineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Genre")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudiosStudioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId");

                    b.HasIndex("EnginesEngineId");

                    b.HasIndex("StudiosStudioId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameHelperApp.Models.Gpu", b =>
                {
                    b.Property<int>("GpuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GpuModel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rgb")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SupportedMemoriesGPU")
                        .HasColumnType("INTEGER");

                    b.HasKey("GpuId");

                    b.ToTable("Gpu");
                });

            modelBuilder.Entity("GameHelperApp.Models.Memory", b =>
                {
                    b.Property<int>("MemoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Delays")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MemoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Modules")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Ram")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Rgb")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Timing")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MemoryId");

                    b.ToTable("Memory");
                });

            modelBuilder.Entity("GameHelperApp.Models.Motherboard", b =>
                {
                    b.Property<int>("MotherboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CaseType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MotherboardName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rgb")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SocketNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MotherboardId");

                    b.ToTable("Motherboard");
                });

            modelBuilder.Entity("GameHelperApp.Models.PcBuilder", b =>
                {
                    b.Property<int>("PcBuilderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CpuId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GpuId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MemoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MotherboardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PsuId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StorgeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PcBuilderId");

                    b.HasIndex("CaseId");

                    b.HasIndex("CpuId");

                    b.HasIndex("GpuId");

                    b.HasIndex("MemoryId");

                    b.HasIndex("MotherboardId");

                    b.HasIndex("PsuId");

                    b.HasIndex("StorgeId");

                    b.ToTable("PcBuilder");
                });

            modelBuilder.Entity("GameHelperApp.Models.Psu", b =>
                {
                    b.Property<int>("PsuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cabling")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Power")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("PsuModel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rgb")
                        .HasColumnType("INTEGER");

                    b.HasKey("PsuId");

                    b.ToTable("Psu");
                });

            modelBuilder.Entity("GameHelperApp.Models.Storge", b =>
                {
                    b.Property<int>("StorgeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Interface")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReadSpeed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("SSD")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StorgeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WriteSpeed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StorgeId");

                    b.ToTable("Storge");
                });

            modelBuilder.Entity("GameHelperApp.Models.Studios", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyDescriptiopn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Country")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumberOfWorkers")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("YearOfEstablishment")
                        .HasColumnType("TEXT");

                    b.HasKey("StudioId");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GameHelperApp.Models.Games", b =>
                {
                    b.HasOne("GameHelperApp.Models.Engines", "Engines")
                        .WithMany()
                        .HasForeignKey("EnginesEngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Studios", "Studios")
                        .WithMany()
                        .HasForeignKey("StudiosStudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engines");

                    b.Navigation("Studios");
                });

            modelBuilder.Entity("GameHelperApp.Models.PcBuilder", b =>
                {
                    b.HasOne("GameHelperApp.Models.Case", "Case")
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Cpu", "Cpu")
                        .WithMany()
                        .HasForeignKey("CpuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Gpu", "Gpu")
                        .WithMany()
                        .HasForeignKey("GpuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Memory", "Memory")
                        .WithMany()
                        .HasForeignKey("MemoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Motherboard", "Motherboard")
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Psu", "Psu")
                        .WithMany()
                        .HasForeignKey("PsuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.Storge", "Storge")
                        .WithMany()
                        .HasForeignKey("StorgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Cpu");

                    b.Navigation("Gpu");

                    b.Navigation("Memory");

                    b.Navigation("Motherboard");

                    b.Navigation("Psu");

                    b.Navigation("Storge");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GameHelperApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GameHelperApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameHelperApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GameHelperApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}