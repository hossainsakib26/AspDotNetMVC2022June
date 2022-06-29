using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learn_AspDotNetMVC.Models.TutorialsTeacher;

namespace Learn_AspDotNetMVC.Controllers.TutorialsTeacher
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "This is Index action method of StudentController";
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            // update data to database for student
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete specifiq student based on ID
            return RedirectToAction("Index");
        }
    }
}