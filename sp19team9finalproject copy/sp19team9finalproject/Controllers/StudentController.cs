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
    [Authorize(Roles = "Recruiter")]
    public class StudentController : Controller
    {
        private AppDbContext _db;

        public StudentController(AppDbContext context)
        {
            _db = context;
        }

        // GET: Student 
        public ActionResult Index()
        {
            var query = from s in _db.AppUsers
                        select s;

            //query app users where app user is in role "student", if user is a student, they would have to have a gpa 
            query = query.Where(s => s.GPA != 0);

            //.ToList and return to view 
            return View(_db.AppUsers.Include(s => s.Major).ToList());
        }

        public ActionResult StudentSearch()
        {
            //Populates viewbag for majors 
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, Name = "All Majors" };
            Majors.Add(SelectNone);

            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "Name");

            return AllMajors;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DisplaySearchResults(DateTime? GradDate, int SelectedMajor, PositionType SelectedPositionType, string EnteredGPA)
        {
            var query = from stu in _db.AppUsers
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