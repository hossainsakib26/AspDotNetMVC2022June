using System.Collections;
using System.Collections.Generic;
using Learn_AspDotNetMVC.Models.TutorialsTeacher;

namespace Learn_AspDotNetMVC.App_Data
{
    public static class DBClass
    {

        public static IList<Student> studentList = new List<Student>
        {
            new Student() {Id = 1, Name = "Potato Mia", Age = "23", GenderID = 1,},
            new Student() {Id = 2, Name = "Alu Mia", Age = "23", GenderID = 1,},
            new Student() {Id = 3, Name = "Maiasa Lamia", Age = "23", GenderID = 2,},
            new Student() {Id = 4, Name = "Kobra Zamia", Age = "23", GenderID = 2,},
            new Student() {Id = 5, Name = "Huzu Mia", Age = "23", GenderID = 1,},
            new Student() {Id = 6, Name = "Abal Mia", Age = "23", GenderID = 1,},
        };

    }
}