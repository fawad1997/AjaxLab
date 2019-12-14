using AjaxLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxLab.Controllers
{
    public class HomeController : Controller
    {
        public static List<Course> _courses = new List<Course>()
        {
            new Course { CourseCode="SE1391",Title="Web Application Development" }
        };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetCourses()
        {
            return Json(_courses);
        }
        [HttpPost]
        public JsonResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _courses.Add(course);
            }
            return Json("");
        }

        [HttpPost]
        public JsonResult DeleteCourse(String ccode)
        {
            //First find course with that id
            Course c = _courses.Find(x => x.CourseCode.Equals(ccode));
            //if course is found, means c is not equal to null, then remove that course from the list.
            if (c != null)
            {
                _courses.Remove(c);
            }
            return Json("");
        }
    }
}