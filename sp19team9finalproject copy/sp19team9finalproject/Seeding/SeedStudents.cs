using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedStudents
    {
        public static void SeedAllStudents(AppDbContext db)
        {
            if (db.AppUsers.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intStudentsAdded = 0;
            List<AppUser> Students = new List<AppUser>();

            try
            {
                AppUser a1 = new AppUser()
                {
                    EmailAddress = "cbaker@example.com",
                    Password = "bookworm",
                    FirstName = "Christopher",
                    LastName = "Baker",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.91m
                };
                a1.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a1.Id, "Student");
                Students.Add(a1);

                AppUser a2 = new AppUser()
                {
                    EmailAddress = "banker@longhorn.net",
                    Password = "aclfest2017",
                    FirstName = "Michelle",
                    LastName = "Banks",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.52m
                };
                a2.Major = db.Majors.FirstOrDefault(c => c.Name == "International Business");
                UserManager.AddToRole(a2.Id, "Student");
                Students.Add(a2);

                AppUser a3 = new AppUser()
                {
                    EmailAddress = "franco@example.com",
                    Password = "aggies",
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.2m
                };
                a3.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a3.Id, "Student");
                Students.Add(a3);

                AppUser a4 = new AppUser()
                {
                    EmailAddress = "wchang@example.com",
                    Password = "alaskaboy",
                    FirstName = "Wendy",
                    LastName = "Chang",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.56m
                };
                a4.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a4.Id, "Student");
                Students.Add(a4);

                AppUser a5 = new AppUser()
                {
                    EmailAddress = "limchou@gogle.com",
                    Password = "allyrally",
                    FirstName = "Lim",
                    LastName = "Chou",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 2.63m
                };
                a5.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a5.Id, "Student");
                Students.Add(a5);

                AppUser a6 = new AppUser()
                {
                    EmailAddress = "shdixon@aoll.com",
                    Password = "Anchorage",
                    FirstName = "Shan",
                    LastName = "Dixon",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.62m
                };
                a6.Major = db.Majors.FirstOrDefault(c => c.Name == "International Business");
                UserManager.AddToRole(a6.Id, "Student");
                Students.Add(a6);

                AppUser a7 = new AppUser()
                {
                    EmailAddress = "j.b.evans@aheca.org",
                    Password = "billyboy",
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.64m
                };
                a7.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                UserManager.AddToRole(a7.Id, "Student");
                Students.Add(a7);

                AppUser a8 = new AppUser()
                {
                    EmailAddress = "feeley@penguin.org",
                    Password = "bunnyhop",
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.66m
                };
                a8.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                UserManager.AddToRole(a8.Id, "Student");
                Students.Add(a8);

                AppUser a9 = new AppUser()
                {
                    EmailAddress = "tfreeley@minnetonka.ci.us",
                    Password = "dustydusty",
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.98m
                };
                a9.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                UserManager.AddToRole(a9.Id, "Student");
                Students.Add(a9);

                AppUser a10 = new AppUser()
                {
                    EmailAddress = "mgarcia@gogle.com",
                    Password = "gowest",
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.22m
                };
                a10.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a10.Id, "Student");
                Students.Add(a10);

                AppUser a11 = new AppUser()
                {
                    EmailAddress = "jeffh@sonic.com",
                    Password = "hickhickup",
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.66m
                };
                a11.Major = db.Majors.FirstOrDefault(c => c.Name == "Science and Technology Management");
                UserManager.AddToRole(a11.Id, "Student");
                Students.Add(a11);

                AppUser a12 = new AppUser()
                {
                    EmailAddress = "wjhearniii@umich.org",
                    Password = "ingram2015",
                    FirstName = "John",
                    LastName = "Hearn",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.46m
                };
                a12.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a12.Id, "Student");
                Students.Add(a12);

                AppUser a13 = new AppUser()
                {
                    EmailAddress = "ahick@yaho.com",
                    Password = "jhearn22",
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.12m
                };
                a13.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                UserManager.AddToRole(a13.Id, "Student");
                Students.Add(a13);

                AppUser a14 = new AppUser()
                {
                    EmailAddress = "ingram@jack.com",
                    Password = "joejoejoe",
                    FirstName = "Brad",
                    LastName = "Ingram",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.72m
                };
                a14.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                UserManager.AddToRole(a14.Id, "Student");
                Students.Add(a14);

                AppUser a15 = new AppUser()
                {
                    EmailAddress = "toddj@yourmom.com",
                    Password = "jrod2017",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.64m
                };
                a15.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a15.Id, "Student");
                Students.Add(a15);

                AppUser a16 = new AppUser()
                {
                    EmailAddress = "thequeen@aska.net",
                    Password = "longhorns",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.72m
                };
                a16.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a16.Id, "Student");
                Students.Add(a16);

                AppUser a17 = new AppUser()
                {
                    EmailAddress = "linebacker@gogle.com",
                    Password = "louielouie",
                    FirstName = "Erik",
                    LastName = "Lineback",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.15m
                };
                a17.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                UserManager.AddToRole(a17.Id, "Student");
                Students.Add(a17);

                AppUser a18 = new AppUser()
                {
                    EmailAddress = "elowe@netscare.net",
                    Password = "martin1234",
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a18.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a18.Id, "Student");
                Students.Add(a18);

                AppUser a19 = new AppUser()
                {
                    EmailAddress = "cluce@gogle.com",
                    Password = "meganr34",
                    FirstName = "Chuck",
                    LastName = "Luce",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.87m
                };
                a19.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                UserManager.AddToRole(a19.Id, "Student");
                Students.Add(a19);

                AppUser a20 = new AppUser()
                {
                    EmailAddress = "mackcloud@george.com",
                    Password = "meow88",
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 4m
                };
                a20.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a20.Id, "Student");
                Students.Add(a20);

                AppUser a21 = new AppUser()
                {
                    EmailAddress = "cmartin@beets.com",
                    Password = "mustangs",
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.53m
                };
                a21.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a21.Id, "Student");
                Students.Add(a21);

                AppUser a22 = new AppUser()
                {
                    EmailAddress = "clarence@yoho.com",
                    Password = "mydogspot",
                    FirstName = "Clarence",
                    LastName = "Martin",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.11m
                };
                a22.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                UserManager.AddToRole(a22.Id, "Student");
                Students.Add(a22);

                AppUser a23 = new AppUser()
                {
                    EmailAddress = "gregmartinez@drdre.com",
                    Password = "nothinggood",
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.43m
                };
                a23.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a23.Id, "Student");
                Students.Add(a23);

                AppUser a24 = new AppUser()
                {
                    EmailAddress = "cmiller@bob.com",
                    Password = "onetime",
                    FirstName = "Charles",
                    LastName = "Miller",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.14m
                };
                a24.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                UserManager.AddToRole(a24.Id, "Student");
                Students.Add(a24);

                AppUser a25 = new AppUser()
                {
                    EmailAddress = "knelson@aoll.com",
                    Password = "painting",
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.03m
                };
                a25.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a25.Id, "Student");
                Students.Add(a25);

                AppUser a26 = new AppUser()
                {
                    EmailAddress = "joewin@xfactor.com",
                    Password = "Password1",
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.65m
                };
                a26.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                UserManager.AddToRole(a26.Id, "Student");
                Students.Add(a26);

                AppUser a27 = new AppUser()
                {
                    EmailAddress = "orielly@foxnews.cnn",
                    Password = "penguin12",
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.46m
                };
                a27.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a27.Id, "Student");
                Students.Add(a27);

                AppUser a28 = new AppUser()
                {
                    EmailAddress = "ankaisrad@gogle.com",
                    Password = "pepperoni",
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.67m
                };
                a28.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a28.Id, "Student");
                Students.Add(a28);

                AppUser a29 = new AppUser()
                {
                    EmailAddress = "megrhodes@freserve.co.uk",
                    Password = "potato",
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.14m
                };
                a29.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                UserManager.AddToRole(a29.Id, "Student");
                Students.Add(a29);

                AppUser a30 = new AppUser()
                {
                    EmailAddress = "erynrice@aoll.com",
                    Password = "radgirl",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.92m
                };
                a30.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                UserManager.AddToRole(a30.Id, "Student");
                Students.Add(a30);

                AppUser a31 = new AppUser()
                {
                    EmailAddress = "jorge@noclue.com",
                    Password = "raiders",
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.64m
                };
                a31.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a31.Id, "Student");
                Students.Add(a31);

                AppUser a32 = new AppUser()
                {
                    EmailAddress = "mrrogers@lovelyday.com",
                    Password = "ricearoni",
                    FirstName = "Allen",
                    LastName = "Rogers",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.01m
                };
                a32.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                UserManager.AddToRole(a32.Id, "Student");
                Students.Add(a32);

                AppUser a33 = new AppUser()
                {
                    EmailAddress = "stjean@athome.com",
                    Password = "rogerthat",
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.24m
                };
                a33.Major = db.Majors.FirstOrDefault(c => c.Name == "Science and Technology Management");
                UserManager.AddToRole(a33.Id, "Student");
                Students.Add(a33);

                AppUser a34 = new AppUser()
                {
                    EmailAddress = "saunders@pen.com",
                    Password = "slowwind",
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.16m
                };
                a34.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                UserManager.AddToRole(a34.Id, "Student");
                Students.Add(a34);

                AppUser a35 = new AppUser()
                {
                    EmailAddress = "willsheff@email.com",
                    Password = "smitty444",
                    FirstName = "William",
                    LastName = "Sewell",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a35.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a35.Id, "Student");
                Students.Add(a35);

                AppUser a36 = new AppUser()
                {
                    EmailAddress = "sheffiled@gogle.com",
                    Password = "snowsnow",
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.36m
                };
                a36.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a36.Id, "Student");
                Students.Add(a36);

                AppUser a37 = new AppUser()
                {
                    EmailAddress = "johnsmith187@aoll.com",
                    Password = "something",
                    FirstName = "John",
                    LastName = "Smith",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.57m
                };
                a37.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a37.Id, "Student");
                Students.Add(a37);

                AppUser a38 = new AppUser()
                {
                    EmailAddress = "dustroud@mail.com",
                    Password = "spotmydog",
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.49m
                };
                a38.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                UserManager.AddToRole(a38.Id, "Student");
                Students.Add(a38);

                AppUser a39 = new AppUser()
                {
                    EmailAddress = "estuart@anchor.net",
                    Password = "stewball",
                    FirstName = "Eric",
                    LastName = "Stuart",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.58m
                };
                a39.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a39.Id, "Student");
                Students.Add(a39);

                AppUser a40 = new AppUser()
                {
                    EmailAddress = "peterstump@noclue.com",
                    Password = "tanner5454",
                    FirstName = "Peter",
                    LastName = "Stump",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 2.55m
                };
                a40.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                UserManager.AddToRole(a40.Id, "Student");
                Students.Add(a40);

                AppUser a41 = new AppUser()
                {
                    EmailAddress = "jtanner@mustang.net",
                    Password = "taylorbaylor",
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.16m
                };
                a41.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                UserManager.AddToRole(a41.Id, "Student");
                Students.Add(a41);

                AppUser a42 = new AppUser()
                {
                    EmailAddress = "taylordjay@aoll.com",
                    Password = "teeoff22",
                    FirstName = "Allison",
                    LastName = "Taylor",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a42.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                UserManager.AddToRole(a42.Id, "Student");
                Students.Add(a42);

                AppUser a43 = new AppUser()
                {
                    EmailAddress = "rtaylor@gogle.com",
                    Password = "texas1",
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 2.88m
                };
                a43.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a43.Id, "Student");
                Students.Add(a43);

                AppUser a44 = new AppUser()
                {
                    EmailAddress = "teefrank@noclue.com",
                    Password = "toddy25",
                    FirstName = "Frank",
                    LastName = "Tee",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.5m
                };
                a44.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a44.Id, "Student");
                Students.Add(a44);

                AppUser a45 = new AppUser()
                {
                    EmailAddress = "ctucker@alphabet.co.uk",
                    Password = "tucksack1",
                    FirstName = "Clent",
                    LastName = "Tucker",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.04m
                };
                a45.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a45.Id, "Student");
                Students.Add(a45);

                AppUser a46 = new AppUser()
                {
                    EmailAddress = "avelasco@yoho.com",
                    Password = "vinovino",
                    FirstName = "Allen",
                    LastName = "Velasco",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.55m
                };
                a46.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                UserManager.AddToRole(a46.Id, "Student");
                Students.Add(a46);

                AppUser a47 = new AppUser()
                {
                    EmailAddress = "vinovino@grapes.com",
                    Password = "whatever",
                    FirstName = "Janet",
                    LastName = "Vino",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.28m
                };
                a47.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                UserManager.AddToRole(a47.Id, "Student");
                Students.Add(a47);

                AppUser a48 = new AppUser()
                {
                    EmailAddress = "winner@hootmail.com",
                    Password = "woodyman1",
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.57m
                };
                a48.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                UserManager.AddToRole(a48.Id, "Student");
                Students.Add(a48);
            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
