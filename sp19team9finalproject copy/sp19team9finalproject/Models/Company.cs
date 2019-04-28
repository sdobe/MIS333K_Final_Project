﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sp19team9finalproject.Models
{
    public class Company
    {
        public Int32 CompanyID { get; set; }

        [Display(Name = "Email")]
        public String EmailAddress { get; set; }

        public String Description { get; set; }

        public String Industry { get; set; }

        public String Name { get; set; }

        public String Location{get; set;}

        public List<Position> Positions { get; set; }

        public List<AppUser> AppUsers { get; set;  }
    }
}
