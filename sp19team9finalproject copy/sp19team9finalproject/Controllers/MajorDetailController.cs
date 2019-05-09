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
    public class MajorDetailController : Controller
    {
        private readonly App_dbContext _context;

        public MajorDetailController(App_dbContext context)
        {
            _context = context;
        }

        // GET: MajorDetail
        public async Task<IActionResult> Index()
        {
            return View(await _context.MajorDetails.ToListAsync());
        }

        // GET: MajorDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var majorDetail = await _context.MajorDetails
                .FirstOrDefaultAsync(m => m.MajorDetailID == id);
            if (majorDetail == null)
            {
                return NotFound();
            }

            return View(majorDetail);
        }

        // GET: MajorDetail/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MajorDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MajorDetailID")] MajorDetail majorDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(majorDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(majorDetail);
        }

        // GET: MajorDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var majorDetail = await _context.MajorDetails.FindAsync(id);
            if (majorDetail == null)
            {
                return NotFound();
            }
            return View(majorDetail);
        }

        // POST: MajorDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MajorDetailID")] MajorDetail majorDetail)
        {
            if (id != majorDetail.MajorDetailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(majorDetail);
                    await _context.SaveChangesAsync();
                }
                catch (_dbUpdateConcurrencyException)
                {
                    if (!MajorDetailExists(majorDetail.MajorDetailID))
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
            return View(majorDetail);
        }

        // GET: MajorDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var majorDetail = await _context.MajorDetails
                .FirstOrDefaultAsync(m => m.MajorDetailID == id);
            if (majorDetail == null)
            {
                return NotFound();
            }

            return View(majorDetail);
        }

        // POST: MajorDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var majorDetail = await _context.MajorDetails.FindAsync(id);
            _context.MajorDetails.Remove(majorDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MajorDetailExists(int id)
        {
            return _context.MajorDetails.Any(e => e.MajorDetailID == id);
        }
    }
}
