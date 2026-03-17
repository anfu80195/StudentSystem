using StudentSystem;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create students objects
            Student s1 = new Student("Andreas", 27);
            Student s2 = new Student("Anika", 25);
            Student s3 = new Student("Emmerence", 28);
            Student s4 = new Student("Kristoffer", 33);
            Student s5 = new Student("Oesten", 28);

            // Add student object to list
            List<Student> students = new List<Student>
            {
                s1,
                s2,
                s3,
                s4,
                s5
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