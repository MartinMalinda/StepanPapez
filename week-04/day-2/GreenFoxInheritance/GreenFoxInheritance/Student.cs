using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; } = "The School of Life";
        public int SkippedDays { get; set; } = 0;

        public Student()
        {
        }

        public Student(string name, int age, Gender gender, string previousOrganization) : base(name, age, gender)
        {
            this.PreviousOrganization = previousOrganization;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.SkippedDays += numberOfDays;
        }
    }
}
