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
    public class ApplicationController : Controller
    {
        private readonly AppDbContext _context;

        public ApplicationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Application
        public IActionResult Index()
        {

            List<Application> applications = _context.Applications.Include(r => r.Position).ToList();
            //TO-DO: change this to change functionality for CSO (can see all applications)
            if (User.IsInRole("Manager"))
            {
                return View(_context.Applications.ToList());
            }
            else //user is a student - only get to see their own
            {
                //ask identity who is logged in 
                String UserID = User.Identity.Name;

                //find applications associated with this user 
                //TO-DO: fix this underline 
                List<Application> Applications = _context.Applications.Where(o => o.AppUser.UserName == User.Identity.Name).Include(o => o.Position).ThenInclude(o => o.Company).ToList();

                //send the view only the applications that belong to this user
                return View(Applications);
            }
        }

        // GET: Application/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.Include(r => r.Position).ThenInclude(r => r.Company)
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Application/Create
        public IActionResult Create()
        {
            ViewBag.AllPositions = GetAllPositions();
            return View();
        }

        public SelectList GetAllPositions()
        {
            List<Position> positions = _context.Positions.ToList();
            SelectList AllPositions = new SelectList(positions.OrderBy(g => g.PositionID), "PositionID", "Title");

            return AllPositions;
        }

        //public IActionResult Create(Int32 positionId)
        //{
        //    //to-do: format the view for create 
        //    //TO-DO:return error message if student type doesnt match position type (full time or internship). They can't apply so cant create application for them.
        //    //TO-DO:return error message if student major is not included in applicable majors for this position 

        //    Application ap = new Application();
        //    ap.Position = _context.Positions.Find(positionId);

        //    //pass newly created application
        //    return View(ap);
        //}

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationID,Result")] Application application, Int32 SelectedPosition)
        {
            if (ModelState.IsValid)
            {
                //ask identity who is logged in
                string id = User.Identity.Name;
                AppUser user = _context.Users.Include(u => u.Major).FirstOrDefault(u => u.UserName == id);

                //Associates the application with the user 
                //application.AppUser = user;

                bool ApplicableMajors = false;

                Position pos = _context.Positions.Find(SelectedPosition);
                application.Position = pos;

                application.AppUser = user;
                application.Result = "Pending";

                foreach (MajorDetail md in application.Position.MajorDetails)
                {
                    if (md.Major == user.Major)
                    {
                        ApplicableMajors = true;
                    }

                }
                

                if (user.PositionType == application.Position.PositionType || ApplicableMajors == true )
                {
                    _context.Add(application);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Position");
                }
                else
                {
                    //TO-DO: return error message because user cant apply for this position 
                    return RedirectToAction("Index");
                }

                //application.Position.MajorDetails.Major == user.Major Contains(user.Major)) //to do have to check if student major matches position majors 


            }

            

            return View(application);
        }

        // GET: Application/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationID,Result")] Application application)
        {
            if (id != application.ApplicationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ApplicationID))
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
            return View(application);
        }

        //TO-DO: Need to edit get and post methods so that student can withdraw(delete) an application
        //TO-DO:Change button name to withdraw instead of delete
        //TO-DO:Student cannot delete applciation if deadline has already past
        // GET: Application/Delete/5
        public async Task<IActionResult> Delete(int? id)
        { 
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            application.Result = "Withdrawn";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ApplicationID == id);
        }

        //GET: Application/AcceptStudents
        public IActionResult AcceptStudents(int? id)
        {
            //make a list of all applications for the position clicked on from
            var query = from ap in _context.Applications
                        select ap;
            //Shows positions who have deadlines today or beyond
            DateTime thisDay = DateTime.Today;

            query = query.Where(ap => ap.Position.PositionID >= id);

            query = query.Where(ap => ap.Position.Deadline >= thisDay);

            List<Application> SelectedApplications = query.Include(ap => ap.AppUser).ToList();

            //convert list to multi select list 
            MultiSelectList ListSelectedApplications = new MultiSelectList(SelectedApplications.OrderBy(ap => ap.ApplicationID), "ApplicationID", "AppUser.LastName");
            ViewBag.ListSelectedApplications = ListSelectedApplications;

            return View();

            //this list should display student name but store app id 
            //this list goes in viewbag that recruiters will get to select the students they want to accept 
        }

        //POST: Application/AcceptStudents 
        //the list of students that they chose to accept 
        //can I pass a multiselect list, that includes a number of application objects 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AcceptStudentsAsync(int[] AcceptedStudents)
        {
            //get a list of all applications where the int in the retreived multiselect list matches the int
            var query = from app in _context.Applications
                        select app;

            foreach (int application in AcceptedStudents)
            {
                //query a new student list of accepted application
                query = query.Where(app => app.ApplicationID == application);
            }

            List<Application> AcceptedApplications = query.Include(b => b.Position).ToList();

            foreach (Application a in AcceptedApplications)
            {
                //itterate through new list of Accepted Applications and change result into accepted and save changes tp database 
                //this is where
                a.Result = "Accepted";
                _context.Update(a);
                await _context.SaveChangesAsync();
            }


            //should pass a list of AcceptedApplications to Applications/index so now they see applications that are accepted  
            return View("Index", AcceptedApplications);

        }

    }
}
