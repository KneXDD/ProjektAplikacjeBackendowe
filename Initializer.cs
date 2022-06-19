using GameHelperApp.Models;
using GameHelperApp.Static;
using Microsoft.AspNetCore.Identity;

namespace GameHelperApp;

public class Initializer
{
    public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            
            //Role
            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            
            //User
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            string adminEmail = "admin@wsei.pl";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var newAdminUser = new AppUser()
                {
                    FullName = "Admin admin",
                    UserName = "Admin",
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newAdminUser, "Qazxsw12345!");
                await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
            }

            string userEmail = "user@wsei.pl";
            var userUser = await userManager.FindByEmailAsync(userEmail);
            if (userUser == null)
            {
                var newUserUser = new AppUser()
                {
                    FullName = "User user",
                    UserName = "User",
                    Email = userEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newUserUser, "Qazxsw12345!");
                await userManager.AddToRoleAsync(newUserUser, UserRoles.User);
            }
            
        }
    }
}