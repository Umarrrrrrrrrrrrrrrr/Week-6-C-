using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectanglee
{
    public class StudentService
    {
        public void SortStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student("Eliza"),
                new Student("Bikram"),
                new Student("Chris"),
                new Student("Dipika"),
                new Student("Farhan"),
                new Student("Aayush"),
                new Student("Himesh"),
                new Student("John"),
                new Student("Gita"),
                new Student("Ishani")
            };

            var sorted = students.OrderBy(s => s.Name);

            Console.WriteLine("\nStudents Sorted Alphabetically:");
            foreach (var s in sorted)
                Console.WriteLine(s.Name);
        }
    }
}
