using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace SpeakingInBits.Models
{
    public static class IdentityHelper
    {
        public const string InstructorRole = "Instructor";
        public const string StudentRole = "Student";
        public const string AdminRole = "Admin";

        public static async Task SeedRolesAndUser(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await SeedRoles(roleManager);
            await SeedUser(userManager);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            var roles = new[] { InstructorRole, StudentRole, AdminRole };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        private static async Task SeedUser(UserManager<IdentityUser> userManager)
        {
            var adminUser = await userManager.FindByEmailAsync("admin@localhost");
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = "admin@localhost",
                    Email = "admin@localhost"
                };
                await userManager.CreateAsync(adminUser, "P@ssw0rd1");

                // Add admin role to user
                await userManager.AddToRoleAsync(adminUser, AdminRole);
            }
        }
    }
}
