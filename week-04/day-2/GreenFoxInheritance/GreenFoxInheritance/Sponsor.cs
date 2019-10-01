using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Sponsor : Person
    {
        public string Company { get; set; } = "Google";
        public int HiredStudents { get; set; } = 0;

        public Sponsor()
        {
        }

        public Sponsor(string name, int age, Gender gender, string company) : base(name, age, gender)
        {
            this.Company = company;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            HiredStudents++;
        }
    }
}
