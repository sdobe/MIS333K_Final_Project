using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;
using Microsoft.Extensions.DependencyInjection;

namespace sp19team9finalproject.Seeding
{
    public static class SeedStudents
    {

        public static async Task SeedAllStudents(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (_db.AppUsers.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intStudentsAdded = 0;
            List<AppUser> Students = new List<AppUser>();

            try
            {

                AppUser a1 = _db.Users.FirstOrDefault(c => c.Email == "cbaker@example.com");
                if (a1 == null)
                {
                    a1 = new AppUser();
                    a1.UserName = "cbaker@example.com";
                    a1.Email = "cbaker@example.com";
                    a1.FirstName = "Christopher";
                    a1.LastName = "Baker";
                    a1.GradDate = new DateTime(2019);
                    a1.PositionType = PositionType.FullTime;
                    a1.GPA = 3.91m;
                    a1.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a1, "bookworm");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a1 = _db.Users.FirstOrDefault(c => c.UserName == "cbaker@example.com");
                }
                if (await _userManager.IsInRoleAsync(a1, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a1, "Student");
                }

                AppUser a2 = _db.Users.FirstOrDefault(c => c.Email == "banker@longhorn.net");
                if (a2 == null)
                {
                    a2 = new AppUser();
                    a2.UserName = "banker@longhorn.net";
                    a2.Email = "banker@longhorn.net";
                    a2.FirstName = "Michelle";
                    a2.LastName = "Banks";
                    a2.GradDate = new DateTime(2020);
                    a2.PositionType = PositionType.Internship;
                    a2.GPA = 3.52m;
                    a2.Major = _db.Majors.FirstOrDefault(o => o.Name == "International Business");

                    var result = await _userManager.CreateAsync(a2, "aclfest2017");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a2 = _db.Users.FirstOrDefault(c => c.UserName == "banker@longhorn.net");
                }
                if (await _userManager.IsInRoleAsync(a2, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a2, "Student");
                }

                AppUser a3 = _db.Users.FirstOrDefault(c => c.Email == "franco@example.com");
                if (a3 == null)
                {
                    a3 = new AppUser();
                    a3.UserName = "franco@example.com";
                    a3.Email = "franco@example.com";
                    a3.FirstName = "Franco";
                    a3.LastName = "Broccolo";
                    a3.GradDate = new DateTime(2019);
                    a3.PositionType = PositionType.FullTime;
                    a3.GPA = 3.2m;
                    a3.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a3, "aggies");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a3 = _db.Users.FirstOrDefault(c => c.UserName == "franco@example.com");
                }
                if (await _userManager.IsInRoleAsync(a3, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a3, "Student");
                }

                AppUser a4 = _db.Users.FirstOrDefault(c => c.Email == "wchang@example.com");
                if (a4 == null)
                {
                    a4 = new AppUser();
                    a4.UserName = "wchang@example.com";
                    a4.Email = "wchang@example.com";
                    a4.FirstName = "Wendy";
                    a4.LastName = "Chang";
                    a4.GradDate = new DateTime(2021);
                    a4.PositionType = PositionType.Internship;
                    a4.GPA = 3.56m;
                    a4.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a4, "alaskaboy");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a4 = _db.Users.FirstOrDefault(c => c.UserName == "wchang@example.com");
                }
                if (await _userManager.IsInRoleAsync(a4, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a4, "Student");
                }

                AppUser a5 = _db.Users.FirstOrDefault(c => c.Email == "limchou@gogle.com");
                if (a5 == null)
                {
                    a5 = new AppUser();
                    a5.UserName = "limchou@gogle.com";
                    a5.Email = "limchou@gogle.com";
                    a5.FirstName = "Lim";
                    a5.LastName = "Chou";
                    a5.GradDate = new DateTime(2020);
                    a5.PositionType = PositionType.Internship;
                    a5.GPA = 2.63m;
                    a5.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a5, "allyrally");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a5 = _db.Users.FirstOrDefault(c => c.UserName == "limchou@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a5, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a5, "Student");
                }

                AppUser a6 = _db.Users.FirstOrDefault(c => c.Email == "shdixon@aoll.com");
                if (a6 == null)
                {
                    a6 = new AppUser();
                    a6.UserName = "shdixon@aoll.com";
                    a6.Email = "shdixon@aoll.com";
                    a6.FirstName = "Shan";
                    a6.LastName = "Dixon";
                    a6.GradDate = new DateTime(2022);
                    a6.PositionType = PositionType.Internship;
                    a6.GPA = 3.62m;
                    a6.Major = _db.Majors.FirstOrDefault(o => o.Name == "International Business");

                    var result = await _userManager.CreateAsync(a6, "Anchorage");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a6 = _db.Users.FirstOrDefault(c => c.UserName == "shdixon@aoll.com");
                }
                if (await _userManager.IsInRoleAsync(a6, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a6, "Student");
                }

                AppUser a7 = _db.Users.FirstOrDefault(c => c.Email == "j.b.evans@aheca.org");
                if (a7 == null)
                {
                    a7 = new AppUser();
                    a7.UserName = "j.b.evans@aheca.org";
                    a7.Email = "j.b.evans@aheca.org";
                    a7.FirstName = "Jim Bob";
                    a7.LastName = "Evans";
                    a7.GradDate = new DateTime(2019);
                    a7.PositionType = PositionType.FullTime;
                    a7.GPA = 2.64m;
                    a7.Major = _db.Majors.FirstOrDefault(o => o.Name == "Accounting");

                    var result = await _userManager.CreateAsync(a7, "billyboy");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a7 = _db.Users.FirstOrDefault(c => c.UserName == "j.b.evans@aheca.org");
                }
                if (await _userManager.IsInRoleAsync(a7, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a7, "Student");
                }

                AppUser a8 = _db.Users.FirstOrDefault(c => c.Email == "feeley@penguin.org");
                if (a8 == null)
                {
                    a8 = new AppUser();
                    a8.UserName = "feeley@penguin.org";
                    a8.Email = "feeley@penguin.org";
                    a8.FirstName = "Lou Ann";
                    a8.LastName = "Feeley";
                    a8.GradDate = new DateTime(2020);
                    a8.PositionType = PositionType.Internship;
                    a8.GPA = 3.66m;
                    a8.Major = _db.Majors.FirstOrDefault(o => o.Name == "Marketing");

                    var result = await _userManager.CreateAsync(a8, "bunnyhop");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a8 = _db.Users.FirstOrDefault(c => c.UserName == "feeley@penguin.org");
                }
                if (await _userManager.IsInRoleAsync(a8, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a8, "Student");
                }

                AppUser a9 = _db.Users.FirstOrDefault(c => c.Email == "tfreeley@minnetonka.ci.us");
                if (a9 == null)
                {
                    a9 = new AppUser();
                    a9.UserName = "tfreeley@minnetonka.ci.us";
                    a9.Email = "tfreeley@minnetonka.ci.us";
                    a9.FirstName = "Tesa";
                    a9.LastName = "Freeley";
                    a9.GradDate = new DateTime(2019);
                    a9.PositionType = PositionType.FullTime;
                    a9.GPA = 3.98m;
                    a9.Major = _db.Majors.FirstOrDefault(o => o.Name == "Accounting");

                    var result = await _userManager.CreateAsync(a9, "dustydusty");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a9 = _db.Users.FirstOrDefault(c => c.UserName == "tfreeley@minnetonka.ci.us");
                }
                if (await _userManager.IsInRoleAsync(a9, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a9, "Student");
                }

                AppUser a10 = _db.Users.FirstOrDefault(c => c.Email == "mgarcia@gogle.com");
                if (a10 == null)
                {
                    a10 = new AppUser();
                    a10.UserName = "mgarcia@gogle.com";
                    a10.Email = "mgarcia@gogle.com";
                    a10.FirstName = "Margaret";
                    a10.LastName = "Garcia";
                    a10.GradDate = new DateTime(2019);
                    a10.PositionType = PositionType.FullTime;
                    a10.GPA = 3.22m;
                    a10.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a10, "gowest");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a10 = _db.Users.FirstOrDefault(c => c.UserName == "mgarcia@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a10, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a10, "Student");
                }

                AppUser a11 = _db.Users.FirstOrDefault(c => c.Email == "jeffh@sonic.com");
                if (a11 == null)
                {
                    a11 = new AppUser();
                    a11.UserName = "jeffh@sonic.com";
                    a11.Email = "jeffh@sonic.com";
                    a11.FirstName = "Jeffrey";
                    a11.LastName = "Hampton";
                    a11.GradDate = new DateTime(2020);
                    a11.PositionType = PositionType.Internship;
                    a11.GPA = 3.66m;
                    a11.Major = _db.Majors.FirstOrDefault(o => o.Name == "Science and Technology Management");

                    var result = await _userManager.CreateAsync(a11, "hickhickup");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a11 = _db.Users.FirstOrDefault(c => c.UserName == "jeffh@sonic.com");
                }
                if (await _userManager.IsInRoleAsync(a11, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a11, "Student");
                }

                AppUser a12 = _db.Users.FirstOrDefault(c => c.Email == "wjhearniii@umich.org");
                if (a12 == null)
                {
                    a12 = new AppUser();
                    a12.UserName = "wjhearniii@umich.org";
                    a12.Email = "wjhearniii@umich.org";
                    a12.FirstName = "John";
                    a12.LastName = "Hearn";
                    a12.GradDate = new DateTime(2019);
                    a12.PositionType = PositionType.FullTime;
                    a12.GPA = 3.46m;
                    a12.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a12, "ingram2015");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a12 = _db.Users.FirstOrDefault(c => c.UserName == "wjhearniii@umich.org");
                }
                if (await _userManager.IsInRoleAsync(a12, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a12, "Student");
                }

                AppUser a13 = _db.Users.FirstOrDefault(c => c.Email == "ahick@yaho.com");
                if (a13 == null)
                {
                    a13 = new AppUser();
                    a13.UserName = "ahick@yaho.com";
                    a13.Email = "ahick@yaho.com";
                    a13.FirstName = "Anthony";
                    a13.LastName = "Hicks";
                    a13.GradDate = new DateTime(2020);
                    a13.PositionType = PositionType.Internship;
                    a13.GPA = 3.12m;
                    a13.Major = _db.Majors.FirstOrDefault(o => o.Name == "Supply Chain Management");

                    var result = await _userManager.CreateAsync(a13, "jhearn22");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a13 = _db.Users.FirstOrDefault(c => c.UserName == "ahick@yaho.com");
                }
                if (await _userManager.IsInRoleAsync(a13, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a13, "Student");
                }

                AppUser a14 = _db.Users.FirstOrDefault(c => c.Email == "ingram@jack.com");
                if (a14 == null)
                {
                    a14 = new AppUser();
                    a14.UserName = "ingram@jack.com";
                    a14.Email = "ingram@jack.com";
                    a14.FirstName = "Brad";
                    a14.LastName = "Ingram";
                    a14.GradDate = new DateTime(2020);
                    a14.PositionType = PositionType.Internship;
                    a14.GPA = 3.72m;
                    a14.Major = _db.Majors.FirstOrDefault(o => o.Name == "Supply Chain Management");

                    var result = await _userManager.CreateAsync(a14, "joejoejoe");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a14 = _db.Users.FirstOrDefault(c => c.UserName == "ingram@jack.com");
                }
                if (await _userManager.IsInRoleAsync(a14, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a14, "Student");
                }

                AppUser a15 = _db.Users.FirstOrDefault(c => c.Email == "toddj@yourmom.com");
                if (a15 == null)
                {
                    a15 = new AppUser();
                    a15.UserName = "toddj@yourmom.com";
                    a15.Email = "toddj@yourmom.com";
                    a15.FirstName = "Todd";
                    a15.LastName = "Jacobs";
                    a15.GradDate = new DateTime(2019);
                    a15.PositionType = PositionType.FullTime;
                    a15.GPA = 2.64m;
                    a15.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a15, "jrod2017");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a15 = _db.Users.FirstOrDefault(c => c.UserName == "toddj@yourmom.com");
                }
                if (await _userManager.IsInRoleAsync(a15, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a15, "Student");
                }

                AppUser a16 = _db.Users.FirstOrDefault(c => c.Email == "thequeen@aska.net");
                if (a16 == null)
                {
                    a16 = new AppUser();
                    a16.UserName = "thequeen@aska.net";
                    a16.Email = "thequeen@aska.net";
                    a16.FirstName = "Victoria";
                    a16.LastName = "Lawrence";
                    a16.GradDate = new DateTime(2021);
                    a16.PositionType = PositionType.Internship;
                    a16.GPA = 3.72m;
                    a16.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a16, "longhorns");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a16 = _db.Users.FirstOrDefault(c => c.UserName == "thequeen@aska.net");
                }
                if (await _userManager.IsInRoleAsync(a16, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a16, "Student");
                }

                AppUser a17 = _db.Users.FirstOrDefault(c => c.Email == "linebacker@gogle.com");
                if (a17 == null)
                {
                    a17 = new AppUser();
                    a17.UserName = "linebacker@gogle.com";
                    a17.Email = "linebacker@gogle.com";
                    a17.FirstName = "Erik";
                    a17.LastName = "Lineback";
                    a17.GradDate = new DateTime(2022);
                    a17.PositionType = PositionType.Internship;
                    a17.GPA = 3.15m;
                    a17.Major = _db.Majors.FirstOrDefault(o => o.Name == "Accounting");

                    var result = await _userManager.CreateAsync(a17, "louielouie");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a17 = _db.Users.FirstOrDefault(c => c.UserName == "linebacker@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a17, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a17, "Student");
                }

                AppUser a18 = _db.Users.FirstOrDefault(c => c.Email == "elowe@netscare.net");
                if (a18 == null)
                {
                    a18 = new AppUser();
                    a18.UserName = "elowe@netscare.net";
                    a18.Email = "elowe@netscare.net";
                    a18.FirstName = "Ernest";
                    a18.LastName = "Lowe";
                    a18.GradDate = new DateTime(2019);
                    a18.PositionType = PositionType.FullTime;
                    a18.GPA = 3.07m;
                    a18.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a18, "martin1234");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a18 = _db.Users.FirstOrDefault(c => c.UserName == "elowe@netscare.net");
                }
                if (await _userManager.IsInRoleAsync(a18, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a18, "Student");
                }

                AppUser a19 = _db.Users.FirstOrDefault(c => c.Email == "cluce@gogle.com");
                if (a19 == null)
                {
                    a19 = new AppUser();
                    a19.UserName = "cluce@gogle.com";
                    a19.Email = "cluce@gogle.com";
                    a19.FirstName = "Chuck";
                    a19.LastName = "Luce";
                    a19.GradDate = new DateTime(2020);
                    a19.PositionType = PositionType.Internship;
                    a19.GPA = 3.87m;
                    a19.Major = _db.Majors.FirstOrDefault(o => o.Name == "Accounting");

                    var result = await _userManager.CreateAsync(a19, "meganr34");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a19 = _db.Users.FirstOrDefault(c => c.UserName == "cluce@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a19, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a19, "Student");
                }

                AppUser a20 = _db.Users.FirstOrDefault(c => c.Email == "mackcloud@george.com");
                if (a20 == null)
                {
                    a20 = new AppUser();
                    a20.UserName = "mackcloud@george.com";
                    a20.Email = "mackcloud@george.com";
                    a20.FirstName = "Jennifer";
                    a20.LastName = "MacLeod";
                    a20.GradDate = new DateTime(2019);
                    a20.PositionType = PositionType.FullTime;
                    a20.GPA = 4m;
                    a20.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a20, "meow88");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a20 = _db.Users.FirstOrDefault(c => c.UserName == "mackcloud@george.com");
                }
                if (await _userManager.IsInRoleAsync(a20, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a20, "Student");
                }

                AppUser a21 = _db.Users.FirstOrDefault(c => c.Email == "cmartin@beets.com");
                if (a21 == null)
                {
                    a21 = new AppUser();
                    a21.UserName = "cmartin@beets.com";
                    a21.Email = "cmartin@beets.com";
                    a21.FirstName = "Elizabeth";
                    a21.LastName = "Markham";
                    a21.GradDate = new DateTime(2019);
                    a21.PositionType = PositionType.FullTime;
                    a21.GPA = 3.53m;
                    a21.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a21, "mustangs");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a21 = _db.Users.FirstOrDefault(c => c.UserName == "cmartin@beets.com");
                }
                if (await _userManager.IsInRoleAsync(a21, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a21, "Student");
                }

                AppUser a22 = _db.Users.FirstOrDefault(c => c.Email == "clarence@yoho.com");
                if (a22 == null)
                {
                    a22 = new AppUser();
                    a22.UserName = "clarence@yoho.com";
                    a22.Email = "clarence@yoho.com";
                    a22.FirstName = "Clarence";
                    a22.LastName = "Martin";
                    a22.GradDate = new DateTime(2020);
                    a22.PositionType = PositionType.Internship;
                    a22.GPA = 3.11m;
                    a22.Major = _db.Majors.FirstOrDefault(o => o.Name == "Supply Chain Management");

                    var result = await _userManager.CreateAsync(a22, "mydogspot");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a22 = _db.Users.FirstOrDefault(c => c.UserName == "clarence@yoho.com");
                }
                if (await _userManager.IsInRoleAsync(a22, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a22, "Student");
                }

                AppUser a23 = _db.Users.FirstOrDefault(c => c.Email == "gregmartinez@drdre.com");
                if (a23 == null)
                {
                    a23 = new AppUser();
                    a23.UserName = "gregmartinez@drdre.com";
                    a23.Email = "gregmartinez@drdre.com";
                    a23.FirstName = "Gregory";
                    a23.LastName = "Martinez";
                    a23.GradDate = new DateTime(2021);
                    a23.PositionType = PositionType.Internship;
                    a23.GPA = 3.43m;
                    a23.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a23, "nothinggood");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a23 = _db.Users.FirstOrDefault(c => c.UserName == "gregmartinez@drdre.com");
                }
                if (await _userManager.IsInRoleAsync(a23, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a23, "Student");
                }

                AppUser a24 = _db.Users.FirstOrDefault(c => c.Email == "cmiller@bob.com");
                if (a24 == null)
                {
                    a24 = new AppUser();
                    a24.UserName = "cmiller@bob.com";
                    a24.Email = "cmiller@bob.com";
                    a24.FirstName = "Charles";
                    a24.LastName = "Miller";
                    a24.GradDate = new DateTime(2020);
                    a24.PositionType = PositionType.Internship;
                    a24.GPA = 3.14m;
                    a24.Major = _db.Majors.FirstOrDefault(o => o.Name == "Management");

                    var result = await _userManager.CreateAsync(a24, "onetime");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a24 = _db.Users.FirstOrDefault(c => c.UserName == "cmiller@bob.com");
                }
                if (await _userManager.IsInRoleAsync(a24, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a24, "Student");
                }

                AppUser a25 = _db.Users.FirstOrDefault(c => c.Email == "knelson@aoll.com");
                if (a25 == null)
                {
                    a25 = new AppUser();
                    a25.UserName = "knelson@aoll.com";
                    a25.Email = "knelson@aoll.com";
                    a25.FirstName = "Kelly";
                    a25.LastName = "Nelson";
                    a25.GradDate = new DateTime(2019);
                    a25.PositionType = PositionType.FullTime;
                    a25.GPA = 3.03m;
                    a25.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a25, "painting");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a25 = _db.Users.FirstOrDefault(c => c.UserName == "knelson@aoll.com");
                }
                if (await _userManager.IsInRoleAsync(a25, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a25, "Student");
                }

                AppUser a26 = _db.Users.FirstOrDefault(c => c.Email == "joewin@xfactor.com");
                if (a26 == null)
                {
                    a26 = new AppUser();
                    a26.UserName = "joewin@xfactor.com";
                    a26.Email = "joewin@xfactor.com";
                    a26.FirstName = "Joe";
                    a26.LastName = "Nguyen";
                    a26.GradDate = new DateTime(2019);
                    a26.PositionType = PositionType.FullTime;
                    a26.GPA = 3.65m;
                    a26.Major = _db.Majors.FirstOrDefault(o => o.Name == "Management");

                    var result = await _userManager.CreateAsync(a26, "Password1");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a26 = _db.Users.FirstOrDefault(c => c.UserName == "joewin@xfactor.com");
                }
                if (await _userManager.IsInRoleAsync(a26, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a26, "Student");
                }

                AppUser a27 = _db.Users.FirstOrDefault(c => c.Email == "orielly@foxnews.cnn");
                if (a27 == null)
                {
                    a27 = new AppUser();
                    a27.UserName = "orielly@foxnews.cnn";
                    a27.Email = "orielly@foxnews.cnn";
                    a27.FirstName = "Bill";
                    a27.LastName = "O'Reilly";
                    a27.GradDate = new DateTime(2020);
                    a27.PositionType = PositionType.Internship;
                    a27.GPA = 3.46m;
                    a27.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a27, "penguin12");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a27 = _db.Users.FirstOrDefault(c => c.UserName == "orielly@foxnews.cnn");
                }
                if (await _userManager.IsInRoleAsync(a27, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a27, "Student");
                }

                AppUser a28 = _db.Users.FirstOrDefault(c => c.Email == "ankaisrad@gogle.com");
                if (a28 == null)
                {
                    a28 = new AppUser();
                    a28.UserName = "ankaisrad@gogle.com";
                    a28.Email = "ankaisrad@gogle.com";
                    a28.FirstName = "Anka";
                    a28.LastName = "Radkovich";
                    a28.GradDate = new DateTime(2019);
                    a28.PositionType = PositionType.FullTime;
                    a28.GPA = 3.67m;
                    a28.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a28, "pepperoni");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a28 = _db.Users.FirstOrDefault(c => c.UserName == "ankaisrad@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a28, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a28, "Student");
                }

                AppUser a29 = _db.Users.FirstOrDefault(c => c.Email == "megrhodes@freserve.co.uk");
                if (a29 == null)
                {
                    a29 = new AppUser();
                    a29.UserName = "megrhodes@freserve.co.uk";
                    a29.Email = "megrhodes@freserve.co.uk";
                    a29.FirstName = "Megan";
                    a29.LastName = "Rhodes";
                    a29.GradDate = new DateTime(2020);
                    a29.PositionType = PositionType.Internship;
                    a29.GPA = 3.14m;
                    a29.Major = _db.Majors.FirstOrDefault(o => o.Name == "Management");

                    var result = await _userManager.CreateAsync(a29, "potato");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a29 = _db.Users.FirstOrDefault(c => c.UserName == "megrhodes@freserve.co.uk");
                }
                if (await _userManager.IsInRoleAsync(a29, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a29, "Student");
                }

                AppUser a30 = _db.Users.FirstOrDefault(c => c.Email == "erynrice@aoll.com");
                if (a30 == null)
                {
                    a30 = new AppUser();
                    a30.UserName = "erynrice@aoll.com";
                    a30.Email = "erynrice@aoll.com";
                    a30.FirstName = "Eryn";
                    a30.LastName = "Rice";
                    a30.GradDate = new DateTime(2022);
                    a30.PositionType = PositionType.Internship;
                    a30.GPA = 3.92m;
                    a30.Major = _db.Majors.FirstOrDefault(o => o.Name == "Marketing");

                    var result = await _userManager.CreateAsync(a30, "radgirl");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a30 = _db.Users.FirstOrDefault(c => c.UserName == "erynrice@aoll.com");
                }
                if (await _userManager.IsInRoleAsync(a30, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a30, "Student");
                }

                AppUser a31 = _db.Users.FirstOrDefault(c => c.Email == "jorge@noclue.com");
                if (a31 == null)
                {
                    a31 = new AppUser();
                    a31.UserName = "jorge@noclue.com";
                    a31.Email = "jorge@noclue.com";
                    a31.FirstName = "Jorge";
                    a31.LastName = "Rodriguez";
                    a31.GradDate = new DateTime(2021);
                    a31.PositionType = PositionType.Internship;
                    a31.GPA = 3.64m;
                    a31.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a31, "raiders");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a31 = _db.Users.FirstOrDefault(c => c.UserName == "jorge@noclue.com");
                }
                if (await _userManager.IsInRoleAsync(a31, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a31, "Student");
                }

                AppUser a32 = _db.Users.FirstOrDefault(c => c.Email == "mrrogers@lovelyday.com");
                if (a32 == null)
                {
                    a32 = new AppUser();
                    a32.UserName = "mrrogers@lovelyday.com";
                    a32.Email = "mrrogers@lovelyday.com";
                    a32.FirstName = "Allen";
                    a32.LastName = "Rogers";
                    a32.GradDate = new DateTime(2020);
                    a32.PositionType = PositionType.Internship;
                    a32.GPA = 3.01m;
                    a32.Major = _db.Majors.FirstOrDefault(o => o.Name == "Marketing");

                    var result = await _userManager.CreateAsync(a32, "ricearoni");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a32 = _db.Users.FirstOrDefault(c => c.UserName == "mrrogers@lovelyday.com");
                }
                if (await _userManager.IsInRoleAsync(a32, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a32, "Student");
                }

                AppUser a33 = _db.Users.FirstOrDefault(c => c.Email == "stjean@athome.com");
                if (a33 == null)
                {
                    a33 = new AppUser();
                    a33.UserName = "stjean@athome.com";
                    a33.Email = "stjean@athome.com";
                    a33.FirstName = "Olivier";
                    a33.LastName = "Saint-Jean";
                    a33.GradDate = new DateTime(2019);
                    a33.PositionType = PositionType.FullTime;
                    a33.GPA = 3.24m;
                    a33.Major = _db.Majors.FirstOrDefault(o => o.Name == "Science and Technology Management");

                    var result = await _userManager.CreateAsync(a33, "rogerthat");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a33 = _db.Users.FirstOrDefault(c => c.UserName == "stjean@athome.com");
                }
                if (await _userManager.IsInRoleAsync(a33, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a33, "Student");
                }

                AppUser a34 = _db.Users.FirstOrDefault(c => c.Email == "saunders@pen.com");
                if (a34 == null)
                {
                    a34 = new AppUser();
                    a34.UserName = "saunders@pen.com";
                    a34.Email = "saunders@pen.com";
                    a34.FirstName = "Sarah";
                    a34.LastName = "Saunders";
                    a34.GradDate = new DateTime(2020);
                    a34.PositionType = PositionType.Internship;
                    a34.GPA = 3.16m;
                    a34.Major = _db.Majors.FirstOrDefault(o => o.Name == "Supply Chain Management");

                    var result = await _userManager.CreateAsync(a34, "slowwind");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a34 = _db.Users.FirstOrDefault(c => c.UserName == "saunders@pen.com");
                }
                if (await _userManager.IsInRoleAsync(a34, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a34, "Student");
                }

                AppUser a35 = _db.Users.FirstOrDefault(c => c.Email == "willsheff@email.com");
                if (a35 == null)
                {
                    a35 = new AppUser();
                    a35.UserName = "willsheff@email.com";
                    a35.Email = "willsheff@email.com";
                    a35.FirstName = "William";
                    a35.LastName = "Sewell";
                    a35.GradDate = new DateTime(2019);
                    a35.PositionType = PositionType.FullTime;
                    a35.GPA = 3.07m;
                    a35.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a35, "smitty444");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a35 = _db.Users.FirstOrDefault(c => c.UserName == "willsheff@email.com");
                }
                if (await _userManager.IsInRoleAsync(a35, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a35, "Student");
                }

                AppUser a36 = _db.Users.FirstOrDefault(c => c.Email == "sheffiled@gogle.com");
                if (a36 == null)
                {
                    a36 = new AppUser();
                    a36.UserName = "sheffiled@gogle.com";
                    a36.Email = "sheffiled@gogle.com";
                    a36.FirstName = "Martin";
                    a36.LastName = "Sheffield";
                    a36.GradDate = new DateTime(2020);
                    a36.PositionType = PositionType.Internship;
                    a36.GPA = 3.36m;
                    a36.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a36, "snowsnow");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a36 = _db.Users.FirstOrDefault(c => c.UserName == "sheffiled@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a36, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a36, "Student");
                }

                AppUser a37 = _db.Users.FirstOrDefault(c => c.Email == "johnsmith187@aoll.com");
                if (a37 == null)
                {
                    a37 = new AppUser();
                    a37.UserName = "johnsmith187@aoll.com";
                    a37.Email = "johnsmith187@aoll.com";
                    a37.FirstName = "John";
                    a37.LastName = "Smith";
                    a37.GradDate = new DateTime(2019);
                    a37.PositionType = PositionType.FullTime;
                    a37.GPA = 3.57m;
                    a37.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a37, "something");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a37 = _db.Users.FirstOrDefault(c => c.UserName == "johnsmith187@aoll.com");
                }
                if (await _userManager.IsInRoleAsync(a37, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a37, "Student");
                }

                AppUser a38 = _db.Users.FirstOrDefault(c => c.Email == "dustroud@mail.com");
                if (a38 == null)
                {
                    a38 = new AppUser();
                    a38.UserName = "dustroud@mail.com";
                    a38.Email = "dustroud@mail.com";
                    a38.FirstName = "Dustin";
                    a38.LastName = "Stroud";
                    a38.GradDate = new DateTime(2020);
                    a38.PositionType = PositionType.Internship;
                    a38.GPA = 3.49m;
                    a38.Major = _db.Majors.FirstOrDefault(o => o.Name == "Marketing");

                    var result = await _userManager.CreateAsync(a38, "spotmydog");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a38 = _db.Users.FirstOrDefault(c => c.UserName == "dustroud@mail.com");
                }
                if (await _userManager.IsInRoleAsync(a38, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a38, "Student");
                }

                AppUser a39 = _db.Users.FirstOrDefault(c => c.Email == "estuart@anchor.net");
                if (a39 == null)
                {
                    a39 = new AppUser();
                    a39.UserName = "estuart@anchor.net";
                    a39.Email = "estuart@anchor.net";
                    a39.FirstName = "Eric";
                    a39.LastName = "Stuart";
                    a39.GradDate = new DateTime(2019);
                    a39.PositionType = PositionType.FullTime;
                    a39.GPA = 3.58m;
                    a39.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a39, "stewball");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a39 = _db.Users.FirstOrDefault(c => c.UserName == "estuart@anchor.net");
                }
                if (await _userManager.IsInRoleAsync(a39, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a39, "Student");
                }

                AppUser a40 = _db.Users.FirstOrDefault(c => c.Email == "peterstump@noclue.com");
                if (a40 == null)
                {
                    a40 = new AppUser();
                    a40.UserName = "peterstump@noclue.com";
                    a40.Email = "peterstump@noclue.com";
                    a40.FirstName = "Peter";
                    a40.LastName = "Stump";
                    a40.GradDate = new DateTime(2021);
                    a40.PositionType = PositionType.Internship;
                    a40.GPA = 2.55m;
                    a40.Major = _db.Majors.FirstOrDefault(o => o.Name == "Supply Chain Management");

                    var result = await _userManager.CreateAsync(a40, "tanner5454");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a40 = _db.Users.FirstOrDefault(c => c.UserName == "peterstump@noclue.com");
                }
                if (await _userManager.IsInRoleAsync(a40, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a40, "Student");
                }

                AppUser a41 = _db.Users.FirstOrDefault(c => c.Email == "jtanner@mustang.net");
                if (a41 == null)
                {
                    a41 = new AppUser();
                    a41.UserName = "jtanner@mustang.net";
                    a41.Email = "jtanner@mustang.net";
                    a41.FirstName = "Jeremy";
                    a41.LastName = "Tanner";
                    a41.GradDate = new DateTime(2020);
                    a41.PositionType = PositionType.Internship;
                    a41.GPA = 3.16m;
                    a41.Major = _db.Majors.FirstOrDefault(o => o.Name == "Management");

                    var result = await _userManager.CreateAsync(a41, "taylorbaylor");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a41 = _db.Users.FirstOrDefault(c => c.UserName == "jtanner@mustang.net");
                }
                if (await _userManager.IsInRoleAsync(a41, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a41, "Student");
                }

                AppUser a42 = _db.Users.FirstOrDefault(c => c.Email == "taylordjay@aoll.com");
                if (a42 == null)
                {
                    a42 = new AppUser();
                    a42.UserName = "taylordjay@aoll.com";
                    a42.Email = "taylordjay@aoll.com";
                    a42.FirstName = "Allison";
                    a42.LastName = "Taylor";
                    a42.GradDate = new DateTime(2019);
                    a42.PositionType = PositionType.FullTime;
                    a42.GPA = 3.07m;
                    a42.Major = _db.Majors.FirstOrDefault(o => o.Name == "Marketing");

                    var result = await _userManager.CreateAsync(a42, "teeoff22");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a42 = _db.Users.FirstOrDefault(c => c.UserName == "taylordjay@aoll.com");
                }
                if (await _userManager.IsInRoleAsync(a42, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a42, "Student");
                }

                AppUser a43 = _db.Users.FirstOrDefault(c => c.Email == "rtaylor@gogle.com");
                if (a43 == null)
                {
                    a43 = new AppUser();
                    a43.UserName = "rtaylor@gogle.com";
                    a43.Email = "rtaylor@gogle.com";
                    a43.FirstName = "Rachel";
                    a43.LastName = "Taylor";
                    a43.GradDate = new DateTime(2020);
                    a43.PositionType = PositionType.Internship;
                    a43.GPA = 2.88m;
                    a43.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a43, "texas1");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a43 = _db.Users.FirstOrDefault(c => c.UserName == "rtaylor@gogle.com");
                }
                if (await _userManager.IsInRoleAsync(a43, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a43, "Student");
                }

                AppUser a44 = _db.Users.FirstOrDefault(c => c.Email == "teefrank@noclue.com");
                if (a44 == null)
                {
                    a44 = new AppUser();
                    a44.UserName = "teefrank@noclue.com";
                    a44.Email = "teefrank@noclue.com";
                    a44.FirstName = "Frank";
                    a44.LastName = "Tee";
                    a44.GradDate = new DateTime(2019);
                    a44.PositionType = PositionType.FullTime;
                    a44.GPA = 3.5m;
                    a44.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a44, "toddy25");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a44 = _db.Users.FirstOrDefault(c => c.UserName == "teefrank@noclue.com");
                }
                if (await _userManager.IsInRoleAsync(a44, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a44, "Student");
                }

                AppUser a45 = _db.Users.FirstOrDefault(c => c.Email == "ctucker@alphabet.co.uk");
                if (a45 == null)
                {
                    a45 = new AppUser();
                    a45.UserName = "ctucker@alphabet.co.uk";
                    a45.Email = "ctucker@alphabet.co.uk";
                    a45.FirstName = "Clent";
                    a45.LastName = "Tucker";
                    a45.GradDate = new DateTime(2020);
                    a45.PositionType = PositionType.Internship;
                    a45.GPA = 3.04m;
                    a45.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a45, "tucksack1");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a45 = _db.Users.FirstOrDefault(c => c.UserName == "ctucker@alphabet.co.uk");
                }
                if (await _userManager.IsInRoleAsync(a45, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a45, "Student");
                }

                AppUser a46 = _db.Users.FirstOrDefault(c => c.Email == "avelasco@yoho.com");
                if (a46 == null)
                {
                    a46 = new AppUser();
                    a46.UserName = "avelasco@yoho.com";
                    a46.Email = "avelasco@yoho.com";
                    a46.FirstName = "Allen";
                    a46.LastName = "Velasco";
                    a46.GradDate = new DateTime(2019);
                    a46.PositionType = PositionType.FullTime;
                    a46.GPA = 3.55m;
                    a46.Major = _db.Majors.FirstOrDefault(o => o.Name == "MIS");

                    var result = await _userManager.CreateAsync(a46, "vinovino");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a46 = _db.Users.FirstOrDefault(c => c.UserName == "avelasco@yoho.com");
                }
                if (await _userManager.IsInRoleAsync(a46, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a46, "Student");
                }

                AppUser a47 = _db.Users.FirstOrDefault(c => c.Email == "vinovino@grapes.com");
                if (a47 == null)
                {
                    a47 = new AppUser();
                    a47.UserName = "vinovino@grapes.com";
                    a47.Email = "vinovino@grapes.com";
                    a47.FirstName = "Janet";
                    a47.LastName = "Vino";
                    a47.GradDate = new DateTime(2021);
                    a47.PositionType = PositionType.Internship;
                    a47.GPA = 3.28m;
                    a47.Major = _db.Majors.FirstOrDefault(o => o.Name == "Business Honors");

                    var result = await _userManager.CreateAsync(a47, "whatever");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a47 = _db.Users.FirstOrDefault(c => c.UserName == "vinovino@grapes.com");
                }
                if (await _userManager.IsInRoleAsync(a47, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a47, "Student");
                }

                AppUser a48 = _db.Users.FirstOrDefault(c => c.Email == "winner@hootmail.com");
                if (a48 == null)
                {
                    a48 = new AppUser();
                    a48.UserName = "winner@hootmail.com";
                    a48.Email = "winner@hootmail.com";
                    a48.FirstName = "Louis";
                    a48.LastName = "Winthorpe";
                    a48.GradDate = new DateTime(2019);
                    a48.PositionType = PositionType.FullTime;
                    a48.GPA = 2.57m;
                    a48.Major = _db.Majors.FirstOrDefault(o => o.Name == "Finance");

                    var result = await _userManager.CreateAsync(a48, "woodyman1");
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }

                    _db.SaveChanges();
                    a48 = _db.Users.FirstOrDefault(c => c.UserName == "winner@hootmail.com");
                }
                if (await _userManager.IsInRoleAsync(a48, "Student") == false)
                {
                    await _userManager.AddToRoleAsync(a48, "Student");
                }


            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
