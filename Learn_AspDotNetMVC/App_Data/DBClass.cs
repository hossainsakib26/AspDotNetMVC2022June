using System.Collections;
using System.Collections.Generic;
using Learn_AspDotNetMVC.Models.TutorialsTeacher;

namespace Learn_AspDotNetMVC.App_Data
{
    public static class DBClass
    {

        public static IList<Student> studentList = new List<Student>
        {
            new Student() {Id = 1, Name = "Potato MIa", Age = "23"},
            new Student() {Id = 2, Name = "Alu MIa", Age = "23"},
            new Student() {Id = 3, Name = "Khazu MIa", Age = "23"},
            new Student() {Id = 4, Name = "Kobra MIa", Age = "23"},
            new Student() {Id = 5, Name = "Huzu MIa", Age = "23"},
            new Student() {Id = 6, Name = "Abal MIa", Age = "23"},
        };

    }
}