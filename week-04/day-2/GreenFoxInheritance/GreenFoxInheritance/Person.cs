using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Person
    {
        // private string name = "Jane Doe";
        // private int age = 30;
        // private Gender gender = Gender.female;

        public string Name{ get; set; } = "Jane Doe";
        public int Age { get; set; } = 30;
        public Gender Gender { get; set; } = Gender.female;

        public Person()
        {
        }

        public Person(string name , int age, Gender gender)
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
