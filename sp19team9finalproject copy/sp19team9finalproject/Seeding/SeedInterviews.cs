using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedInterviews
    {
        public static void SeedAllInterviews(AppDbContext db)
        {
            if (db.Interviews.Count() == 14)
            {
                NotSupportedException ex = new NotSupportedException("Already 14 Interviews");

                throw ex;
            }

            Int32 intInterviewsAdded = 0;
            List<Interview> Interviews = new List<Interview>();

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
