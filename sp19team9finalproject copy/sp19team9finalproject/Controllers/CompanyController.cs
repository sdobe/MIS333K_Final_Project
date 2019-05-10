using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;



namespace sp19team9finalproject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;

        public CompanyController(AppDbContext context)
        {
            _context = context;
        }

        //TO-DO: somewhere in this index need to have a way of getting all of the interviews associated with this company to display 
        // GET: Company
        public IActionResult Index()
        {
        
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //Creates new list of companies
            List<Company> Companies = new List<Company>();
            Companies = _context.Companies.Include(o => o.Positions).ToList();

            //Routes user to the correct view/path
            if (User.IsInRole("CSO"))
            {
                return View(Companies);
            }
            if (User.IsInRole("Recruiter"))
            {
                foreach (Company d in Companies)
                {
                    if (d.Name == user.Company.Name)
                    {
                        Companies = _context.Companies.Where(o => d.Name == user.Company.Name).Include(o => o.Positions).ToList();
                        return View(Companies);
                    }
                    else
                    {

                        return RedirectToAction(nameof(Create));
                        
                    }
                }
            }
            if (User.IsInRole("Student"))
            {
                List<Company> _Companies = _context.Companies.ToList();
                return View(_Companies);
            }

            return View();
        }


        //GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }


        // GET: Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,EmailAddress,Description,Industry")] Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyID,EmailAddress,Description,Industry,Name,Location")] Company company)
        {
            if (id != company.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.CompanyID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyID == id);
        }

        public ActionResult CompanySearch()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DisplayCompSearchResults(string SearchName, string SearchLocation, PositionType SelectedPositionType, string SearchIndustry)
        {
            var query = from com in _context.Companies
                        select com; 

            if (SearchName != null && SearchName != "")
            {
                query = query.Where(com => com.Name.Contains(SearchName));
            }

            if (SearchLocation != null && SearchLocation != "")
            {
                query = query.Where(s => s.Positions.Any(com => com.Location.Contains(SearchLocation)));
            }

           
            if (SelectedPositionType == PositionType.FullTime) //if choose full time
            {
                query = query.Where(s => s.Positions.Any(com => com.PositionType == SelectedPositionType));
            }

            if (SelectedPositionType == PositionType.Internship)
            {
                query = query.Where(s => s.Positions.Any(com => com.PositionType == SelectedPositionType));
            }

            if (SearchIndustry != null && SearchIndustry != "")
            {
                query = query.Where(com => com.Industry.Contains(SearchName));
            }

            List<Company> SelectedCompanies = query.ToList();

            return View("Index", SelectedCompanies);
        }
    }
}
