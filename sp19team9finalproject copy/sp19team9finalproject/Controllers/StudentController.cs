using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;
using Microsoft.AspNetCore.Authorization;


//TO-DO: this controller needs to only be seen by recruiters (maybe CSO)
//TO-DO: need to add a button for students to home index for recruiters (maybe CSO) 
namespace sp19team9finalproject.Controllers
{
    //also authorize CSO 
    [Authorize]
    public class StudentController : Controller
    {
        private AppDbContext ___db;

        public StudentController(AppDbContext context)
        {
            ___db = context;
        }

        // GET: Student 
        public ActionResult Index()
        {
            if (User.IsInRole("CSO") || User.IsInRole("Recruiter"))
            {
                String id = User.Identity.Name;
                AppUser user = ___db.Users.FirstOrDefault(a => a.UserName == id);
              
                var query = from s in ___db.AppUsers
                            select s;

                query = query.Where(s => s.Id != user.Id);
                List<AppUser> AppUsers = query.Include(s => s.Major).ToList();
                //.ToList and return to view 
                return View(AppUsers);
            }
            else //is a student 
            {

                String id = User.Identity.Name;
                AppUser user = ___db.Users.FirstOrDefault(u => u.UserName == id);

                var query = from s in ___db.AppUsers
                            select s;

                //query app users to get students own profile 
                query = query.Where(s => s.Id == user.Id);

                List<AppUser> AppUsers = query.Include(s => s.Major).ToList();

                //.ToList and return to view 
                return View(AppUsers);
            }
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var student = await ___db.AppUsers.FindAsync(Id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string Id, [Bind("FirstName,Lastname,Email,GradDate,GPA")] AppUser student)
        {
            //String id = User.Identity.Name;
            AppUser user = ___db.Users.FirstOrDefault(u => u.Id == Id);

            if (Id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

               ___db.Update(student);
               await ___db.SaveChangesAsync();
               
              return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public ActionResult DetailedSearch()
        {
            //Populates viewbag for majors 
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = ___db.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, Name = "All Majors" };
            Majors.Add(SelectNone);

            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "Name");

            return AllMajors;
        }


        public ActionResult DisplaySearchResults(String GradDate, int SelectedMajor, PositionType SelectedPositionType, string EnteredGPA)
        {
            var query = from stu in ___db.AppUsers
                        select stu;

            //TO-DO: should the search for grad date show students with grad dates before or equal to the date they picked or smthing else 
            if (GradDate != null)
            {
                query = query.Where(s => s.GradDate == GradDate);
            }

            if (SelectedMajor != 0) //if not selected all majors 
            {

                query = query.Where(s => s.Major.MajorID == SelectedMajor);

            }

            if (SelectedPositionType == PositionType.FullTime) //if choose full time
            {
                query = query.Where(s => s.PositionType == PositionType.FullTime);
            }

            if (SelectedPositionType == PositionType.Internship)
            {
                query = query.Where(s => s.PositionType == PositionType.Internship);
            }

            if (EnteredGPA != null && EnteredGPA != "")
            {
                decimal decEnteredGPA;
                try
                {
                    decEnteredGPA = Convert.ToDecimal(EnteredGPA);
                }
                catch
                {
                    ViewBag.Message = "GPA must be a valid decimal";
                    ViewBag.AllGenres = GetAllMajors();
                    return View("DetailedSearch");
                }

            }

            List<AppUser> SelectedStudents = query.Include(b => b.Major).ToList();

            return View("Index", SelectedStudents);

        }
    }
}