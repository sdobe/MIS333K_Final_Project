using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sp19team9finalproject.Models
{
    public class Company
    {
        public Int32 CompanyID { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public String Email { get; set; }

        public String Description { get; set; }

        [Required(ErrorMessage = "Industry is required")]
        public String Industry { get; set; }

        [Required(ErrorMessage = "Company Name is Required")]
        [Display(Name = "Company Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Company Address is Required")]
        [Display(Name = "Address")]
        public String Location{get; set;}

        public List<Position> Positions { get; set; }

        public List<AppUser> AppUsers { get; set;  }
    }
}
