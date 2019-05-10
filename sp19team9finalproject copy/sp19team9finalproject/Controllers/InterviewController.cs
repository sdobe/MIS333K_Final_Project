using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Controllers
{
    public class InterviewController : Controller
    {
        private readonly AppDbContext _context;

        public InterviewController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Interview
        //To-do: student should only see their own interviews query the db
        public IActionResult Index()
        {
            if (User.IsInRole("Recruiter"))
            {
                String id = User.Identity.Name;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

                List<Interview> Interviews = new List<Interview>();
                Interviews = _context.Interviews.Where(inv => inv.Interviewer.UserName == user.UserName).Include(inv => inv.Position).ToList();
                return View(Interviews.OrderByDescending(inv => inv.Position.PositionID));
            }
            if (User.IsInRole("Student"))
            {
                String id = User.Identity.Name;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

                var query = from b in _context.Interviews
                            select b;
                query = query.Where(inv => inv.Interviewee.Id == user.Id);
                List<Interview> Interviews = query.Include(inv => inv.Position).ToList();
                //Interviews = _context.Interviews.Where(inv => inv.Interviewee.Id == user.Id).Include(inv => inv.Position.Title).ToList();
                return View(Interviews);
            }
            else //if CSO 
            {
                //This line is querying database for all interviews  
                var query = from inv in _context.Interviews
                            select inv;
                            
                return View(_context.Interviews.Include(p => p.Position).ToList());
            }
        }

        //public IActionResult Index(Int32 posID)
        //{
        //    var query = from inter in _context.Interviews
        //                select inter;
        //    query = query.Where(inter => inter.Position.PositionID == posID);
        //    query = query.Where(inter => inter.Interviewee == null);

        //    List<Interview> inters = query.Include(inv => inv.Position).ToList();
        //    return View(inters);

        //}

        // GET: Interview/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.InterviewID == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        //to-do: student should only be able to create an interview if student's application was accepted, reference result on application class
        //with an if statement, else they get an error message that they were not accepted  
        //to-do: need to use route value to get application ID 
        //to-do: 
        // GET: Interview/Create
        public IActionResult Create()
        {
            //ask identity who is logged in
            string id = User.Identity.Name;
            //get user from db 
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);
       
            ViewBag.Positions = GetAllPositions(user);
            ViewBag.Interviewers = GetAllInterviewers(user);

            return View();
        }

        // POST: Interview/Create
        //TO-DO: should be passing selected interview time slot to create the interview 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterviewID,Position,Date,Time,RoomNumber")] Interview interview, int SelectedPosition, string SelectedInterviewer)
        {
            var query = from i in _context.Interviews
                        select i;

            List <Interview> AllInterviews = query.ToList();

            foreach (Interview i in AllInterviews)
            {
                if (i.Date == interview.Date && i.Time == interview.Time && i.RoomNumber == interview.RoomNumber)
                {
                    //if this turns out to be true then return to page where they create interview 
                    string u = User.Identity.Name;
                    //get user from db 
                    AppUser usr = _context.Users.FirstOrDefault(o => o.UserName == u);

                    ViewBag.Positions = GetAllPositions(usr);
                    ViewBag.Interviewers = GetAllInterviewers(usr);

                    return View(interview);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(interview);
                await _context.SaveChangesAsync();


                //add navigational data
                // find the position with the same 
                return RedirectToAction(nameof(Index));
            }

            string id = User.Identity.Name;
            //get user from db 
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            ViewBag.Positions = GetAllPositions(user);
            ViewBag.Interviewers = GetAllInterviewers(user);

            return View(interview);
        }

        // GET: Interview/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews.FindAsync(id);
            if (interview == null)
            {
                return NotFound();
            }
            return View(interview);
        }

        // POST: Interview/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterviewID,DateTime,RoomNumber")] Interview interview)
        {
            if (id != interview.InterviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterviewExists(interview.InterviewID))
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
            return View(interview);
        }

        // GET: Interview/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.InterviewID == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // POST: Interview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interview = await _context.Interviews.FindAsync(id);
            _context.Interviews.Remove(interview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterviewExists(int id)
        {
            return _context.Interviews.Any(e => e.InterviewID == id);
        }

        public SelectList GetAllPositions(AppUser user)
        {
            List<Position> AllPositions = _context.Positions.ToList();

            List<Position> SelectedPositions = new List<Position>();

            //String id = User.Identity.Name;
            //AppUser user = _context.Users.Include(m => m.Company).FirstOrDefault(u => u.UserName == id);
            //List<Position> Positions = new List<Position>();
            //Positions = _context.Positions.Where(o => o.Company.Name == user.Company.Name).ToList();

            foreach (Position cd in AllPositions)
            {
                if(cd.Company == user.Company)
                {
                    SelectedPositions.Add(cd);
                }
            }

            SelectList positions = new SelectList(SelectedPositions, "PositionID", "Title");

            return positions;
        }

        public SelectList GetAllInterviewers(AppUser user)
        {

            List<AppUser> AllAppUsers = _context.AppUsers.ToList();

            List<AppUser> SelectedUsers = new List<AppUser>();

            foreach (AppUser cd in AllAppUsers)
            {
                if (cd.Company == cd.Company)
                {
                    SelectedUsers.Add(cd);
                }
            }

            SelectList interviewers = new SelectList(SelectedUsers, "Id", "LastName");

            return interviewers;
        }
    }
}
