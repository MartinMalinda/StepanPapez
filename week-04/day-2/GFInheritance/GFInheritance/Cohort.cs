using System;
using System.Collections.Generic;
using System.Text;

namespace GFInheritance
{
    class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        public Cohort(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
