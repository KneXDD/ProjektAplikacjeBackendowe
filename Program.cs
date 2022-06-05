using GameHelperApp;
using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Services configuration (used to be in Startup.cs)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServices<Case>, CaseService>();
builder.Services.AddScoped<IServices<Cpu>, CpuService>();
builder.Services.AddScoped<IServices<Engines>, EnginesService>();
// Creating a database connection. The connection source is taken from appsettings.json (MY)
//Connection String
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("GameHelperDB")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

