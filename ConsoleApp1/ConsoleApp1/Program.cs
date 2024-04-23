using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20, GPA = 3.7 },
                new Student { Name = "Bob", Age = 22, GPA = 3.5 },
                new Student { Name = "Charlie", Age = 19, GPA = 3.8 },
                new Student { Name = "David", Age = 21, GPA = 3.2 }
            };

            // 3 методи розширення вибірки даних
            var highPerformers = students.Where(s => s.GPA >= 3.5).ToList();
            var studentNames = students.Select(s => s.Name).ToList();
            var firstHighPerformer = students.FirstOrDefault(s => s.GPA >= 3.5);

            // 3 методи розширення зміни порядку даних
            var sortedByAge = students.OrderBy(s => s.Age).ToList();
            var sortedByGPADesc = students.OrderByDescending(s => s.GPA).ToList();
            var sortedByNameThenByAge = students.OrderBy(s => s.Name).ThenBy(s => s.Age).ToList();

            // Додаткові методи вибірки даних
            var averageGPA = students.Average(s => s.GPA);
            var studentsOver21 = students.Where(s => s.Age > 21).ToList();

            // Метод розширення управління запитами
            bool anyFailed = students.Any(s => s.GPA < 2.0);

            // Виведення результатів
            Console.WriteLine("High Performers: " + string.Join(", ", highPerformers.Select(s => s.Name)));
            Console.WriteLine("First High Performer: " + (firstHighPerformer != null ? firstHighPerformer.Name : "None"));
            Console.WriteLine("Average GPA: " + averageGPA);
            Console.WriteLine("Students over 21: " + string.Join(", ", studentsOver21.Select(s => s.Name)));
            Console.WriteLine("Any Failed Students: " + (anyFailed ? "Yes" : "No"));
        }
    }
}
