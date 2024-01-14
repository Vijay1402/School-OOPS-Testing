using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime DoJ {  get; set; }

        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Vikram", Subject = "Computer Science",DoJ = new DateTime(12/12/12)},
            new Teacher { Id = 2, Name = "Vishu", Subject = "English",DoJ = new DateTime(12/12/16)},
            new Teacher { Id = 3, Name = "Vijay", Subject = "Biology",DoJ = new DateTime(12/12/11)}
        };

        public bool FindByName(string name)
        {
            bool isFound = false;
            if (teachers.Find(s => s.Name == name) != null)
            {
                isFound = true;
            };
            return isFound;
        }
    }
}
