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
            return View(DBClass.studentList);
        }

        public ActionResult Edit(int id, string name)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var id = std.Id;
            var name = std.Name;
            var age = std.Age;
            var standardName = std.Standard.Name;

            return RedirectToAction("Index");
        }
    }
}