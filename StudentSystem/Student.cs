using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class Student
    {
        // Properties to hold student information
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the student object
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display student information

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

