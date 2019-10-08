using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        public void Teach(Student student)
        {
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine("I'm answering a question");
        }
    }
}
