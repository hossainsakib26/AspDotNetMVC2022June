using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learn_AspDotNetMVC.App_Data;
using Learn_AspDotNetMVC.Models.TutorialsTeacher;

namespace Learn_AspDotNetMVC.Controllers.TutorialsTeacher
{
    public class StudentController : Controller
    {
        public StudentController()
        {
            
        }
        
        //get students
        public ActionResult Index()
        {
            return View(DBClass.studentList.OrderBy(s => s.Id).ToList());
        }

        // GET : Specific student
        public ActionResult Edit(int id)
        {
            var std = DBClass.studentList.Where(c => c.Id == id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var student = DBClass.studentList.Where(c => c.Id == std.Id).FirstOrDefault();
            student = std;


            return RedirectToAction("Index");
        }
    }
}