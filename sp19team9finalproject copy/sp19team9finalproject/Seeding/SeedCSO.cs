using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public static class SeedCSO
    {
        public static async Task SeedAllCSO(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            Int32 intCSOAdded = 0;
            List<AppUser> CSOs = new List<AppUser>();

            try
            {

                AppUser ap1 = _db.Users.FirstOrDefault(c => c.Email == "ra@aoo.com");
                if (ap1 == null)
                {
                    ap1 = new AppUser();
                    ap1.UserName = "ra@aoo.com";
                    ap1.Email = "ra@aoo.com";
                    ap1.FirstName = "Allen";
                    ap1.LastName = "Rogers";

                    var result = await _userManager.CreateAsync(ap1, "3wCynC");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap1 = _db.Users.FirstOrDefault(c => c.UserName == "ra@aoo.com");
                }
                if (await _userManager.IsInRoleAsync(ap1, "CSO") == false)
                {
                    await _userManager.AddToRoleAsync(ap1, "CSO");
                }

                AppUser ap2 = _db.Users.FirstOrDefault(c => c.Email == "rwood@voyager.net");
                if (ap2 == null)
                {
                    ap2 = new AppUser();
                    ap2.UserName = "rwood@voyager.net";
                    ap2.Email = "rwood@voyager.net";
                    ap2.FirstName = "Reagan";
                    ap2.LastName = "Wood";

                    var result = await _userManager.CreateAsync(ap2, "Pbon0r");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap2 = _db.Users.FirstOrDefault(c => c.UserName == "rwood@voyager.net");
                }
                if (await _userManager.IsInRoleAsync(ap2, "CSO") == false)
                {
                    await _userManager.AddToRoleAsync(ap2, "CSO");
                }

                AppUser ap3 = _db.Users.FirstOrDefault(c => c.Email == "westj@pioneer.net");
                if (ap3 == null)
                {
                    ap3 = new AppUser();
                    ap3.UserName = "westj@pioneer.net";
                    ap3.Email = "westj@pioneer.net";
                    ap3.FirstName = "Jake";
                    ap3.LastName = "West";

                    var result = await _userManager.CreateAsync(ap3, "jW5fPP");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap3 = _db.Users.FirstOrDefault(c => c.UserName == "westj@pioneer.net");
                }
                if (await _userManager.IsInRoleAsync(ap3, "CSO") == false)
                {
                    await _userManager.AddToRoleAsync(ap3, "CSO");
                }

                AppUser ap4 = _db.Users.FirstOrDefault(c => c.Email == "liz@ggmail.com");
                if (ap4 == null)
                {
                    ap4 = new AppUser();
                    ap4.UserName = "liz@ggmail.com";
                    ap4.Email = "liz@ggmail.com";
                    ap4.FirstName = "Elizabeth";
                    ap4.LastName = "Markham";

                    var result = await _userManager.CreateAsync(ap4, "0QyilL");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap4 = _db.Users.FirstOrDefault(c => c.UserName == "liz@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap4, "CSO") == false)
                {
                    await _userManager.AddToRoleAsync(ap4, "CSO");
                }

                AppUser ap5 = _db.Users.FirstOrDefault(c => c.Email == "chaley@thug.com");
                if (ap5 == null)
                {
                    ap5 = new AppUser();
                    ap5.UserName = "chaley@thug.com";
                    ap5.Email = "chaley@thug.com";
                    ap5.FirstName = "Charles";
                    ap5.LastName = "Haley";

                    var result = await _userManager.CreateAsync(ap5, "atLm6W");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap5 = _db.Users.FirstOrDefault(c => c.UserName == "chaley@thug.com");
                }
                if (await _userManager.IsInRoleAsync(ap5, "CSO") == false)
                {
                    await _userManager.AddToRoleAsync(ap5, "CSO");
                }

            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
