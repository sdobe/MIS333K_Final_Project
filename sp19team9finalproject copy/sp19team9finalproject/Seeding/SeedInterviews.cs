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
                Interview i1 = new Interview()
                {
                    Date = new DateTime(2019, 05, 13),
                    Time = Time.ONE,
                    RoomNumber = RoomNumber.ROOM2
                };
                i1.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                i1.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Lou Ann Feeley");
                i1.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Allison Taylor");
                Interviews.Add(i1);

                Interview i2 = new Interview()
                {
                    Date = new DateTime(2019, 05, 14),
                    Time = Time.ONE,
                    RoomNumber = RoomNumber.ROOM2
                };
                i2.Position = db.Positions.FirstOrDefault(p => p.Title == "Marketing Intern");
                i2.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Eryn Rice");
                i2.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Allison Taylor");
                Interviews.Add(i2);

                Interview i3 = new Interview()
                {
                    Date = new DateTime(2019, 05, 15),
                    Time = Time.ONE,
                    RoomNumber = RoomNumber.ROOM2
                };
                i3.Position = db.Positions.FirstOrDefault(p => p.Title == "Corporate Recruiting Intern");
                i3.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Charles Miller");
                i3.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Louis Winthorpe");
                Interviews.Add(i3);

                Interview i4 = new Interview()
                {
                    Date = new DateTime(2019, 05, 13),
                    Time = Time.TEN,
                    RoomNumber = RoomNumber.ROOM1
                };
                i4.Position = db.Positions.FirstOrDefault(p => p.Title == "Account Manager");
                i4.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Eric Stuart");
                i4.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Clarence Martin");
                Interviews.Add(i4);

                Interview i5 = new Interview()
                {
                    Date = new DateTime(2019, 05, 16),
                    Time = Time.TWO,
                    RoomNumber = RoomNumber.ROOM2
                };
                i5.Position = db.Positions.FirstOrDefault(p => p.Title == "Web Development");
                i5.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Christopher Baker");
                i5.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Gregory Martinez");
                Interviews.Add(i5);

                Interview i6 = new Interview()
                {
                    Date = new DateTime(2019, 04, 01),
                    Time = Time.NINE,
                    RoomNumber = RoomNumber.ROOM1
                };
                i6.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                i6.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Eryn Rice");
                i6.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Rachel Taylor");
                Interviews.Add(i6);

                Interview i7 = new Interview()
                {
                    Date = new DateTime(2019, 04, 01),
                    Time = Time.TEN,
                    RoomNumber = RoomNumber.ROOM1
                };
                i7.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                i7.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Tesa Feeley");
                i7.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Rachel Taylor");
                Interviews.Add(i7);

                Interview i8 = new Interview()
                {
                    Date = new DateTime(2019, 04, 02),
                    Time = Time.THREE,
                    RoomNumber = RoomNumber.ROOM4
                };
                i8.Position = db.Positions.FirstOrDefault(p => p.Title == "Amenities Analytics Intern");
                i8.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Lim Chou");
                i8.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Rachel Taylor");
                Interviews.Add(i8);

                Interview i9 = new Interview()
                {
                    Date = new DateTime(2019, 05, 10),
                    Time = Time.NINE,
                    RoomNumber = RoomNumber.ROOM1
                };
                i9.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                i9.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Brad Ingram");
                i9.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Ernest Lowe");
                Interviews.Add(i9);

                Interview i10 = new Interview()
                {
                    Date = new DateTime(2019, 05, 10),
                    Time = Time.ELEVEN,
                    RoomNumber = RoomNumber.ROOM1
                };
                i10.Position = db.Positions.FirstOrDefault(p => p.Title == "Supply Chain Internship");
                i10.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Sarah Saunders");
                i10.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Ernest Lowe");
                Interviews.Add(i10);

                Interview i11 = new Interview()
                {
                    Date = new DateTime(2019, 05, 16),
                    Time = Time.THREE,
                    RoomNumber = RoomNumber.ROOM3
                };
                i11.Position = db.Positions.FirstOrDefault(p => p.Title == "Financial Analyst");
                i11.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "John Smith");
                i11.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Anka Radkovich");
                Interviews.Add(i11);

                Interview i12 = new Interview()
                {
                    Date = new DateTime(2019, 05, 16),
                    Time = Time.ELEVEN,
                    RoomNumber = RoomNumber.ROOM4
                };
                i12.Position = db.Positions.FirstOrDefault(p => p.Title == "Accounting Intern");
                i12.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Chuck Luce");
                i12.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Kelly Nelson");
                Interviews.Add(i12);

                Interview i13 = new Interview()
                {
                    Date = new DateTime(2019, 06, 05),
                    Time = Time.TWO,
                    RoomNumber = RoomNumber.ROOM3
                };
                i13.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                i13.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "Eric Stuart");
                i13.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Michelle Banks");
                Interviews.Add(i13);

                Interview i14 = new Interview()
                {
                    Date = new DateTime(2019, 06, 05),
                    Time = Time.FOUR,
                    RoomNumber = RoomNumber.ROOM3
                };
                i14.Position = db.Positions.FirstOrDefault(p => p.Title == "Consultant ");
                i14.Interviewee = db.AppUsers.FirstOrDefault(q => q.FullName == "John Hearn");
                i14.Interviewer = db.AppUsers.FirstOrDefault(p => p.FullName == "Todd Jacobs");
                Interviews.Add(i14);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
