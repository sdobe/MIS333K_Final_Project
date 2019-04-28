using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace sp19team9finalproject.Models
{
    public class Position
    {
        public Int32 PositionID {get; set;} 

        public String Title { get; set; }

        public String Description { get; set; }

        public String Type { get; set; }

        public String Location { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime Deadline { get; set; }

        public List<MajorDetail> MajorDetails { get; set; }

        public List<Application> Applications { get; set; }

        public Company Company { get; set; }

    }
}
