using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedApplications
    {
        public static void SeedAllApplications(AppDbContext db)
        {
            if (db.Applications.Count() == 14)
            {
                NotSupportedException ex = new NotSupportedException("Already 14 Applications");

                throw ex;
            }

            Int32 intApplicationsAdded = 0;
            List<Application> Applications = new List<Application>();

            try
            {
                Application ap1 = new Application() { };
                ap1.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                ap1.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Lou Ann Feeley");
                Applications.Add(ap1);

                Application ap2 = new Application() { };
                ap2.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                ap2.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Eryn Rice");
                Applications.Add(ap2);

                Application ap3 = new Application() { };
                ap3.Position = db.Positions.FirstOrDefault(p => p.Title == "Corporate Recruiting Intern");
                ap3.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Charles Miller");
                Applications.Add(ap3);

                Application ap4 = new Application() { };
                ap4.Position = db.Positions.FirstOrDefault(p => p.Title == "Account Manager");
                ap4.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Eric Stuart");
                Applications.Add(ap4);

                Application ap5 = new Application() { };
                ap5.Position = db.Positions.FirstOrDefault(p => p.Title == "Web Development");
                ap5.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Christopher Baker");
                Applications.Add(ap5);

                Application ap6 = new Application() { };
                ap6.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap6.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Eryn Rice");
                Applications.Add(ap6);

                Application ap7 = new Application() { };
                ap7.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap7.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Tesa Feeley");
                Applications.Add(ap7);

                Application ap8 = new Application() { };
                ap8.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap8.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Lim Chou");
                Applications.Add(ap8);

                Application ap9 = new Application() { };
                ap9.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                ap9.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Brad Ingram");
                Applications.Add(ap9);

                Application ap10 = new Application() { };
                ap10.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                ap10.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Sarah Saunders");
                Applications.Add(ap10);

                Application ap11 = new Application() { };
                ap11.Position = db.Positions.FirstOrDefault(p => p.Title == "Financial Analyst");
                ap11.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "John Smith");
                Applications.Add(ap11);

                Application ap12 = new Application() { };
                ap12.Position = db.Positions.FirstOrDefault(p => p.Title == "Accounting Intern");
                ap12.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Chuck Luce");
                Applications.Add(ap12);

                Application ap13 = new Application() { };
                ap13.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                ap13.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "Eric Stuart");
                Applications.Add(ap13);

                Application ap14 = new Application() { };
                ap14.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                ap14.AppUser = db.AppUsers.FirstOrDefault(a => a.FullName == "John Hearn");
                Applications.Add(ap14);
            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
