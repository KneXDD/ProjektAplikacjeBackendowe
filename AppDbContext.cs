using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp;

public class AppDbContext:DbContext
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
    
}