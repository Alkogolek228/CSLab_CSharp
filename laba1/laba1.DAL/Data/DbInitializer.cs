using laba1.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace laba1.DAL
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await CreateRolesAsync(roleManager);
            await CreateUsersAsync(userManager);
        }

        private static async Task CreateRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("admin"))
            {
                var adminRole = new IdentityRole("admin");
                await roleManager.CreateAsync(adminRole);
            }
        }

        private static async Task CreateUsersAsync(UserManager<ApplicationUser> userManager)
        {
            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@example.com"
                };

                await userManager.CreateAsync(adminUser, "Password"); 
                await userManager.AddToRoleAsync(adminUser, "admin");
            }

            // Создаем еще как минимум одного пользователя без роли "admin" по аналогии
        }
    }
}
