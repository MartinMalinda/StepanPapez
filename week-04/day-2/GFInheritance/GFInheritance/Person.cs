using System;
using System.Collections.Generic;
using System.Text;

namespace GFInheritance
{
    class Person
    {
        // private string name = "Jane Doe";
        // private int age = 30;
        // private Gender gender = Gender.female;

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = Gender.female;
        }

        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} years old {Gender}.");
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
