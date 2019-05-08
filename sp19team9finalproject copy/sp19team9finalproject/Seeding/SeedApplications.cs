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

            try
            {
                List<Application> Applications = new List<Application>();

                //Company c1 = new Company()
                //{
                //    EmailAddress = "accenture@example.com",
                //    Description = "Whatever",
                //    Name = "Accenture",
                //    Industry = "Consulting, Technology"
                //};
                //Companies.Add(c1);
            };
        }
}
