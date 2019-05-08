using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedPositions
    {
        public static void SeedAllPositions(AppDbContext db)
        {
            if (db.Positions.Count() == 16)
            {
                NotSupportedException ex = new NotSupportedException("Already 16 Positions");

                throw ex;
            }

            Int32 intPositionsAdded = 0;
            List<Position> Positions = new List<Position>();

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
