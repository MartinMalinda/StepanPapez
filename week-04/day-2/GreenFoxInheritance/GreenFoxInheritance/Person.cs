using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Person
    {
        private string name = "Jane Doe";
        private int age = 30;
        public Gender gender = Gender.female;

        public Person()
        {
        }

        public Person(string name , int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} years old {gender}.");
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
