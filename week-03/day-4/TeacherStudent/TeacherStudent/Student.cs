using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        public Student()
        {

        }

        public void Learn()
        {
            Console.WriteLine("I'm learning something new.");
        }

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
