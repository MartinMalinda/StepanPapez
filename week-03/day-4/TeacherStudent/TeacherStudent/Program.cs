using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student and Teacher classes
            // Student
            // Learn()->prints the student is learning something new
            // Question(teacher)->calls the teachers answer method
            // Teacher
            // Teach(student)->calls the students learn method
            // Answer()->prints the teacher is answering a question
            // Instantiate a Student and Teacher object
            // Call the student's Question() method and the teacher's Teach() method

            var student = new Student();
            var teacher = new Teacher();

            student.Question(teacher);
            teacher.Teach(student);
        }
    }
}
