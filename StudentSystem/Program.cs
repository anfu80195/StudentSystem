using StudentSystem;
using System;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create students
            Student s1 = new Student("Andreas", 27);
            Student s2 = new Student("Emmerence", 28);
            Student s3 = new Student("Oesten", 28);
            Student s4 = new Student("Kristoffer", 33);
            Student s5 = new Student("Anika", 25);

            // Create a course 
            Course c1 = new Course("Programming 101");

            // Add students to the course
            c1.AddStudent(s1);
            c1.AddStudent(s2);
            c1.AddStudent(s3);
            c1.AddStudent(s4);
            c1.AddStudent(s5);

            // Print students in the course
            c1.PrintStudents();

            Console.WriteLine("Students over 27 years old:");

            foreach (Student student in c1.Students)
            {
                if (student.Age > 27)
                {
                    student.PrintInfo();
                }


            }
        }
    }
}