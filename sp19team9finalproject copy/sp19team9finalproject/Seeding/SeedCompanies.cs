using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public static class SeedCompanies
    {
        public static void SeedAllCompanies(AppDbContext db)
        {
            if (db.Companies.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intCompaniesAdded = 0;
            List<Company> Companies = new List<Company>();


            try
            {
                //Company c1 = new Company()
                //{
                //    EmailAddress = "accenture@example.com",
                //    Description = "Whatever",
                //    Name = "Accenture",
                //    Industry = "Consulting, Technology"
                //};
                //Companies.Add(c1);
            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
