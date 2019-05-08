using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedCSO
    {
        public static void SeedAllCSO(AppDbContext db)
        {
            
            Int32 intCSOAdded = 0;
            List<AppUser> CSOs = new List<AppUser>();

            //try
            //{
            //    AppUser ap1 = new AppUser()
            //    {
            //        EmailAddress = "ra@aoo.com",
            //        Password = "3wCynC",
            //        FirstName = "Allen",
            //        LastName = "Rogers"
            //    };
            //    UserManager.AddToRole(ap1.Id, "CSO");
            //    CSOs.Add(ap1);

            //    AppUser ap2 = new AppUser()
            //    {
            //        EmailAddress = "rwood@voyager.net",
            //        Password = "Pbon0r",
            //        FirstName = "Reagan",
            //        LastName = "Wood"
            //    };
            //    UserManager.AddToRole(ap2.Id, "CSO");
            //    CSOs.Add(ap2);

            //    AppUser ap3 = new AppUser()
            //    {
            //        EmailAddress = "westj@pioneer.net",
            //        Password = "jW5fPP",
            //        FirstName = "Jake",
            //        LastName = "West"
            //    };
            //    UserManager.AddToRole(ap3.Id, "CSO");
            //    CSOs.Add(ap3);

            //    AppUser ap4 = new AppUser()
            //    {
            //        EmailAddress = "liz@ggmail.com",
            //        Password = "0QyilL",
            //        FirstName = "Elizabeth",
            //        LastName = "Markham"
            //    };
            //    UserManager.AddToRole(ap4.Id, "CSO");
            //    CSOs.Add(ap4);

            //    AppUser ap5 = new AppUser()
            //    {
            //        EmailAddress = "chaley@thug.com",
            //        Password = "atLm6W",
            //        FirstName = "Charles",
            //        LastName = "Haley"
            //    };
            //    UserManager.AddToRole(ap5.Id, "CSO");
            //    CSOs.Add(ap5);
            //}

            //catch (Exception e)
            //{
            //    throw new InvalidOperationException(e.Message);
            //}
        }
    }
}
