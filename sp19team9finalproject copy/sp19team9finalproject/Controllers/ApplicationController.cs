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
        public async Task<IActionResult> Index()
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
                List<Application> Applications = _context.Applications.Where(o => o.AppUser.UserName == UserID).ToList();

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

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Application/Create
        public IActionResult Create(Int32 positionId)
        {
            //to-do: format the view for create 
            //TO-DO:return error message if student type doesnt match position type (full time or internship). They can't apply so cant create application for them.
            //TO-DO:return error message if student major is not included in applicable majors for this position 

            Application ap = new Application();
            ap.Position = _context.Positions.Find(positionId);

            //pass newly created application
            return View(ap);
        }

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationID,Result")] Application application)
        {
            //if (ModelState.IsValid)
            //{
            //_context.Add(application);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            //}

            //ask identity who is logged in
            string id = User.Identity.Name;
            //get user from db 
            AppUser user = _context.Users.FirstOrDefault(u => u.Username == id);

            if (user.PositionType != Position.PositionType || user.Major != Position.MajorDetails.Major)

            Application AppUser = user;

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
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ApplicationID == id);
        }
    }
}
