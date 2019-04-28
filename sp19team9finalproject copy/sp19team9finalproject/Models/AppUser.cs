using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sp19team9finalproject.Models
{
    public enum PositionType { FullTime , Internship }
    public class AppUser
    {
        public Int32 AppUserID { get; set; }

        [Display(Name = "Email")]
        public String EmailAddress { get; set; }

        public String Password { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }
         
        //for student
        [Display(Name = "Graduation Date")]
        public DateTime GradDate { get; set; }

        //Position Type for student 
        public PositionType PositionType { get; set; }

        //GPA for student 
        public decimal GPA { get; set; }

        public Major Major { get; set; }

        public List<Application> Applications { get; set; }

        [InverseProperty("Interviewer")]
        public List<Interview> InterviewsGiven { get; set; }

        [InverseProperty("Interviewee")]
        public List<Interview> InterviewsSuffered { get; set; }

        public Company Company { get; set; }
    }
}
