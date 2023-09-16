using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebTechLabs.Entities;
using WebTechLabs.Data;
using WebTechLabs.Entities;

namespace WebTechLabs.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // создать БД, если она еще не создана
            context.Database.EnsureCreated();
            // проверка наличия ролей
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль admin
                await roleManager.CreateAsync(roleAdmin);
            }
            // проверка наличия пользователей
            if (!context.Users.Any())
            {
                // создать пользователя user@mail.ru
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");
                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                // назначить роль admin
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }

            //проверка наличия групп объектов
            if (!context.DishGroups.Any())
            {
                context.DishGroups.AddRange(
                new List<DishGroup>
                {
                    new DishGroup {GroupName="Гарниры"},
                    new DishGroup {GroupName="Основные блюда"},
                    new DishGroup {GroupName="Закуски"},
                    new DishGroup {GroupName="Десерты"},
                    new DishGroup {GroupName="Напитки"}
                });
                await context.SaveChangesAsync();
            }
            // проверка наличия объектов
            if (!context.Dishes.Any())
            {
                context.Dishes.AddRange(
                new List<Dish>
                {
                    new Dish { DishName="Макароны", Description="ОЧень дешево", Calories = 200, DishGroupId=2, Image="pasta.jpg" },
                    new Dish { DishName="Пицца", Description="Очень по-итальянски", Calories = 500, DishGroupId=2, Image="pizza.jpg" },
                    new Dish { DishName="Сало", Description="Жирно и сердито", Calories = 700, DishGroupId=3, Image="salo.jpg" },
                    new Dish { DishName="Кот", Description="С блохами", Calories =450, DishGroupId=3, Image="cat.jpg" },
                    new Dish { DishName="Чай", Description="250мл влаги", Calories =180, DishGroupId=4, Image="tea.jpg" }
                });
                await context.SaveChangesAsync();
            }

        }
    }
}
