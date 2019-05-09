using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sp19team9finalproject.Controllers
{
    public class SeedController : Controller
    {

        private AppDbContext _db;

        public SeedController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index", "Home");
        }

        public IActionResult SeedMajors()
        {
            try
            {
                Seeding.SeedMajors.SeedAllMajors(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }

        public IActionResult SeedCompanies()
        {
            try
            {
                Seeding.SeedCompanies.SeedAllCompanies(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }

        public IActionResult SeedStudents(AppDbContext db, IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            try
            {
                Seeding.SeedStudents.SeedAllStudents(serviceProvider);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }

        //public IActionResult SeedRecruiters()
        //{
        //    try
        //    {
        //        Seeding.SeedRecruiters.SeedAllRecruiters(_db);
        //    }
        //    catch (NotSupportedException ex)
        //    {
        //        return View("Error", new String[] { "Already Seeded", ex.Message });
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return View("Error", new String[] { "Error", ex.Message });
        //    }
        //    return View("Confirm");
        //}

        //public IActionResult SeedCSO()
        //{
        //    try
        //    {
        //        Seeding.SeedCSO.SeedAllCSO(_db);
        //    }
        //    catch (NotSupportedException ex)
        //    {
        //        return View("Error", new String[] { "Already Seeded", ex.Message });
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return View("Error", new String[] { "Error", ex.Message });
        //    }
        //    return View("Confirm");
        //}

        public IActionResult SeedPositions()
        {
            try
            {
                Seeding.SeedPositions.SeedAllPositions(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }

        public IActionResult SeedApplications()
        {
            try
            {
                Seeding.SeedApplications.SeedAllApplications(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }

        public IActionResult SeedInterviews()
        {
            try
            {
                Seeding.SeedInterviews.SeedAllInterviews(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "Already Seeded", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "Error", ex.Message });
            }
            return View("Confirm");
        }
    }
}
