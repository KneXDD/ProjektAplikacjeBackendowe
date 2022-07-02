using GameHelperApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp;

public class AppDbContext:IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    // Creating tables!!! (MY)
    public DbSet<Games> Games { get; set; }
    public DbSet<Studios> Studios { get; set; }
    public DbSet<Engines> Engines { get; set; }
    public DbSet<PcBuilder> PcBuilder { get; set; }
    public DbSet<Case> Case { get; set; }
    
    public DbSet<Cpu> Cpu { get; set; }
    public DbSet<Gpu> Gpu { get; set; }
    public DbSet<Memory> Memory { get; set; }
    public DbSet<Motherboard> Motherboard { get; set; }
    public DbSet<Psu> Psu { get; set; }
    public DbSet<Storge> Storge { get; set; }
    
    public DbSet<AppUser> AppUser { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PcBuilder>(eb =>
        {
            eb.HasOne(c => c.Cpu)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.CpuId);
            
            eb.HasOne(c => c.Motherboard)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.MotherboardId);
            
            eb.HasOne(c => c.Memory)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.MemoryId);
            
            eb.HasOne(c => c.Storge)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.StorgeId);
            
            eb.HasOne(c => c.Gpu)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.GpuId);
            
            eb.HasOne(c => c.Case)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.CaseId);
            
            eb.HasOne(c => c.Psu)
                .WithMany(b => b.PcBuilders)
                .HasForeignKey(k => k.PsuId);
        });
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Games>(eb =>
        {
            eb.HasOne(c => c.Engines)
                .WithMany(b => b.GamesList)
                .HasForeignKey(k => k.EngineId)
                .OnDelete(DeleteBehavior.Cascade);
            eb.HasOne(c => c.Studios)
                .WithMany(b => b.GamesList)
                .HasForeignKey(k => k.StudioId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
    
}