using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learn_AspDotNetMVC.Models.TutorialsTeacher
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        public string Age { get; set; }

        public Standard Standard { get; set; }
    }
}