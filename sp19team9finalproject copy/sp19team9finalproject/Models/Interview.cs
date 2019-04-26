using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sp19team9finalproject.Models
{
    public class Interview
    {
        public Int32 InterviewID { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime DateTime { get; set; }

        public String RoomNumber { get; set; }

        [InverseProperty("InterviewsGiven")]
        public AppUser Interviewer { get; set; }

        [InverseProperty("InterviewsSuffered")]
        public AppUser Interviewee { get; set; }
    }
}
