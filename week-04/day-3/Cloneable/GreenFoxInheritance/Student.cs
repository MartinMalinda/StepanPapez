using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student()
        {
            this.PreviousOrganization = "The School of Life";
            this.SkippedDays = 0;
        }

        public Student(string name, int age, Gender gender, string previousOrganization) : base(name, age, gender)
        {
            this.PreviousOrganization = previousOrganization;
            this.SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
        }
    }
}
