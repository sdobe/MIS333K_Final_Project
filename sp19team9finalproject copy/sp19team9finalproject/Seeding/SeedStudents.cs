using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;
using Microsoft.Extensions.DependencyInjection;

namespace sp19team9finalproject.Seeding
{
    public class SeedStudents
    {

        public static void SeedAllStudents(AppDbContext db, IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

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
                    Email = "cbaker@example.com",
                    PasswordHash = "bookworm",
                    FirstName = "Christopher",
                    LastName = "Baker",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.91m
                };
                a1.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a1, "Student");
                Students.Add(a1);

                AppUser a2 = new AppUser()
                {
                    Email = "banker@longhorn.net",
                    PasswordHash = "aclfest2017",
                    FirstName = "Michelle",
                    LastName = "Banks",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.52m
                };
                a2.Major = db.Majors.FirstOrDefault(c => c.Name == "International Business");
                _userManager.AddToRoleAsync(a2, "Student");
                Students.Add(a2);

                AppUser a3 = new AppUser()
                {
                    Email = "franco@example.com",
                    PasswordHash = "aggies",
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.2m
                };
                a3.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a3, "Student");
                Students.Add(a3);

                AppUser a4 = new AppUser()
                {
                    Email = "wchang@example.com",
                    PasswordHash = "alaskaboy",
                    FirstName = "Wendy",
                    LastName = "Chang",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.56m
                };
                a4.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a4, "Student");
                Students.Add(a4);

                AppUser a5 = new AppUser()
                {
                    Email = "limchou@gogle.com",
                    PasswordHash = "allyrally",
                    FirstName = "Lim",
                    LastName = "Chou",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 2.63m
                };
                a5.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a5, "Student");
                Students.Add(a5);

                AppUser a6 = new AppUser()
                {
                    Email = "shdixon@aoll.com",
                    PasswordHash = "Anchorage",
                    FirstName = "Shan",
                    LastName = "Dixon",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.62m
                };
                a6.Major = db.Majors.FirstOrDefault(c => c.Name == "International Business");
                _userManager.AddToRoleAsync(a6, "Student");
                Students.Add(a6);

                AppUser a7 = new AppUser()
                {
                    Email = "j.b.evans@aheca.org",
                    PasswordHash = "billyboy",
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.64m
                };
                a7.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                _userManager.AddToRoleAsync(a7, "Student");
                Students.Add(a7);

                AppUser a8 = new AppUser()
                {
                    Email = "freeley@penguin.org",
                    PasswordHash = "bunnyhop",
                    FirstName = "Lou Ann",
                    LastName = "Freeley",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.66m
                };
                a8.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                _userManager.AddToRoleAsync(a8, "Student");
                Students.Add(a8);

                AppUser a9 = new AppUser()
                {
                    Email = "tfreeley@minnetonka.ci.us",
                    PasswordHash = "dustydusty",
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.98m
                };
                a9.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                _userManager.AddToRoleAsync(a9, "Student");
                Students.Add(a9);

                AppUser a10 = new AppUser()
                {
                    Email = "mgarcia@gogle.com",
                    PasswordHash = "gowest",
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.22m
                };
                a10.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a10, "Student");
                Students.Add(a10);

                AppUser a11 = new AppUser()
                {
                    Email = "jeffh@sonic.com",
                    PasswordHash = "hickhickup",
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.66m
                };
                a11.Major = db.Majors.FirstOrDefault(c => c.Name == "Science and Technology Management");
                _userManager.AddToRoleAsync(a11, "Student");
                Students.Add(a11);

                AppUser a12 = new AppUser()
                {
                    Email = "wjhearniii@umich.org",
                    PasswordHash = "ingram2015",
                    FirstName = "John",
                    LastName = "Hearn",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.46m
                };
                a12.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a12, "Student");
                Students.Add(a12);

                AppUser a13 = new AppUser()
                {
                    Email = "ahick@yaho.com",
                    PasswordHash = "jhearn22",
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.12m
                };
                a13.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                _userManager.AddToRoleAsync(a13, "Student");
                Students.Add(a13);

                AppUser a14 = new AppUser()
                {
                    Email = "ingram@jack.com",
                    PasswordHash = "joejoejoe",
                    FirstName = "Brad",
                    LastName = "Ingram",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.72m
                };
                a14.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                _userManager.AddToRoleAsync(a14, "Student");
                Students.Add(a14);

                AppUser a15 = new AppUser()
                {
                    Email = "toddj@yourmom.com",
                    PasswordHash = "jrod2017",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.64m
                };
                a15.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a15, "Student");
                Students.Add(a15);

                AppUser a16 = new AppUser()
                {
                    Email = "thequeen@aska.net",
                    PasswordHash = "longhorns",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.72m
                };
                a16.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a16, "Student");
                Students.Add(a16);

                AppUser a17 = new AppUser()
                {
                    Email = "linebacker@gogle.com",
                    PasswordHash = "louielouie",
                    FirstName = "Erik",
                    LastName = "Lineback",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.15m
                };
                a17.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                _userManager.AddToRoleAsync(a17, "Student");
                Students.Add(a17);

                AppUser a18 = new AppUser()
                {
                    Email = "elowe@netscare.net",
                    PasswordHash = "martin1234",
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a18.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a18, "Student");
                Students.Add(a18);

                AppUser a19 = new AppUser()
                {
                    Email = "cluce@gogle.com",
                    PasswordHash = "meganr34",
                    FirstName = "Chuck",
                    LastName = "Luce",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.87m
                };
                a19.Major = db.Majors.FirstOrDefault(c => c.Name == "Accounting");
                _userManager.AddToRoleAsync(a19, "Student");
                Students.Add(a19);

                AppUser a20 = new AppUser()
                {
                    Email = "mackcloud@george.com",
                    PasswordHash = "meow88",
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 4m
                };
                a20.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a20, "Student");
                Students.Add(a20);

                AppUser a21 = new AppUser()
                {
                    Email = "cmartin@beets.com",
                    PasswordHash = "mustangs",
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.53m
                };
                a21.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a21, "Student");
                Students.Add(a21);

                AppUser a22 = new AppUser()
                {
                    Email = "clarence@yoho.com",
                    PasswordHash = "mydogspot",
                    FirstName = "Clarence",
                    LastName = "Martin",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.11m
                };
                a22.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                _userManager.AddToRoleAsync(a22, "Student");
                Students.Add(a22);

                AppUser a23 = new AppUser()
                {
                    Email = "gregmartinez@drdre.com",
                    PasswordHash = "nothinggood",
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.43m
                };
                a23.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a23, "Student");
                Students.Add(a23);

                AppUser a24 = new AppUser()
                {
                    Email = "cmiller@bob.com",
                    PasswordHash = "onetime",
                    FirstName = "Charles",
                    LastName = "Miller",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.14m
                };
                a24.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                _userManager.AddToRoleAsync(a24, "Student");
                Students.Add(a24);

                AppUser a25 = new AppUser()
                {
                    Email = "knelson@aoll.com",
                    PasswordHash = "painting",
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.03m
                };
                a25.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a25, "Student");
                Students.Add(a25);

                AppUser a26 = new AppUser()
                {
                    Email = "joewin@xfactor.com",
                    PasswordHash = "Password1",
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.65m
                };
                a26.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                _userManager.AddToRoleAsync(a26, "Student");
                Students.Add(a26);

                AppUser a27 = new AppUser()
                {
                    Email = "orielly@foxnews.cnn",
                    PasswordHash = "penguin12",
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.46m
                };
                a27.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a27, "Student");
                Students.Add(a27);

                AppUser a28 = new AppUser()
                {
                    Email = "ankaisrad@gogle.com",
                    PasswordHash = "pepperoni",
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.67m
                };
                a28.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a28, "Student");
                Students.Add(a28);

                AppUser a29 = new AppUser()
                {
                    Email = "megrhodes@freserve.co.uk",
                    PasswordHash = "potato",
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.14m
                };
                a29.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                _userManager.AddToRoleAsync(a29, "Student");
                Students.Add(a29);

                AppUser a30 = new AppUser()
                {
                    Email = "erynrice@aoll.com",
                    PasswordHash = "radgirl",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    GradDate = new DateTime(2022),
                    PositionType = PositionType.Internship,
                    GPA = 3.92m
                };
                a30.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                _userManager.AddToRoleAsync(a30, "Student");
                Students.Add(a30);

                AppUser a31 = new AppUser()
                {
                    Email = "jorge@noclue.com",
                    PasswordHash = "raiders",
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.64m
                };
                a31.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a31, "Student");
                Students.Add(a31);

                AppUser a32 = new AppUser()
                {
                    Email = "mrrogers@lovelyday.com",
                    PasswordHash = "ricearoni",
                    FirstName = "Allen",
                    LastName = "Rogers",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.01m
                };
                a32.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                _userManager.AddToRoleAsync(a32, "Student");
                Students.Add(a32);

                AppUser a33 = new AppUser()
                {
                    Email = "stjean@athome.com",
                    PasswordHash = "rogerthat",
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.24m
                };
                a33.Major = db.Majors.FirstOrDefault(c => c.Name == "Science and Technology Management");
                _userManager.AddToRoleAsync(a33, "Student");
                Students.Add(a33);

                AppUser a34 = new AppUser()
                {
                    Email = "saunders@pen.com",
                    PasswordHash = "slowwind",
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.16m
                };
                a34.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                _userManager.AddToRoleAsync(a34, "Student");
                Students.Add(a34);

                AppUser a35 = new AppUser()
                {
                    Email = "willsheff@email.com",
                    PasswordHash = "smitty444",
                    FirstName = "William",
                    LastName = "Sewell",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a35.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a35, "Student");
                Students.Add(a35);

                AppUser a36 = new AppUser()
                {
                    Email = "sheffiled@gogle.com",
                    PasswordHash = "snowsnow",
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.36m
                };
                a36.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a36, "Student");
                Students.Add(a36);

                AppUser a37 = new AppUser()
                {
                    Email = "johnsmith187@aoll.com",
                    PasswordHash = "something",
                    FirstName = "John",
                    LastName = "Smith",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.57m
                };
                a37.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a37, "Student");
                Students.Add(a37);

                AppUser a38 = new AppUser()
                {
                    Email = "dustroud@mail.com",
                    PasswordHash = "spotmydog",
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.49m
                };
                a38.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                _userManager.AddToRoleAsync(a38, "Student");
                Students.Add(a38);

                AppUser a39 = new AppUser()
                {
                    Email = "estuart@anchor.net",
                    PasswordHash = "stewball",
                    FirstName = "Eric",
                    LastName = "Stuart",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.58m
                };
                a39.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a39, "Student");
                Students.Add(a39);

                AppUser a40 = new AppUser()
                {
                    Email = "peterstump@noclue.com",
                    PasswordHash = "tanner5454",
                    FirstName = "Peter",
                    LastName = "Stump",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 2.55m
                };
                a40.Major = db.Majors.FirstOrDefault(c => c.Name == "Supply Chain Management");
                _userManager.AddToRoleAsync(a40, "Student");
                Students.Add(a40);

                AppUser a41 = new AppUser()
                {
                    Email = "jtanner@mustang.net",
                    PasswordHash = "taylorbaylor",
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.16m
                };
                a41.Major = db.Majors.FirstOrDefault(c => c.Name == "Management");
                _userManager.AddToRoleAsync(a41, "Student");
                Students.Add(a41);

                AppUser a42 = new AppUser()
                {
                    Email = "taylordjay@aoll.com",
                    PasswordHash = "teeoff22",
                    FirstName = "Allison",
                    LastName = "Taylor",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.07m
                };
                a42.Major = db.Majors.FirstOrDefault(c => c.Name == "Marketing");
                _userManager.AddToRoleAsync(a42, "Student");
                Students.Add(a42);

                AppUser a43 = new AppUser()
                {
                    Email = "rtaylor@gogle.com",
                    PasswordHash = "texas1",
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 2.88m
                };
                a43.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a43, "Student");
                Students.Add(a43);

                AppUser a44 = new AppUser()
                {
                    Email = "teefrank@noclue.com",
                    PasswordHash = "toddy25",
                    FirstName = "Frank",
                    LastName = "Tee",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.5m
                };
                a44.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a44, "Student");
                Students.Add(a44);

                AppUser a45 = new AppUser()
                {
                    Email = "ctucker@alphabet.co.uk",
                    PasswordHash = "tucksack1",
                    FirstName = "Clent",
                    LastName = "Tucker",
                    GradDate = new DateTime(2020),
                    PositionType = PositionType.Internship,
                    GPA = 3.04m
                };
                a45.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a45, "Student");
                Students.Add(a45);

                AppUser a46 = new AppUser()
                {
                    Email = "avelasco@yoho.com",
                    PasswordHash = "vinovino",
                    FirstName = "Allen",
                    LastName = "Velasco",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 3.55m
                };
                a46.Major = db.Majors.FirstOrDefault(c => c.Name == "MIS");
                _userManager.AddToRoleAsync(a46, "Student");
                Students.Add(a46);

                AppUser a47 = new AppUser()
                {
                    Email = "vinovino@grapes.com",
                    PasswordHash = "whatever",
                    FirstName = "Janet",
                    LastName = "Vino",
                    GradDate = new DateTime(2021),
                    PositionType = PositionType.Internship,
                    GPA = 3.28m
                };
                a47.Major = db.Majors.FirstOrDefault(c => c.Name == "Business Honors");
                _userManager.AddToRoleAsync(a47, "Student");
                Students.Add(a47);

                AppUser a48 = new AppUser()
                {
                    Email = "winner@hootmail.com",
                    PasswordHash = "woodyman1",
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    GradDate = new DateTime(2019),
                    PositionType = PositionType.FullTime,
                    GPA = 2.57m
                };
                a48.Major = db.Majors.FirstOrDefault(c => c.Name == "Finance");
                _userManager.AddToRoleAsync(a48, "Student");
                Students.Add(a48);

                try
                {
                    foreach (AppUser studentToAdd in Students)
                    {
                        string strMajorName = studentToAdd.FirstName;
                        AppUser dbStudent = db.AppUsers.FirstOrDefault(m => m.Email == studentToAdd.Email);

                        if (dbStudent == null)
                        {
                            db.AppUsers.Add(studentToAdd);
                            db.SaveChanges();
                            intStudentsAdded += 1;
                        }
                        else
                        {
                            dbStudent.FirstName = studentToAdd.FirstName;
                            dbStudent.LastName = studentToAdd.LastName;
                            dbStudent.GradDate = studentToAdd.GradDate;
                            dbStudent.GPA = studentToAdd.GPA;
                            dbStudent.Major = studentToAdd.Major;
                            dbStudent.PositionType = studentToAdd.PositionType;
                            dbStudent.PasswordHash = studentToAdd.PasswordHash;
                            db.Update(dbStudent);
                            db.SaveChanges();
                            intStudentsAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intStudentsAdded + "; ";

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
