using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedRecruiters
    {
        public static void SeedAllRecruiters(AppDbContext db)
        {
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
                    EmailAddress = "michelle@example.com",
                    Password = "jVb0Z6",
                    FirstName = "Michelle",
                    LastName = "Banks"
                };
                ap1.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                UserManager.AddToRole(ap1.Id, "Recruiter");
                Recruiters.Add(ap1);

                AppUser ap2 = new AppUser()
                {
                    EmailAddress = "toddy@aool.com",
                    Password = "1PnrBV",
                    FirstName = "Todd",
                    LastName = "Jacobs"
                };
                ap2.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                UserManager.AddToRole(ap2.Id, "Recruiter");
                Recruiters.Add(ap2);

                AppUser ap3 = new AppUser()
                {
                    EmailAddress = "elowe@netscrape.net",
                    Password = "v3n5AV",
                    FirstName = "Ernest",
                    LastName = "Lowe"
                };
                ap3.Company = db.Companies.FirstOrDefault(c => c.Name == "Shell");
                UserManager.AddToRole(ap3.Id, "Recruiter");
                Recruiters.Add(ap3);

                AppUser ap4 = new AppUser()
                {
                    EmailAddress = "mclarence@aool.com",
                    Password = "zBLq3S",
                    FirstName = "Clarence",
                    LastName = "Martin"
                };
                ap4.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                UserManager.AddToRole(ap4.Id, "Recruiter");
                Recruiters.Add(ap4);

                AppUser ap5 = new AppUser()
                {
                    EmailAddress = "nelson.Kelly@aool.com",
                    Password = "FSb8rA",
                    FirstName = "Kelly",
                    LastName = "Nelson"
                };
                ap5.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                UserManager.AddToRole(ap5.Id, "Recruiter");
                Recruiters.Add(ap5);

                AppUser ap6 = new AppUser()
                {
                    EmailAddress = "megrhodes@freezing.co.uk",
                    Password = "1xVfHp",
                    FirstName = "Megan",
                    LastName = "Rhodes"
                };
                ap6.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                UserManager.AddToRole(ap6.Id, "Recruiter");
                Recruiters.Add(ap6);

                AppUser ap7 = new AppUser()
                {
                    EmailAddress = "sheff44@ggmail.com",
                    Password = "4XKLsd",
                    FirstName = "Martin",
                    LastName = "Sheffield"
                };
                ap7.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                UserManager.AddToRole(ap7.Id, "Recruiter");
                Recruiters.Add(ap7);

                AppUser ap8 = new AppUser()
                {
                    EmailAddress = "peterstump@hootmail.com",
                    Password = "1XdmSV",
                    FirstName = "Peter",
                    LastName = "Stump"
                };
                ap8.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                UserManager.AddToRole(ap8.Id, "Recruiter");
                Recruiters.Add(ap8);

                AppUser ap9 = new AppUser()
                {
                    EmailAddress = "yhuik9.Taylor@aool.com",
                    Password = "9yhFS3",
                    FirstName = "Rachel",
                    LastName = "Taylor"
                };
                ap9.Company = db.Companies.FirstOrDefault(c => c.Name == "Hilton Worldwide");
                UserManager.AddToRole(ap9.Id, "Recruiter");
                Recruiters.Add(ap9);

                AppUser ap10 = new AppUser()
                {
                    EmailAddress = "tuck33@ggmail.com",
                    Password = "I6BgsS",
                    FirstName = "Clent",
                    LastName = "Tucker"
                };
                ap10.Company = db.Companies.FirstOrDefault(c => c.Name == "Aon");
                UserManager.AddToRole(ap10.Id, "Recruiter");
                Recruiters.Add(ap10);

                AppUser ap11 = new AppUser()
                {
                    EmailAddress = "taylordjay@aool.com",
                    Password = "Vjb1wI",
                    FirstName = "Allison",
                    LastName = "Taylor"
                };
                ap11.Company = db.Companies.FirstOrDefault(c => c.Name == "Aldlucent");
                UserManager.AddToRole(ap11.Id, "Recruiter");
                Recruiters.Add(ap11);

                AppUser ap12 = new AppUser()
                {
                    EmailAddress = "jojoe@ggmail.com",
                    Password = "xI8Brg",
                    FirstName = "Joe",
                    LastName = "Nguyen"
                };
                ap12.Company = db.Companies.FirstOrDefault(c => c.Name == "Stream Realty Partners");
                UserManager.AddToRole(ap12.Id, "Recruiter");
                Recruiters.Add(ap12);

                AppUser ap13 = new AppUser()
                {
                    EmailAddress = "hicks43@ggmail.com",
                    Password = "s33WOz",
                    FirstName = "Anthony",
                    LastName = "Hicks"
                };
                ap13.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                UserManager.AddToRole(ap13.Id, "Recruiter");
                Recruiters.Add(ap13);

                AppUser ap14 = new AppUser()
                {
                    EmailAddress = "orielly@foxnets.com",
                    Password = "pS2OJh",
                    FirstName = "Bill",
                    LastName = "O'Reilly"
                };
                ap14.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                UserManager.AddToRole(ap14.Id, "Recruiter");
                Recruiters.Add(ap14);

                AppUser ap15 = new AppUser()
                {
                    EmailAddress = "louielouie@aool.com",
                    Password = "fq7yDw",
                    FirstName = "Louis",
                    LastName = "Winthorpe"
                };
                ap15.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                UserManager.AddToRole(ap15.Id, "Recruiter");
                Recruiters.Add(ap15);

                AppUser ap16 = new AppUser()
                {
                    EmailAddress = "smartinmartin.Martin@aool.com",
                    Password = "1rKkMW",
                    FirstName = "Gregory",
                    LastName = "Martinez"
                };
                ap16.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                UserManager.AddToRole(ap16.Id, "Recruiter");
                Recruiters.Add(ap16);

                AppUser ap17 = new AppUser()
                {
                    EmailAddress = "or@aool.com",
                    Password = "8K0cAh",
                    FirstName = "Anka",
                    LastName = "Radkovich"
                };
                ap17.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                UserManager.AddToRole(ap17.Id, "Recruiter");
                Recruiters.Add(ap17);

                AppUser ap18 = new AppUser()
                {
                    EmailAddress = "tanner@ggmail.com",
                    Password = "w9wPff",
                    FirstName = "Jeremy",
                    LastName = "Tanner"
                };
                ap18.Company = db.Companies.FirstOrDefault(c => c.Name == "United Airlines");
                UserManager.AddToRole(ap18.Id, "Recruiter");
                Recruiters.Add(ap18);

                AppUser ap19 = new AppUser()
                {
                    EmailAddress = "tee_frank@hootmail.com",
                    Password = "1EIwbx",
                    FirstName = "Frank",
                    LastName = "Tee"
                };
                ap19.Company = db.Companies.FirstOrDefault(c => c.Name == "Academy Sports & Outdoors");
                UserManager.AddToRole(ap19.Id, "Recruiter");
                Recruiters.Add(ap19);

                AppUser ap20 = new AppUser()
                {
                    EmailAddress = "target_spot@example.com",
                    Password = "spotthedog",
                    FirstName = "Spot",
                    LastName = "Dog"
                };
                ap20.Company = db.Companies.FirstOrDefault(c => c.Name == "Target");
                UserManager.AddToRole(ap20.Id, "Recruiter");
                Recruiters.Add(ap20);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
