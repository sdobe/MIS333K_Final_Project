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
        public async Task<IActionResult> Index()
        {
            List<Interview> interviews = _context.Interviews();

            if (User.IsInRole("Manager"))
            {
                interviews = _context.Interviews.Where(i => i.AppUser.Company).ToList();
            }
            else
            {
                interviews = _context.Interviews.Where(i => i.AppUser.UserName == User.Identity.Name).Include(intv => intv.ApplicationId).ToList();
            }

            return View(interviews);
        }

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
        public IActionResult Create(Int32 applicationId)
        {
            Interview iv = new Interview();
            iv.Interview = _context.Applications.Find(applicationId);
            ViewBag.AllShowings = GetAllShowings();

            //make sure you pass the newly created order detail to the view
            return View(rd);
        }

        // POST: Interview/Create
        //TO-DO: should be passing selected interview time slot to create the interview 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterviewID,DateTime,RoomNumber")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
    }
}
