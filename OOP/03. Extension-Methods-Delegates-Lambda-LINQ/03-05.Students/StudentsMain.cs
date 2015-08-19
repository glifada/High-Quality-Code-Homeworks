using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
    class StudentsMain
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Ivan", "Ivanov", 20),
                new Student("Peter", "Ivanov", 21),
                new Student("Ivan", "Petrov", 17),
                new Student("Georgi", "Ivanov", 19),
                new Student("Ivan", "Georgiev", 28),
                new Student("Georgi", "Petrov", 18),
                new Student("Peter", "Georgiev", 25),
                new Student("Georgi", "Georgiev", 23)
            };
            Student.FirstBeforeLastName(students);
            Console.WriteLine();
            Student.AgeRange(students);
            Console.WriteLine();
            Student.OrderStudents(students);
        }
    }
}
