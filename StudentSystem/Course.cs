using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class Course
    {
        // Properties to hold course information
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        
        // Constructor to initialize the course object
        public Course(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        // Method to add a student to the course
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        //Method to print all students in the course
        public void PrintStudents()
        {
            Console.WriteLine($"Course: {Name}");
            foreach (Student student in Students)
            {
                student.PrintInfo();
            }
        }
    }
}
