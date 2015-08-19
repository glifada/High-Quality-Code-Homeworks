using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class StudentsAndWorkersMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student ("Georgi", "Ivanov", 7),
                new Student ("Ivan", "Georgiev", 5),
                new Student ("Petar", "Ivanov", 6),
                new Student ("Ivan", "Ivanov", 9),
                new Student ("Ivan", "Petrov", 8),
                new Student ("Ivan", "Dimitrov", 12),
                new Student ("Dimitar", "Georgiev", 10),
                new Student ("Georgi", "Dimitrov", 6),
                new Student ("Petar", "Georgiev", 8),
                new Student ("Georgi", "Petrov", 11)
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker ("Dimitar", "Ivanov", 200, 8),
                new Worker ("Georgi", "Georgiev", 300, 5),
                new Worker ("Petar", "Dimitrov", 234, 10),
                new Worker ("Dimitar", "Dimitrov", 310, 2),
                new Worker ("Mitko", "Petrov", 290, 9),
                new Worker ("Aleksandar", "Dimitrov", 150, 6),
                new Worker ("Sasho", "Georgiev", 105, 12),
                new Worker ("Aleks", "Dimitrov", 220, 11),
                new Worker ("Mitko", "Georgiev", 180, 3),
                new Worker ("Sasho", "Petrov", 110, 4)
            };

            var studentsByGrade = students
                .OrderBy(student => student.Grade)
                .ThenBy(student => student.FirstName)
                .ThenBy(student => student.LastName);
            Console.WriteLine("Students sorted by grade:\r\n{0}", string.Join(Environment.NewLine, studentsByGrade));

            Console.WriteLine();

            var workerByMoney =
                from worker in workers
                orderby worker.MoneyPerHour() descending, worker.FirstName, worker.LastName
                select worker;
            Console.WriteLine("Workers sorted by money per hour in descending order:\r\n{0}", string.Join(Environment.NewLine, workerByMoney));

            Console.WriteLine();

            var studentAndWorkers = students
                .Concat<Human>(workers)
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);
            Console.WriteLine("Merged lists sorted by name:\r\n{0}", string.Join(Environment.NewLine, studentAndWorkers));
        }
    }
}
