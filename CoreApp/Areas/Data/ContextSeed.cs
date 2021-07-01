using CoreApp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Areas.Data
{
    public static class ContextSeed
    {

        /// <summary>
        /// Seeds default roles to database
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <returns></returns>
        public static async Task SeedRolesAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // Seed default Roles
            await roleManager.CreateAsync(new IdentityRole(AppEnums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AppEnums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AppEnums.Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AppEnums.Roles.Basic.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AppEnums.Roles.Guest.ToString()));
        }

        /// <summary>
        /// Seeds a default SuperAdmin user to database
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <returns></returns>
        public static async Task SeedSuperAdminAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@gmail.com",
                FirstName = "Super",
                LastName = "Admin",
                Company = "XYZ Ltd",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if(userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);

                if(user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin@123");
                    await userManager.AddToRoleAsync(defaultUser, AppEnums.Roles.Guest.ToString());
                    await userManager.AddToRoleAsync(defaultUser, AppEnums.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, AppEnums.Roles.Manager.ToString());
                    await userManager.AddToRoleAsync(defaultUser, AppEnums.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, AppEnums.Roles.SuperAdmin.ToString());
                }
            }

        }

    }
}
