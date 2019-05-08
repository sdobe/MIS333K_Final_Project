using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedMajors
    {
        public static void SeedAllMajors(AppDbContext db)
        {
            if (db.Majors.Count() == 9)
            {
                NotSupportedException ex = new NotSupportedException("Already 9 Majors");

                throw ex;
            }

            Int32 intMajorsAdded = 0;
            List<Major> Majors = new List<Major>();


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
