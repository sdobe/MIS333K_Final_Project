using System;
namespace sp19team9finalproject.Models
{
    public class Application
    {
        public Int32 ApplicationID { get; set; }

        public String Result { get; set; }

        public AppUser AppUser { get; set; }

        public Position Position { get; set; }
    }
}
