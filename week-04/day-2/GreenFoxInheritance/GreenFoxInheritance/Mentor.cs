using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Mentor : Person
    {
        public Level Level { get; private set; }

        public Mentor()
        {
            this.Level = Level.intermediate;
        }

        public Mentor(string name, int age, Gender gender, Level level) : base(name, age, gender)
        {
            this.Level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }
    }
}
