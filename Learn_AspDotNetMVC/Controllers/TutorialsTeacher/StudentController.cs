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

    }
}