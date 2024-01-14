using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }

        List<Subject> subjects = new List<Subject>()
        {
            new Subject { Id = 1, Name = "English", Stream = "State Board"},
            new Subject { Id = 2, Name = "Biology", Stream = "ICSE"},
            new Subject { Id = 3, Name = "Computer Science", Stream = "CBSE"}
        };

        public bool FindByName(string name)
        {
            bool isFound = false;
            if (subjects.Find(s => s.Name == name) != null)
            {
                isFound = true;
            };
            return isFound;
        }
    }
}
