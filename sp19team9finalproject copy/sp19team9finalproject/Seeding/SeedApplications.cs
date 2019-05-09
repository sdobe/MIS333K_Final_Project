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

                Application ap1 = new Application() { Result = "Accepted" };
                ap1.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                ap1.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Lou Ann " && a.LastName == "Feeley");
                Applications.Add(ap1);

                Application ap2 = new Application() { Result = "Accepted" };
                ap2.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                ap2.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Eryn " && a.LastName == "Rice");
                Applications.Add(ap2);

                Application ap3 = new Application() { Result = "Accepted" };
                ap3.Position = db.Positions.FirstOrDefault(p => p.Title == "Corporate Recruiting Intern");
                ap3.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Charles " && a.LastName == "Miller");
                Applications.Add(ap3);

                Application ap4 = new Application() { Result = "Accepted" };
                ap4.Position = db.Positions.FirstOrDefault(p => p.Title == "Account Manager");
                ap4.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Eric " && a.LastName == "Stuart");
                Applications.Add(ap4);

                Application ap5 = new Application() { Result = "Accepted" };
                ap5.Position = db.Positions.FirstOrDefault(p => p.Title == "Web Development");
                ap5.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Christopher " && a.LastName == "Baker");
                Applications.Add(ap5);

                Application ap6 = new Application() { Result = "Accepted" };
                ap6.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap6.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Eryn " && a.LastName == "Rice");
                Applications.Add(ap6);

                Application ap7 = new Application() { Result = "Accepted" };
                ap7.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap7.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Tesa " && a.LastName == "Freeley");
                Applications.Add(ap7);

                Application ap8 = new Application() { Result = "Accepted" };
                ap8.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                ap8.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Lim " && a.LastName == "Chou");
                Applications.Add(ap8);

                Application ap9 = new Application() { Result = "Accepted" };
                ap9.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                ap9.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Brad " && a.LastName == "Ingram");
                Applications.Add(ap9);

                Application ap10 = new Application() { Result = "Accepted" };
                ap10.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                ap10.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Sarah " && a.LastName == "Saunders");
                Applications.Add(ap10);

                Application ap11 = new Application() { Result = "Accepted" };
                ap11.Position = db.Positions.FirstOrDefault(p => p.Title == "Financial Analyst");
                ap11.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "John " && a.LastName == "Smith");
                Applications.Add(ap11);

                Application ap12 = new Application() { Result = "Accepted" };
                ap12.Position = db.Positions.FirstOrDefault(p => p.Title == "Accounting Intern");
                ap12.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Chuck " && a.LastName == "Luce");
                Applications.Add(ap12);

                Application ap13 = new Application() { Result = "Accepted" };
                ap13.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                ap13.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "Eric " && a.LastName == "Stuart");
                Applications.Add(ap13);

                Application ap14 = new Application() { Result = "Accepted" };
                ap14.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                ap14.AppUser = db.AppUsers.FirstOrDefault(a => a.FirstName == "John " && a.LastName == "Hearn");
                Applications.Add(ap14);


                try
                {
                    foreach (Application applicationToAdd in Applications)
                    {

                        Application dbApplication = db.Applications.FirstOrDefault(m => m.Position == applicationToAdd.Position && m.AppUser == applicationToAdd.AppUser);

                        if (dbApplication == null)
                        {
                            db.Applications.Add(applicationToAdd);
                            db.SaveChanges();
                            intApplicationsAdded += 1;
                        }
                        else
                        {
                            dbApplication.Position = applicationToAdd.Position;
                            dbApplication.AppUser = applicationToAdd.AppUser;
                            db.Update(dbApplication);
                            db.SaveChanges();
                            intApplicationsAdded += 1;

                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intApplicationsAdded + "; ";

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
