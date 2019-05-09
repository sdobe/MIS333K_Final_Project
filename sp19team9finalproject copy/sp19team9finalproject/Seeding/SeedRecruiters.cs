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
            AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (db.AppUsers.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intRecruitersAdded = 0;
            List<AppUser> Recruiters = new List<AppUser>();

            try
            {
                AppUser ap1 = new AppUser()
                {
                    Email = "michelle@example.com",
                    PasswordHash = "jVb0Z6",
                    FirstName = "Michelle",
                    LastName = "Banks"
                };
                ap1.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                _userManager.AddToRoleAsync(ap1, "Recruiter");
                Recruiters.Add(ap1);

                AppUser ap2 = new AppUser()
                {
                    Email = "toddy@aool.com",
                    PasswordHash = "1PnrBV",
                    FirstName = "Todd",
                    LastName = "Jacobs"
                };
                ap2.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                _userManager.AddToRoleAsync(ap2, "Recruiter");
                Recruiters.Add(ap2);

                AppUser ap3 = new AppUser()
                {
                    Email = "elowe@netscrape.net",
                    PasswordHash = "v3n5AV",
                    FirstName = "Ernest",
                    LastName = "Lowe"
                };
                ap3.Company = db.Companies.FirstOrDefault(c => c.Name == "Shell");
                _userManager.AddToRoleAsync(ap3, "Recruiter");
                Recruiters.Add(ap3);

                AppUser ap4 = new AppUser()
                {
                    Email = "mclarence@aool.com",
                    PasswordHash = "zBLq3S",
                    FirstName = "Clarence",
                    LastName = "Martin"
                };
                ap4.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                _userManager.AddToRoleAsync(ap4, "Recruiter");
                Recruiters.Add(ap4);

                AppUser ap5 = new AppUser()
                {
                    Email = "nelson.Kelly@aool.com",
                    PasswordHash = "FSb8rA",
                    FirstName = "Kelly",
                    LastName = "Nelson"
                };
                ap5.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                _userManager.AddToRoleAsync(ap5, "Recruiter");
                Recruiters.Add(ap5);

                AppUser ap6 = new AppUser()
                {
                    Email = "megrhodes@freezing.co.uk",
                    PasswordHash = "1xVfHp",
                    FirstName = "Megan",
                    LastName = "Rhodes"
                };
                ap6.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                _userManager.AddToRoleAsync(ap6, "Recruiter");
                Recruiters.Add(ap6);

                AppUser ap7 = new AppUser()
                {
                    Email = "sheff44@ggmail.com",
                    PasswordHash = "4XKLsd",
                    FirstName = "Martin",
                    LastName = "Sheffield"
                };
                ap7.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                _userManager.AddToRoleAsync(ap7, "Recruiter");
                Recruiters.Add(ap7);

                AppUser ap8 = new AppUser()
                {
                    Email = "peterstump@hootmail.com",
                    PasswordHash = "1XdmSV",
                    FirstName = "Peter",
                    LastName = "Stump"
                };
                ap8.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                _userManager.AddToRoleAsync(ap8, "Recruiter");
                Recruiters.Add(ap8);

                AppUser ap9 = new AppUser()
                {
                    Email = "yhuik9.Taylor@aool.com",
                    PasswordHash = "9yhFS3",
                    FirstName = "Rachel",
                    LastName = "Taylor"
                };
                ap9.Company = db.Companies.FirstOrDefault(c => c.Name == "Hilton Worldwide");
                _userManager.AddToRoleAsync(ap9, "Recruiter");
                Recruiters.Add(ap9);

                AppUser ap10 = new AppUser()
                {
                    Email = "tuck33@ggmail.com",
                    PasswordHash = "I6BgsS",
                    FirstName = "Clent",
                    LastName = "Tucker"
                };
                ap10.Company = db.Companies.FirstOrDefault(c => c.Name == "Aon");
                _userManager.AddToRoleAsync(ap10, "Recruiter");
                Recruiters.Add(ap10);

                AppUser ap11 = new AppUser()
                {
                    Email = "taylordjay@aool.com",
                    PasswordHash = "Vjb1wI",
                    FirstName = "Allison",
                    LastName = "Taylor"
                };
                ap11.Company = db.Companies.FirstOrDefault(c => c.Name == "Aldlucent");
                _userManager.AddToRoleAsync(ap11, "Recruiter");
                Recruiters.Add(ap11);

                AppUser ap12 = new AppUser()
                {
                    Email = "jojoe@ggmail.com",
                    PasswordHash = "xI8Brg",
                    FirstName = "Joe",
                    LastName = "Nguyen"
                };
                ap12.Company = db.Companies.FirstOrDefault(c => c.Name == "Stream Realty Partners");
                _userManager.AddToRoleAsync(ap12, "Recruiter");
                Recruiters.Add(ap12);

                AppUser ap13 = new AppUser()
                {
                    Email = "hicks43@ggmail.com",
                    PasswordHash = "s33WOz",
                    FirstName = "Anthony",
                    LastName = "Hicks"
                };
                ap13.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                _userManager.AddToRoleAsync(ap13, "Recruiter");
                Recruiters.Add(ap13);

                AppUser ap14 = new AppUser()
                {
                    Email = "orielly@foxnets.com",
                    PasswordHash = "pS2OJh",
                    FirstName = "Bill",
                    LastName = "O'Reilly"
                };
                ap14.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                _userManager.AddToRoleAsync(ap14, "Recruiter");
                Recruiters.Add(ap14);

                AppUser ap15 = new AppUser()
                {
                    Email = "louielouie@aool.com",
                    PasswordHash = "fq7yDw",
                    FirstName = "Louis",
                    LastName = "Winthorpe"
                };
                ap15.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                _userManager.AddToRoleAsync(ap15, "Recruiter");
                Recruiters.Add(ap15);

                AppUser ap16 = new AppUser()
                {
                    Email = "smartinmartin.Martin@aool.com",
                    PasswordHash = "1rKkMW",
                    FirstName = "Gregory",
                    LastName = "Martinez"
                };
                ap16.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                _userManager.AddToRoleAsync(ap16, "Recruiter");
                Recruiters.Add(ap16);

                AppUser ap17 = new AppUser()
                {
                    Email = "or@aool.com",
                    PasswordHash = "8K0cAh",
                    FirstName = "Anka",
                    LastName = "Radkovich"
                };
                ap17.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                _userManager.AddToRoleAsync(ap17, "Recruiter");
                Recruiters.Add(ap17);

                AppUser ap18 = new AppUser()
                {
                    Email = "tanner@ggmail.com",
                    PasswordHash = "w9wPff",
                    FirstName = "Jeremy",
                    LastName = "Tanner"
                };
                ap18.Company = db.Companies.FirstOrDefault(c => c.Name == "United Airlines");
                _userManager.AddToRoleAsync(ap18, "Recruiter");
                Recruiters.Add(ap18);

                AppUser ap19 = new AppUser()
                {
                    Email = "tee_frank@hootmail.com",
                    PasswordHash = "1EIwbx",
                    FirstName = "Frank",
                    LastName = "Tee"
                };
                ap19.Company = db.Companies.FirstOrDefault(c => c.Name == "Academy Sports & Outdoors");
                _userManager.AddToRoleAsync(ap19, "Recruiter");
                Recruiters.Add(ap19);

                AppUser ap20 = new AppUser()
                {
                    Email = "target_spot@example.com",
                    PasswordHash = "spotthedog",
                    FirstName = "Spot",
                    LastName = "Dog"
                };
                ap20.Company = db.Companies.FirstOrDefault(c => c.Name == "Target");
                _userManager.AddToRoleAsync(ap20, "Recruiter");
                Recruiters.Add(ap20);

                try
                {
                    foreach (AppUser recruiterToAdd in Recruiters)
                    {
                        string strMajorName = recruiterToAdd.FirstName;
                        AppUser dbRecruiter = db.AppUsers.FirstOrDefault(m => m.Email == recruiterToAdd.Email);

                        if (dbRecruiter == null)
                        {
                            db.AppUsers.Add(recruiterToAdd);
                            db.SaveChanges();
                            intRecruitersAdded += 1;
                        }
                        else
                        {
                            dbRecruiter.FirstName = recruiterToAdd.FirstName;
                            dbRecruiter.LastName = recruiterToAdd.LastName;
                            dbRecruiter.PasswordHash = recruiterToAdd.PasswordHash;
                            dbRecruiter.Email = recruiterToAdd.Email;
                            dbRecruiter.Company = recruiterToAdd.Company;
                            db.Update(dbRecruiter);
                            db.SaveChanges();
                            intRecruitersAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intRecruitersAdded + "; ";

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
