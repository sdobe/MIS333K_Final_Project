using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace sp19team9finalproject.Models
{
    public enum PositionType { FullTime , Internship }
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        private String strFullName;
        public String FullName
        {
            get { return strFullName; }

            set { strFullName = FirstName + " " + LastName; }
        }

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

        public AppUser()
        {
            if (InterviewsGiven == null)
            {
                InterviewsGiven = new List<Interview>();
            }

            if (InterviewsSuffered == null)
            {
                InterviewsSuffered = new List<Interview>();
            }
        }
    }
}
