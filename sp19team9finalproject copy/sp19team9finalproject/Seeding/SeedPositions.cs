using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
            List<MajorDetail>majorDetails = new List<MajorDetail>();

            try
            {
                Position p1 = new Position()
                {
                    Title = "Supply Chain Internship",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 05, 05)
                };
                p1.Company = db.Companies.FirstOrDefault(c => c.Name == "Shell");
                MajorDetail mj1 = new MajorDetail()
                {
                    Position = p1,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Supply Chain Management")
                };
                majorDetails.Add(mj1);
                Positions.Add(p1);

                Position p2 = new Position()
                {
                    Title = "Accounting Intern",
                    Description = "Work in our audit group",
                    PositionType = PositionType.Internship,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 05, 01)
                };
                p2.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                MajorDetail mj2 = new MajorDetail()
                {
                    Position = p2,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj2);
                Positions.Add(p2);

                Position p3 = new Position()
                {
                    Title = "Web Development",
                    Description = "Developing a great new website for customer portfolio management",
                    PositionType = PositionType.FullTime,
                    Location = "Richmond, Virginia",
                    Deadline = new DateTime(2019, 03, 14)
                };
                p3.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                MajorDetail mj3 = new MajorDetail()
                {
                    Position = p3,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj3);
                Positions.Add(p3);

                Position p4 = new Position()
                {
                    Title = "Sales Associate",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Los Angeles, California",
                    Deadline = new DateTime(2019, 04, 01)
                };
                p4.Company = db.Companies.FirstOrDefault(c => c.Name == "Aon");
                MajorDetail mj4 = new MajorDetail()
                {
                    Position = p4,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj4);

                MajorDetail mj5 = new MajorDetail()
                {
                    Position = p4,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj5);

                MajorDetail mj6 = new MajorDetail()
                {
                    Position = p4,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj6);
                Positions.Add(p4);

                Position p5 = new Position()
                {
                    Title = "Amenities Analytics Intern",
                    Description = "Help analyze our amenities and customer rewards programs",
                    PositionType = PositionType.Internship,
                    Location = "New York, New York",
                    Deadline = new DateTime(2019, 03, 30)
                };
                p5.Company = db.Companies.FirstOrDefault(c => c.Name == "Hilton Worldwide");
                MajorDetail mj7 = new MajorDetail()
                {
                    Position = p5,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj7);

                MajorDetail mj8 = new MajorDetail()
                {
                    Position = p5,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj8);

                MajorDetail mj9 = new MajorDetail()
                {
                    Position = p5,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj9);

                MajorDetail mj10 = new MajorDetail()
                {
                    Position = p5,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj10);
                Positions.Add(p5);

                Position p6 = new Position()
                {
                    Title = "Junior Programmer",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 04, 03)
                };
                p6.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj11 = new MajorDetail()
                {
                    Position = p6,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj11);
                Positions.Add(p6);

                Position p7 = new Position()
                {
                    Title = "Consultant ",
                    Description = "Full-time consultant position",
                    PositionType = PositionType.FullTime,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 04, 15)
                };
                p7.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                MajorDetail mj12 = new MajorDetail()
                {
                    Position = p7,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj12);

                MajorDetail mj13 = new MajorDetail()
                {
                    Position = p7,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj13);

                MajorDetail mj14 = new MajorDetail()
                {
                    Position = p7,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                }; majorDetails.Add(mj14);
                Positions.Add(p7);

                Position p8 = new Position()
                {
                    Title = "Project Manager",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Chicago, Illinois",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p8.Company = db.Companies.FirstOrDefault(c => c.Name == "Aon");
                MajorDetail mj15 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj15);

                MajorDetail mj16 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Supply Chain Management")
                };
                majorDetails.Add(mj16);

                MajorDetail mj17 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj17);

                MajorDetail mj18 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj18);

                MajorDetail mj19 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj19);

                MajorDetail mj20 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "International Business")
                };
                majorDetails.Add(mj20);

                MajorDetail mj21 = new MajorDetail()
                {
                    Position = p8,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj21);
                Positions.Add(p8);

                Position p9 = new Position()
                {
                    Title = "Account Manager",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 02, 28)
                };
                p9.Company = db.Companies.FirstOrDefault(c => c.Name == "Deloitte");
                MajorDetail mj23 = new MajorDetail()
                {
                    Position = p9,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj23);

                MajorDetail mj24 = new MajorDetail()
                {
                    Position = p9,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj24);
                Positions.Add(p9);

                Position p10 = new Position()
                {
                    Title = "Marketing Intern",
                    Description = "Help our marketing team develop new advertising strategies for local Austin businesses",
                    PositionType = PositionType.Internship,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 04, 30)
                };
                p10.Company = db.Companies.FirstOrDefault(c => c.Name == "Adlucent");
                MajorDetail mj25 = new MajorDetail()
                {
                    Position = p10,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj25);
                Positions.Add(p10);

                Position p11 = new Position()
                {
                    Title = "Financial Analyst",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Richmond, Virginia",
                    Deadline = new DateTime(2019, 04, 15)
                };
                p11.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                MajorDetail mj26 = new MajorDetail()
                {
                    Position = p11,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj26);
                Positions.Add(p11);

                Position p12 = new Position()
                {
                    Title = "Pilot",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Ft. Worth, Texas",
                    Deadline = new DateTime(2019, 10, 08)
                };
                p12.Company = db.Companies.FirstOrDefault(c => c.Name == "United Airlines");
                MajorDetail mj27 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj27);

                MajorDetail mj28 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Supply Chain Management")
                };
                majorDetails.Add(mj28);

                MajorDetail mj29 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj29);

                MajorDetail mj30 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj30);

                MajorDetail mj31 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj31);

                MajorDetail mj32 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "International Business")
                };
                majorDetails.Add(mj32);

                MajorDetail mj33 = new MajorDetail()
                {
                    Position = p12,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj33);
                Positions.Add(p12);

                Position p13 = new Position()
                {
                    Title = "Corporate Recruiting Intern",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 04, 30)
                };
                p13.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj35 = new MajorDetail()
                {
                    Position = p13,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Management")
                };
                majorDetails.Add(mj35);
                Positions.Add(p13);

                Position p14 = new Position()
                {
                    Title = "Business Analyst",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 05, 31)
                };
                p14.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj36 = new MajorDetail()
                {
                    Position = p14,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj36);
                Positions.Add(p14);

                Position p15 = new Position()
                {
                    Title = "Programmer Analyst",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Minneapolis, Minnesota",
                    Deadline = new DateTime(2019, 05, 15)
                };
                p15.Company = db.Companies.FirstOrDefault(c => c.Name == "Target");
                MajorDetail mj37 = new MajorDetail()
                {
                    Position = p15,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj37);
                Positions.Add(p15);

                Position p16 = new Position()
                {
                    Title = "Intern",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Minneapolis, Minnesota",
                    Deadline = new DateTime(2019, 05, 15)
                };
                p16.Company = db.Companies.FirstOrDefault(c => c.Name == "Target");
                MajorDetail mj38 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj38);
                MajorDetail mj66 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj66);
                MajorDetail mj67 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj67);
                MajorDetail mj68 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "International Business")
                };
                majorDetails.Add(mj68);
                MajorDetail mj69 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj69);
                MajorDetail mj70 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Supply Chain Management")
                };
                majorDetails.Add(mj70);
                MajorDetail mj71 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Science and Technology Management")
                };
                majorDetails.Add(mj71);
                MajorDetail mj72 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Management")
                };
                majorDetails.Add(mj72);
                MajorDetail mj73 = new MajorDetail()
                {
                    Position = p16,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj73);
                Positions.Add(p16);

                Position p17 = new Position()
                {
                    Title = "Digital Intern",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 05, 20)
                };
                p17.Company = db.Companies.FirstOrDefault(c => c.Name == "Accenture");
                MajorDetail mj39 = new MajorDetail()
                {
                    Position = p17,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj39);

                MajorDetail mj40 = new MajorDetail()
                {
                    Position = p17,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj40);
                Positions.Add(p17);

                Position p18 = new Position()
                {
                    Title = "Analyst Development Program",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Plano, Texas",
                    Deadline = new DateTime(2019, 05, 20)
                };
                p18.Company = db.Companies.FirstOrDefault(c => c.Name == "Capital One");
                MajorDetail mj41 = new MajorDetail()
                {
                    Position = p18,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj41);

                MajorDetail mj42 = new MajorDetail()
                {
                    Position = p18,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj42);

                MajorDetail mj43 = new MajorDetail()
                {
                    Position = p18,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj43);
                Positions.Add(p18);

                Position p19 = new Position()
                {
                    Title = "Procurements Associate",
                    Description = "Handle procurement and vendor accounts",
                    PositionType = PositionType.FullTime,
                    Location = "Houston,  Texas",
                    Deadline = new DateTime(2019, 05, 30)
                };
                p19.Company = db.Companies.FirstOrDefault(c => c.Name == "Shell");
                MajorDetail mj44 = new MajorDetail()
                {
                    Position = p19,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Supply Chain Management")
                };
                majorDetails.Add(mj44);
                Positions.Add(p19);

                Position p20 = new Position()
                {
                    Title = "IT Rotational Program",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 05, 30)
                };
                p20.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                MajorDetail mj45 = new MajorDetail()
                {
                    Position = p20,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj45);
                Positions.Add(p20);

                Position p21 = new Position()
                {
                    Title = "Sales Rotational Program",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 05, 30)
                };
                p21.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                MajorDetail mj46 = new MajorDetail()
                {
                    Position = p21,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj46);

                MajorDetail mj47 = new MajorDetail()
                {
                    Position = p21,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Management")
                };
                majorDetails.Add(mj47);

                MajorDetail mj48 = new MajorDetail()
                {
                    Position = p21,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj48);

                MajorDetail mj49 = new MajorDetail()
                {
                    Position = p21,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj49);
                Positions.Add(p21);

                Position p22 = new Position()
                {
                    Title = "Accounting Rotational Program",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 05, 30)
                };
                p22.Company = db.Companies.FirstOrDefault(c => c.Name == "Texas Instruments");
                MajorDetail mj50 = new MajorDetail()
                {
                    Position = p22,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj50);
                Positions.Add(p22);

                Position p23 = new Position()
                {
                    Title = "Financial Planning Intern",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Orlando, Florida",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p23.Company = db.Companies.FirstOrDefault(c => c.Name == "Academy Sports & Outdoors");
                MajorDetail mj51 = new MajorDetail()
                {
                    Position = p23,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj51);

                MajorDetail mj52 = new MajorDetail()
                {
                    Position = p23,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Accounting")
                };
                majorDetails.Add(mj52);

                MajorDetail mj53 = new MajorDetail()
                {
                    Position = p23,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj53);
                Positions.Add(p23);

                Position p24 = new Position()
                {
                    Title = "Digital Product Manager",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p24.Company = db.Companies.FirstOrDefault(c => c.Name == "Academy Sports & Outdoors");
                MajorDetail mj54 = new MajorDetail()
                {
                    Position = p24,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj54);

                MajorDetail mj55 = new MajorDetail()
                {
                    Position = p24,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj55);

                MajorDetail mj56 = new MajorDetail()
                {
                    Position = p24,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Business Honors")
                };
                majorDetails.Add(mj56);

                MajorDetail mj57 = new MajorDetail()
                {
                    Position = p24,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Management")
                };
                majorDetails.Add(mj57);
                Positions.Add(p24);

                Position p25 = new Position()
                {
                    Title = "Product Marketing Intern",
                    Description = "",
                    PositionType = PositionType.Internship,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p25.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj58 = new MajorDetail()
                {
                    Position = p25,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj58);

                MajorDetail mj59 = new MajorDetail()
                {
                    Position = p25,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj59);
                Positions.Add(p25);

                Position p26 = new Position()
                {
                    Title = "Program Manager",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p26.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj60 = new MajorDetail()
                {
                    Position = p26,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Marketing")
                };
                majorDetails.Add(mj60);

                MajorDetail mj61 = new MajorDetail()
                {
                    Position = p26,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj61);
                Positions.Add(p26);

                Position p27 = new Position()
                {
                    Title = "Security Analyst",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 06, 01)
                };
                p27.Company = db.Companies.FirstOrDefault(c => c.Name == "Microsoft");
                MajorDetail mj62 = new MajorDetail()
                {
                    Position = p27,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj62);
                Positions.Add(p27);

                Position p28 = new Position()
                {
                    Title = "Big Data Analyst",
                    Description = "",
                    PositionType = PositionType.FullTime,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 05, 09)
                };
                p28.Company = db.Companies.FirstOrDefault(c => c.Name == "United Airlines");
                MajorDetail mj63 = new MajorDetail()
                {
                    Position = p28,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "MIS")
                };
                majorDetails.Add(mj63);

                MajorDetail mj64 = new MajorDetail()
                {
                    Position = p28,
                    Major = db.Majors.FirstOrDefault(m => m.Name == "Finance")
                };
                majorDetails.Add(mj64);
                Positions.Add(p28);
                try
                {
                    foreach (Position positionToAdd in Positions)
                    {

                        Position dbPosition = db.Positions.FirstOrDefault(m => m.Title == positionToAdd.Title);

                        if (dbPosition == null)
                        {
                            db.Positions.Add(positionToAdd);
                            db.SaveChanges();
                            intPositionsAdded += 1;
                        }
                        else
                        {
                            dbPosition.Title = positionToAdd.Title;
                            dbPosition.Description = positionToAdd.Description;
                            dbPosition.PositionType = positionToAdd.PositionType;
                            dbPosition.Location = positionToAdd.Location;
                            dbPosition.Company = positionToAdd.Company;
                            dbPosition.Deadline = positionToAdd.Deadline;
                            dbPosition.MajorDetails = positionToAdd.MajorDetails;
                            db.Update(dbPosition);
                            db.SaveChanges();
                            intPositionsAdded += 1;
                        }
                    }
                    foreach (MajorDetail mdToAdd in majorDetails)
                    {
                        MajorDetail dbMD = db.MajorDetails.FirstOrDefault(m => m.MajorDetailID == mdToAdd.MajorDetailID);

                        if (dbMD == null)
                        {
                            db.MajorDetails.Add(mdToAdd);
                            db.SaveChanges();
                            
                        }
                        else
                        {
                            dbMD.Position = mdToAdd.Position;
                            dbMD.Major = mdToAdd.Major;
                            db.Update(dbMD);
                            db.SaveChanges();
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intPositionsAdded + "; ";

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
