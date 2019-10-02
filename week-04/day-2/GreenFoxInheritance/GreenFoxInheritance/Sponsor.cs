using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor()
        {
            this.Company = "Google";
            this.HiredStudents = 0;
        }

        public Sponsor(string name, int age, Gender gender, string company) : base(name, age, gender)
        {
            this.Company = company;
            this.HiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            HiredStudents++;
        }
    }
}
