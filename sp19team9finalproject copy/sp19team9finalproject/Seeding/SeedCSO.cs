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
                AppUser ap1 = new AppUser()
                {
                    Email = "ra@aoo.com",
                    PasswordHash = "3wCynC",
                    FirstName = "Allen",
                    LastName = "Rogers"
                };
                await _userManager.AddToRoleAsync(ap1, "CSO");
                CSOs.Add(ap1);

                AppUser ap2 = new AppUser()
                {
                    Email = "rwood@voyager.net",
                    PasswordHash = "Pbon0r",
                    FirstName = "Reagan",
                    LastName = "Wood"
                };
                await _userManager.AddToRoleAsync(ap2, "CSO");
                CSOs.Add(ap2);

                AppUser ap3 = new AppUser()
                {
                    Email = "westj@pioneer.net",
                    PasswordHash = "jW5fPP",
                    FirstName = "Jake",
                    LastName = "West"
                };
                await _userManager.AddToRoleAsync(ap3, "CSO");
                CSOs.Add(ap3);

                AppUser ap4 = new AppUser()
                {
                    Email = "liz@ggmail.com",
                    PasswordHash = "0QyilL",
                    FirstName = "Elizabeth",
                    LastName = "Markham"
                };
                await _userManager.AddToRoleAsync(ap4, "CSO");
                CSOs.Add(ap4);

                AppUser ap5 = new AppUser()
                {
                    Email = "chaley@thug.com",
                    PasswordHash = "atLm6W",
                    FirstName = "Charles",
                    LastName = "Haley"
                };
               await _userManager.AddToRoleAsync(ap5, "CSO");
                CSOs.Add(ap5);

                try
                {
                    foreach (AppUser CSOToAdd in CSOs)
                    {
                        string strMajorName = CSOToAdd.FirstName;
                        AppUser _dbCSO =  _db.AppUsers.FirstOrDefault(m => m.Email == CSOToAdd.Email);

                        if (_dbCSO == null)
                        {
                            _db.AppUsers.Add(CSOToAdd);
                            _db.SaveChanges();
                            intCSOAdded += 1;
                        }
                        else
                        {
                            _dbCSO.FirstName = CSOToAdd.FirstName;
                            _dbCSO.LastName = CSOToAdd.LastName;
                            _dbCSO.PasswordHash = CSOToAdd.PasswordHash;
                            _dbCSO.Email = CSOToAdd.Email;
                            _db.Update(_dbCSO);
                            _db.SaveChanges();
                            intCSOAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intCSOAdded + "; ";

                    throw new InvalidOperationException(ex.Message + msg);

                }
            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
