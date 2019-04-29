using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//TODO: Change this using statement to match your project
using sp19team9finalproject.Models;

//TODO: Make this namespace match your project
namespace sp19team9finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //TODO: Add your DbSets here.  You will need one for each model you want to store in the database
        //IMPORTANT: Do NOT add DbSets for your ViewModel classes - they are not stored in your database
        public DbSet<Application> Applications { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Major> Majors { get; set; }

        public DbSet<MajorDetail> MajorDetails { get; set; }

        public DbSet<Position> Positions { get; set; }
        //Also, remember that Identity will add a DbSet for your User class.  It will be called Users.  
        //If you add another DbSet for users, you WILL get an error

    }
}
