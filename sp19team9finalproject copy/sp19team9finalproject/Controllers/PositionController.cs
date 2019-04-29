using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

//need to change all _context to _db 
namespace sp19team9finalproject.Controllers
{
    public class PositionController : Controller
    {
        private AppDbContext _db;

        public PositionController(AppDbContext context)
        {
            _db = context;
        }

        // GET: Position
        public ActionResult Index()
        {
            //TO-DO: should display all positions on position index page 
            //this line is querying database for all positions  
            var query = from p in _db.Positions
                        select p;
            //TO-DO: have to only show positions who have deadlines today or beyond, so query these 
            DateTime thisDay = DateTime.Today;

            query = query.Where(p => p.Deadline >= thisDay);

            return View(_db.Positions.Include(p => p.Company).ToList())

        }
        public ActionResult DetailedSearch()
        {
            //TO-DO: need to create method to get all industries 
            ViewBag.AllIndustries = GetAllIndustries();

            //TOD-DO: need to create method to get all 
            ViewBag.AllMajors = GetAllMajors();

            return View();
        }

        public SelectList GetAllIndustries()
        {
            //how to get all industries from companies ??
            List<Company> Industries = _db.Company.Industry

        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();
            
            Major SelectNone = new Major() { MajorID = 0, Name = "All Majors"}
            Majors.Add(SelectNone);

            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "Name");

            return AllMajors;
        }

        public ActionResult DisplaySearchResults(String Company, int SelectedIndustry, PositionType SelectedPositionType, int SelectedMajor, string Location)
        {

            var query = from p in _db.Positions
                select p;
                
            if (Company != null && Company != "") //they picked something
            {
                query = query.Where(p => p.Company.Contains(Company));
            }

            //TO-DO: selected industry 
            //if (SelectedIndustry)
            if (SelectedIndustry != 0) //if not selected all majors 
            {
                query = query.Where(p => p.Company.Industry == SelectedIndustry);
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
                query = query.Where(p => p.MajorDetails.Major == SelectedMajor);
            }

            if (Location != null && Location != "")
            {
                query = query.Where(p => p.Location.Contains(Location));
            }
            //execute query by calling the /.ToList() method

            List<Position> SelectedPositions = query.Include(b => b.Company).ToList();

            return View("Index", SelectedPositions);
        }
            // GET: Position/Details/5
        
        public async Task<IActionResult> Details(int? id)
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
                _db.Add(position);
                await _db.SaveChangesAsync();
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

            var position = await _db.Positions.FindAsync(id);
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
                    _db.Update(position);
                    await _db.SaveChangesAsync();
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

            var position = await _db.Positions
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
            var position = await _db.Positions.FindAsync(id);
            _db.Positions.Remove(position);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionExists(int id)
        {
            return _db.Positions.Any(e => e.PositionID == id);
        }
    }
}
