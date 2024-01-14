using SchoolManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Suresh", Class = "7C"},
            new Student { Id = 2, Name = "Maya", Class = "9A"},
            new Student { Id = 3, Name = "Akshaya", Class = "10B"}
        };

        public bool FindByName(string name)
        {
            bool isFound = false;
            if(students.Find(s => s.Name == name) != null)
            {
               isFound = true;
            };
            return isFound;
        }

    }
}
