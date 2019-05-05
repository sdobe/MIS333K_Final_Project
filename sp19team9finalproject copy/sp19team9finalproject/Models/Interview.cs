using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sp19team9finalproject.Models
{
    public enum Time
    {
        [Display(Name = "8:00 AM")] EIGHT, [Display(Name = "9:00")] NINE, [Display(Name = "10:00 AM")] TEN,
        [Display(Name = "11:00 AM")] ELEVEN, [Display(Name = "1:00 PM")] ONE, [Display(Name = "2:00 PM")] TWO,
        [Display(Name = "3:00 PM")] THREE, [Display(Name = "4:00 PM")] FOUR, [Display(Name = "5:00 PM")] FIVE
    }

    public enum RoomNumber {[Display(Name = "Room 1")] ROOM1, [Display(Name = "Room 2")] ROOM2, [Display(Name = "Room 3")] ROOM3, [Display(Name = "Room 4")] ROOM4 }

    public class Interview
    {
        public Int32 InterviewID { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        public Time Time { get; set; }

        public RoomNumber RoomNumber { get; set; }

        public Position Position { get; set; }

        [InverseProperty("InterviewsGiven")]
        public AppUser Interviewer { get; set; }

        [InverseProperty("InterviewsSuffered")]
        public AppUser Interviewee { get; set; }
    }
}
