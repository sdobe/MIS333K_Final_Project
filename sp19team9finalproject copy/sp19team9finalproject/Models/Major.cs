using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace sp19team9finalproject.Models
{
    public class Major
    {
        public Int32 MajorID { get; set; }

        public String Name { get; set; }

        public List<MajorDetail> MajorDetails { get; set; }

        public List<AppUser> AppUsers { get; set; }

    }
}
