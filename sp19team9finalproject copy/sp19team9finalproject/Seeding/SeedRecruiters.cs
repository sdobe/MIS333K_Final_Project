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
    public class SeedRecruiters
    {
        public static async Task SeedAllRecruiters(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (_db.AppUsers.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intRecruitersAdded = 0;
            List<AppUser> Recruiters = new List<AppUser>();

            try
            {

                AppUser ap1 = _db.Users.FirstOrDefault(c => c.Email == "michelle@example.com");
                if (ap1 == null)
                {
                    ap1 = new AppUser();
                    ap1.UserName = "michelle@example.com";
                    ap1.Email = "michelle@example.com";
                    ap1.FirstName = "Michelle";
                    ap1.LastName = "Banks";
                    ap1.Company = _db.Companies.FirstOrDefault(o => o.Name == "Accenture");
                    var result = await _userManager.CreateAsync(ap1, "jVb0Z6");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap1 = _db.Users.FirstOrDefault(c => c.UserName == "michelle@example.com");
                }
                if (await _userManager.IsInRoleAsync(ap1, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap1, "Recruiter");
                }

                AppUser ap2 = _db.Users.FirstOrDefault(c => c.Email == "toddy@aool.com");
                if (ap2 == null)
                {
                    ap2 = new AppUser();
                    ap2.UserName = "toddy@aool.com";
                    ap2.Email = "toddy@aool.com";
                    ap2.FirstName = "Todd";
                    ap2.LastName = "Jacobs";
                    ap2.Company = _db.Companies.FirstOrDefault(o => o.Name == "Accenture");
                    var result = await _userManager.CreateAsync(ap2, "1PnrBV");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap2 = _db.Users.FirstOrDefault(c => c.UserName == "toddy@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap2, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap2, "Recruiter");
                }

                AppUser ap3 = _db.Users.FirstOrDefault(c => c.Email == "elowe@netscrape.net");
                if (ap3 == null)
                {
                    ap3 = new AppUser();
                    ap3.UserName = "elowe@netscrape.net";
                    ap3.Email = "elowe@netscrape.net";
                    ap3.FirstName = "Ernest";
                    ap3.LastName = "Lowe";
                    ap3.Company = _db.Companies.FirstOrDefault(o => o.Name == "Shell");
                    var result = await _userManager.CreateAsync(ap3, "v3n5AV");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap3 = _db.Users.FirstOrDefault(c => c.UserName == "elowe@netscrape.net");
                }
                if (await _userManager.IsInRoleAsync(ap3, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap3, "Recruiter");
                }

                AppUser ap4 = _db.Users.FirstOrDefault(c => c.Email == "mclarence@aool.com");
                if (ap4 == null)
                {
                    ap4 = new AppUser();
                    ap4.UserName = "mclarence@aool.com";
                    ap4.Email = "mclarence@aool.com";
                    ap4.FirstName = "Clarence";
                    ap4.LastName = "Martin";
                    ap4.Company = _db.Companies.FirstOrDefault(o => o.Name == "Deloitte");
                    var result = await _userManager.CreateAsync(ap4, "zBLq3S");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap4 = _db.Users.FirstOrDefault(c => c.UserName == "mclarence@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap4, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap4, "Recruiter");
                }

                AppUser ap5 = _db.Users.FirstOrDefault(c => c.Email == "nelson.Kelly@aool.com");
                if (ap5 == null)
                {
                    ap5 = new AppUser();
                    ap5.UserName = "nelson.Kelly@aool.com";
                    ap5.Email = "nelson.Kelly@aool.com";
                    ap5.FirstName = "Kelly";
                    ap5.LastName = "Nelson";
                    ap5.Company = _db.Companies.FirstOrDefault(o => o.Name == "Deloitte");
                    var result = await _userManager.CreateAsync(ap5, "FSb8rA");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap5 = _db.Users.FirstOrDefault(c => c.UserName == "nelson.Kelly@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap5, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap5, "Recruiter");
                }

                AppUser ap6 = _db.Users.FirstOrDefault(c => c.Email == "megrhodes@freezing.co.uk");
                if (ap6 == null)
                {
                    ap6 = new AppUser();
                    ap6.UserName = "megrhodes@freezing.co.uk";
                    ap6.Email = "megrhodes@freezing.co.uk";
                    ap6.FirstName = "Megan";
                    ap6.LastName = "Rhodes";
                    ap6.Company = _db.Companies.FirstOrDefault(o => o.Name == "Deloitte");
                    var result = await _userManager.CreateAsync(ap6, "1xVfHp");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap6 = _db.Users.FirstOrDefault(c => c.UserName == "megrhodes@freezing.co.uk");
                }
                if (await _userManager.IsInRoleAsync(ap6, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap6, "Recruiter");
                }

                AppUser ap7 = _db.Users.FirstOrDefault(c => c.Email == "sheff44@ggmail.com");
                if (ap7 == null)
                {
                    ap7 = new AppUser();
                    ap7.UserName = "sheff44@ggmail.com";
                    ap7.Email = "sheff44@ggmail.com";
                    ap7.FirstName = "Martin";
                    ap7.LastName = "Sheffield";
                    ap7.Company = _db.Companies.FirstOrDefault(o => o.Name == "Texas Instruments");
                    var result = await _userManager.CreateAsync(ap7, "4XKLsd");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap7 = _db.Users.FirstOrDefault(c => c.UserName == "sheff44@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap7, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap7, "Recruiter");
                }

                AppUser ap8 = _db.Users.FirstOrDefault(c => c.Email == "peterstump@hootmail.com");
                if (ap8 == null)
                {
                    ap8 = new AppUser();
                    ap8.UserName = "peterstump@hootmail.com";
                    ap8.Email = "peterstump@hootmail.com";
                    ap8.FirstName = "Peter";
                    ap8.LastName = "Stump";
                    ap8.Company = _db.Companies.FirstOrDefault(o => o.Name == "Texas Instruments");
                    var result = await _userManager.CreateAsync(ap8, "1XdmSV");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap8 = _db.Users.FirstOrDefault(c => c.UserName == "peterstump@hootmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap8, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap8, "Recruiter");
                }

                AppUser ap9 = _db.Users.FirstOrDefault(c => c.Email == "yhuik9.Taylor@aool.com");
                if (ap9 == null)
                {
                    ap9 = new AppUser();
                    ap9.UserName = "yhuik9.Taylor@aool.com";
                    ap9.Email = "yhuik9.Taylor@aool.com";
                    ap9.FirstName = "Rachel";
                    ap9.LastName = "Taylor";
                    ap9.Company = _db.Companies.FirstOrDefault(o => o.Name == "Hilton Worldwide");
                    var result = await _userManager.CreateAsync(ap9, "9yhFS3");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap9 = _db.Users.FirstOrDefault(c => c.UserName == "yhuik9.Taylor@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap9, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap9, "Recruiter");
                }

                AppUser ap10 = _db.Users.FirstOrDefault(c => c.Email == "tuck33@ggmail.com");
                if (ap10 == null)
                {
                    ap10 = new AppUser();
                    ap10.UserName = "tuck33@ggmail.com";
                    ap10.Email = "tuck33@ggmail.com";
                    ap10.FirstName = "Clent";
                    ap10.LastName = "Tucker";
                    ap10.Company = _db.Companies.FirstOrDefault(o => o.Name == "Aon");
                    var result = await _userManager.CreateAsync(ap10, "I6BgsS");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap10 = _db.Users.FirstOrDefault(c => c.UserName == "tuck33@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap10, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap10, "Recruiter");
                }

                AppUser ap11 = _db.Users.FirstOrDefault(c => c.Email == "taylordjay@aool.com");
                if (ap11 == null)
                {
                    ap11 = new AppUser();
                    ap11.UserName = "taylordjay@aool.com";
                    ap11.Email = "taylordjay@aool.com";
                    ap11.FirstName = "Allison";
                    ap11.LastName = "Taylor";
                    ap11.Company = _db.Companies.FirstOrDefault(o => o.Name == "Adlucent");
                    var result = await _userManager.CreateAsync(ap11, "Vjb1wI");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap11 = _db.Users.FirstOrDefault(c => c.UserName == "taylordjay@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap11, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap11, "Recruiter");
                }

                AppUser ap12 = _db.Users.FirstOrDefault(c => c.Email == "jojoe@ggmail.com");
                if (ap12 == null)
                {
                    ap12 = new AppUser();
                    ap12.UserName = "jojoe@ggmail.com";
                    ap12.Email = "jojoe@ggmail.com";
                    ap12.FirstName = "Joe";
                    ap12.LastName = "Nguyen";
                    ap12.Company = _db.Companies.FirstOrDefault(o => o.Name == "Stream Realty Partners");
                    var result = await _userManager.CreateAsync(ap12, "xI8Brg");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap12 = _db.Users.FirstOrDefault(c => c.UserName == "jojoe@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap12, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap12, "Recruiter");
                }

                AppUser ap13 = _db.Users.FirstOrDefault(c => c.Email == "hicks43@ggmail.com");
                if (ap13 == null)
                {
                    ap13 = new AppUser();
                    ap13.UserName = "hicks43@ggmail.com";
                    ap13.Email = "hicks43@ggmail.com";
                    ap13.FirstName = "Anthony";
                    ap13.LastName = "Hicks";
                    ap13.Company = _db.Companies.FirstOrDefault(o => o.Name == "Microsoft");
                    var result = await _userManager.CreateAsync(ap13, "s33WOz");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap13 = _db.Users.FirstOrDefault(c => c.UserName == "hicks43@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap13, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap13, "Recruiter");
                }

                AppUser ap14 = _db.Users.FirstOrDefault(c => c.Email == "orielly@foxnets.com");
                if (ap14 == null)
                {
                    ap14 = new AppUser();
                    ap14.UserName = "orielly@foxnets.com";
                    ap14.Email = "orielly@foxnets.com";
                    ap14.FirstName = "Bill";
                    ap14.LastName = "O'Reilly";
                    ap14.Company = _db.Companies.FirstOrDefault(o => o.Name == "Microsoft");
                    var result = await _userManager.CreateAsync(ap14, "pS2OJh");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap14 = _db.Users.FirstOrDefault(c => c.UserName == "orielly@foxnets.com");
                }
                if (await _userManager.IsInRoleAsync(ap14, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap14, "Recruiter");
                }

                AppUser ap15 = _db.Users.FirstOrDefault(c => c.Email == "louielouie@aool.com");
                if (ap15 == null)
                {
                    ap15 = new AppUser();
                    ap15.UserName = "louielouie@aool.com";
                    ap15.Email = "louielouie@aool.com";
                    ap15.FirstName = "Louis";
                    ap15.LastName = "Winthorpe";
                    ap15.Company = _db.Companies.FirstOrDefault(o => o.Name == "Microsoft");
                    var result = await _userManager.CreateAsync(ap15, "fq7yDw");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap15 = _db.Users.FirstOrDefault(c => c.UserName == "louielouie@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap15, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap15, "Recruiter");
                }

                AppUser ap16 = _db.Users.FirstOrDefault(c => c.Email == "smartinmartin.Martin@aool.com");
                if (ap16 == null)
                {
                    ap16 = new AppUser();
                    ap16.UserName = "smartinmartin.Martin@aool.com";
                    ap16.Email = "smartinmartin.Martin@aool.com";
                    ap16.FirstName = "Gregory";
                    ap16.LastName = "Martinez";
                    ap16.Company = _db.Companies.FirstOrDefault(o => o.Name == "Capital One");
                    var result = await _userManager.CreateAsync(ap16, "1rKkMW");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap16 = _db.Users.FirstOrDefault(c => c.UserName == "smartinmartin.Martin@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap16, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap16, "Recruiter");
                }

                AppUser ap17 = _db.Users.FirstOrDefault(c => c.Email == "or@aool.com");
                if (ap17 == null)
                {
                    ap17 = new AppUser();
                    ap17.UserName = "or@aool.com";
                    ap17.Email = "or@aool.com";
                    ap17.FirstName = "Anka";
                    ap17.LastName = "Radkovich";
                    ap17.Company = _db.Companies.FirstOrDefault(o => o.Name == "Capital One");
                    var result = await _userManager.CreateAsync(ap17, "8K0cAh");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap17 = _db.Users.FirstOrDefault(c => c.UserName == "or@aool.com");
                }
                if (await _userManager.IsInRoleAsync(ap17, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap17, "Recruiter");
                }

                AppUser ap18 = _db.Users.FirstOrDefault(c => c.Email == "tanner@ggmail.com");
                if (ap18 == null)
                {
                    ap18 = new AppUser();
                    ap18.UserName = "tanner@ggmail.com";
                    ap18.Email = "tanner@ggmail.com";
                    ap18.FirstName = "Jeremy";
                    ap18.LastName = "Tanner";
                    ap18.Company = _db.Companies.FirstOrDefault(o => o.Name == "United Airlines");
                    var result = await _userManager.CreateAsync(ap18, "w9wPff");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap18 = _db.Users.FirstOrDefault(c => c.UserName == "tanner@ggmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap18, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap18, "Recruiter");
                }

                AppUser ap19 = _db.Users.FirstOrDefault(c => c.Email == "tee_frank@hootmail.com");
                if (ap19 == null)
                {
                    ap19 = new AppUser();
                    ap19.UserName = "tee_frank@hootmail.com";
                    ap19.Email = "tee_frank@hootmail.com";
                    ap19.FirstName = "Frank";
                    ap19.LastName = "Tee";
                    ap19.Company = _db.Companies.FirstOrDefault(o => o.Name == "Academy Sports & Outdoors");
                    var result = await _userManager.CreateAsync(ap19, "1EIwbx");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap19 = _db.Users.FirstOrDefault(c => c.UserName == "tee_frank@hootmail.com");
                }
                if (await _userManager.IsInRoleAsync(ap19, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap19, "Recruiter");
                }

                AppUser ap20 = _db.Users.FirstOrDefault(c => c.Email == "target_spot@example.com");
                if (ap20 == null)
                {
                    ap20 = new AppUser();
                    ap20.UserName = "target_spot@example.com";
                    ap20.Email = "target_spot@example.com";
                    ap20.FirstName = "Spot";
                    ap20.LastName = "Dog";
                    ap20.Company = _db.Companies.FirstOrDefault(o => o.Name == "Target");
                    var result = await _userManager.CreateAsync(ap20, "spotthedog");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    ap20 = _db.Users.FirstOrDefault(c => c.UserName == "target_spot@example.com");
                }
                if (await _userManager.IsInRoleAsync(ap20, "Recruiter") == false)
                {
                    await _userManager.AddToRoleAsync(ap20, "Recruiter");
                }


            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
