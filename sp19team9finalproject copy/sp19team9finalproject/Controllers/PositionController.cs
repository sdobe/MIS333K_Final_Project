using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

//need to change all _context to ___db 
namespace sp19team9finalproject.Controllers
{
    public class PositionController : Controller
    {
        private AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Position
        public ActionResult Index()
        {
            if (User.IsInRole("Recruiter"))
            {
                String id = User.Identity.Name;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

                List<Position> Positions = new List<Position>();
                Positions = _context.Positions.Where(b => b.Company.Name == user.Company.Name).Include(b => b.Title).ToList();
                return View(Positions.OrderByDescending(b => b.PositionID));

            }
            else
            {
                //This line is querying database for all positions  
                var query = from b in _context.Positions
                            select b;

                //Shows positions who have deadlines today or beyond
                DateTime thisDay = DateTime.Today;
                query = query.Where(b => b.Deadline >= thisDay).Include(b => b.MajorDetails).ThenInclude(b => b.Major);
                List<Position> SelectedPositions = query.Include(b => b.Company).ToList();

                ViewBag.SelectedPositionsCount = SelectedPositions.Count();
                ViewBag.AllPositionsCount = _context.Positions.Count();

                return View("Index", SelectedPositions);
            }

        }
        public ActionResult DetailedSearch()
        {
            //Populates viewbag for majors 
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _context.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, Name = "All Majors" };
            Majors.Add(SelectNone);

            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "Name");

            return AllMajors;
        }

        //i removed SelectedMajor have to add it back to parameters later
        public ActionResult DisplaySearchResults(String CompanySearchString, string IndustrySearchString, PositionType SelectedPositionType, int SelectedMajor,  string Location)
        {
            var query = from p in _context.Positions
                select p;

            DateTime thisDay = DateTime.Today;

            query = query.Where(p => p.Deadline >= thisDay);

            if (CompanySearchString != null && CompanySearchString != "") //they picked something
            {
                query = query.Where(p => p.Company.Name.Contains(CompanySearchString));
            }

            //TO-DO: selected industry 
            //if (SelectedIndustry)
            if (IndustrySearchString != null && IndustrySearchString != "") //if not selected all majors 
            {
                query = query.Where(p => p.Company.Industry.Contains(IndustrySearchString));
            }

            if (SelectedPositionType == PositionType.FullTime) //if choose full time
            {
                query = query.Where(p => p.PositionType == PositionType.FullTime);
            }

            if (SelectedPositionType == PositionType.Internship)
            {
                query = query.Where(p => p.PositionType == PositionType.Internship);
            }


            if (SelectedMajor != 0) //if not selected all majors 
            {

                query = query.Where(p => p.MajorDetails.Any(m => m.Major.MajorID == SelectedMajor));
                //trying to query an instance of major detail from each position's major details to see if it matches the major user selected 
            }



            if (Location != null && Location != "")
            {
                query = query.Where(p => p.Location.Contains(Location));
            }

            //execute query by calling the /.ToList() method
            List<Position> SelectedPositions = query.Include(b => b.Company).Include(b => b.MajorDetails).ThenInclude(b => b.Major).ToList();

            return View("Index", SelectedPositions);
        }
        
        // GET: Position/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //update this statement to have an include clause to get the info on position 
            Position position = await _context.Positions
                .Include(r => r.Company).Include(r => r.MajorDetails).ThenInclude(r => r.Major)
                .FirstOrDefaultAsync(m => m.PositionID == id);

            if (position == null)
            {
                return NotFound();
            }

            return View(position);
        }

        // GET: Position/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Position/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,Title,Description,Type,Location,Deadline")] Position position)
        {
            if (ModelState.IsValid)
            {
                _context.Add(position);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(position);
        }

        // GET: Position/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }
            return View(position);
        }

        // POST: Position/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PositionID,Title,Description,Type,Location,Deadline")] Position position)
        {
            if (id != position.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(position);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionExists(position.PositionID))
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
            return View(position);
        }

        // GET: Position/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }

            return View(position);
        }

        // POST: Position/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionExists(int id)
        {
            return _context.Positions.Any(e => e.PositionID == id);
        }

    }
}
