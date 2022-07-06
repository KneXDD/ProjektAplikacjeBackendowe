using GameHelperApp;
using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Services configuration (used to be in Startup.cs)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServices<Case>, CaseService>();
builder.Services.AddScoped<IServices<Cpu>, CpuService>();
builder.Services.AddScoped<IServices<Engines>, EnginesService>();
builder.Services.AddScoped<IGameService, GamesService>();
builder.Services.AddScoped<IServices<Gpu>, GpuService>();
builder.Services.AddScoped<IServices<Memory>, MemoryService>();
builder.Services.AddScoped<IServices<Motherboard>, MotherboardService>();
builder.Services.AddScoped<IPcBuilderService, PcBuilderService>();
builder.Services.AddScoped<IServices<Psu>, PsuService>();
builder.Services.AddScoped<IServices<Storge>, StorgeService>();
builder.Services.AddScoped<IServices<Studios>, StudiosService>();
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddScoped<Initializer>();
builder.Services.AddAuthentication(x =>
{
    x.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});
// Creating a database connection. The connection source is taken from appsettings.json (MY)
//Connection String
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameHelperDB")));
var app = builder.Build();
var scopee = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
var scope = app.Services.CreateScope().ServiceProvider.GetRequiredService<Initializer>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
scopee.Database.Migrate();
scope.SeedUsersAndRolesAsync(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

//Autorization
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();