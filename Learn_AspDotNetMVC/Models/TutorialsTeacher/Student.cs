using System.ComponentModel.DataAnnotations;
using Learn_AspDotNetMVC.Models.Enum;

namespace Learn_AspDotNetMVC.Models.TutorialsTeacher
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Student Name")] [Required(ErrorMessage = "Please, enter a name!")]
        public string Name { get; set; }
        [Required] [Range(05, 30)]
        public string Age { get; set; }
        public int GenderID { get; set; }

        public Standard Standard { get; set; }
        public Gender Gender { get; set; }
    }
}