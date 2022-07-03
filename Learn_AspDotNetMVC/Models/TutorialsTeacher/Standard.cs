using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learn_AspDotNetMVC.Models.TutorialsTeacher
{
    public class Standard
    {
        public int Id { get; set; }
        [Display(Name = "Standard Name")]
        public string Name { get; set; }
    }
}