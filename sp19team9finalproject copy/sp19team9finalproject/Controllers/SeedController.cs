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
    }
}
