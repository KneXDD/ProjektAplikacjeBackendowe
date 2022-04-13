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
}