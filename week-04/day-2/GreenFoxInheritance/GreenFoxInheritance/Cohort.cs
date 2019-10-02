using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Cohort
    {
        public string Name { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Mentor> Mentors { get; private set; }

        public Cohort(string name)
        {
            this.Name = name;
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
