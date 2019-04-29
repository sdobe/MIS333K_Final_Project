using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

//: Change these using statements to match your project
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

//: Change this namespace to match your project
namespace sp19team9finalproject.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //: Add the needed roles
            //if role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("CSO") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("CSO"));
            }

            if (await _roleManager.RoleExistsAsync("Student") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Student"));
            }

            if (await _roleManager.RoleExistsAsync("Recruiter") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Recruiter"));
            }

            //check to see if the manager has been added
            AppUser manager = _db.Users.FirstOrDefault(u => u.Email == "admin@example.com");

            //if manager hasn't been created, then add them
           
            if (manager == null)
            {
                manager = new AppUser();
                manager.UserName = "admin@example.com";
                manager.Email = "admin@example.com";
                manager.FirstName = "Admin";
                manager.LastName = "Admin";
                
                //TODO: Add additional fields that you created on the AppUser class


                var result = await _userManager.CreateAsync(manager, "Abc123!");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                manager = _db.Users.FirstOrDefault(u => u.UserName == "admin@example.com");
            }

            //make sure user is in role
            if (await _userManager.IsInRoleAsync(manager, "Manager") == false)
            {
                await _userManager.AddToRoleAsync(manager, "Manager");
            }

            //save changes
            _db.SaveChanges();
        }

    }
}