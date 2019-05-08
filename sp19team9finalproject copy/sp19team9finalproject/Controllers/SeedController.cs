using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sp19team9finalproject.DAL;


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

        public IActionResult SeedStudents()
        {
            try
            {
                Seeding.SeedStudents.SeedAllStudents(_db, serviceprovider);
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

        public IActionResult SeedRecruiters()
        {
            try
            {
                Seeding.SeedRecruiters.SeedAllRecruiters(_db);
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

        public IActionResult SeedCSO()
        {
            try
            {
                Seeding.SeedCSO.SeedAllCSO(_db);
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
