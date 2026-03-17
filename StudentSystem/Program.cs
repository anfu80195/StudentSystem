using StudentSystem;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create student objects and add inside list
            List<Student> students = new List<Student>
            {
                new Student("Andreas", 27),
                new Student("Anika", 25),
                new Student("Emmerence", 28),
                new Student("Kristoffer", 33),
                new Student("Østen", 28),
            };

            // Create a course 
            Course c1 = new Course("Programming 101");
            Course c2 = new Course("System Development 28+");

            // Add students to the course
            foreach (Student student in students)
            {
                c1.AddStudent(student);

                if (student.Age >= 28)
                {
                    c2.AddStudent(student);
                }
            }

            // Print students for both courses
            c1.PrintStudents();
            Console.WriteLine();
            c2.PrintStudents();

            /*Console.WriteLine("\nStudents over 27 years old:");

            foreach (Student student in c1.Students)
            {
                if (student.Age >= 28)
                {
                    student.PrintInfo();
                }
            }*/
        }
    }
}