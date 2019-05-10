﻿using System;
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
                var query = from s in ___db.AppUsers
                            select s;

                //query app users where app user is in role "student", if user is a student, they would have to have a gpa 
                query = query.Where(s => s.GPA != 0);
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

        public ActionResult StudentSearch()
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


        public ActionResult DisplaySearchResults(DateTime? GradDate, int SelectedMajor, PositionType SelectedPositionType, string EnteredGPA)
        {
            var query = from stu in ___db.AppUsers
                        select stu;

            //TO-DO: should the search for grad date show students with grad dates before or equal to the date they picked or smthing else 
            //if (GradDate != null)
            //{
                //query = query.Where(s => s.GradDate == GradDate);
            //}

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