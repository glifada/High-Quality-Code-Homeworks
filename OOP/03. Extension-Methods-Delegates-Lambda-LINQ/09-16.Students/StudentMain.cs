using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19.Students
{
    class StudentMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "123406654", "028875348", "ivan.ivanov@abv.bg", new List<int>(){3, 4}, 5),
                new Student("Peter", "Ivanov", "123457456", "08853323", "peter.ivanov@mail.bg", new List<int>(){5, 4}, 3),
                new Student("Ivan", "Petrov", "123458564", "08857688", "ivan.petrov@abv.bg", new List<int>(){2, 2}, 2),
                new Student("Georgi", "Ivanov", "123459564", "+359267564", "georgi.ivanov@abv.bg", new List<int>(){2, 4}, 5),
                new Student("Ivan", "Georgiev", "123406654", "0884645675", "ivan.georgiev@mail.bg", new List<int>(){3, 4}, 2),
                new Student("Georgi", "Petrov", "123461653", "026454634", "georgi.petrov@abv.bg", new List<int>(){5, 6}, 5),
                new Student("Peter", "Georgiev", "123462754", "088464575", "peter.georgiev@mail.bg", new List<int>(){6, 4}, 2),
                new Student("Georgi", "Georgiev", "123406876", "+359264576857", "georgi.georgiev@abv.bg", new List<int>(){3, 5}, 3)
            };

            // Problem 9. Student groups
            // Order the students in group 2 by first name using LINQ
            var studentsInGroup2 = 
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            Console.WriteLine("(LINQ) The students in group 2 are:\r\n{0}", string.Join(Environment.NewLine, studentsInGroup2).ToString());

            Console.WriteLine();

            // Problem 10. Student groups extensions
            // Order the students in group 2 by first name using extension methods
            studentsInGroup2 = students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);
            Console.WriteLine("(Extension) The students in group 2 are:\r\n{0}", string.Join(Environment.NewLine, studentsInGroup2).ToString());

            Console.WriteLine();

            // Problem 11. Extract students by email
            var studentsEmailAbv = 
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            Console.WriteLine("The students with email in abv.bg are:\r\n{0}", string.Join(Environment.NewLine, studentsEmailAbv).ToString());

            Console.WriteLine();

            // Problem 12. Extract students by phone
            var studentsPhoneSofia =
                from student in students
                where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
                select student;
            Console.WriteLine("The students with phone in Sofia are:\r\n{0}", string.Join(Environment.NewLine, studentsPhoneSofia).ToString());

            Console.WriteLine();

            // Problem 13. Extract students by marks
            var studentstMark6 =
                from student in students
                where student.Marks.Any(mark => mark == 6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };
            Console.WriteLine("The students with at least one excellent mark are:");
            foreach (var student in studentstMark6)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine();

            //Problem 14. Extract students with two marks
            var studentsMark2 = students
                .Where(student => student.Marks.FindAll(mark => mark == 2).Count == 2)
                .Select(student => 
                    new
                    {
                        FullName = student.FirstName + " " + student.LastName,
                        Marks = student.Marks
                    });
            Console.WriteLine("The students with two marks \"2\" are:");
            foreach (var student in studentsMark2)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine();

            //Problem 15. Extract marks
            var students2006Marks = 
                from student in students
                where student.FakNum[4] == '0' && student.FakNum[5] == '6'
                select student.Marks;
            Console.WriteLine("The marks of the students that enrolled in 2006 are:");
            foreach (var mark in students2006Marks)
            {
                Console.WriteLine(string.Join(", ", mark));
            }

            Console.WriteLine();

            //Problem 16.* Groups
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Ecomonics"),
                new Group(3, "Mathematics"),
                new Group(4, "Biology"),
                new Group(5, "Sport"),
            };
            var StudentsMathematicsDepartment =
                from groupN in groups
                where groupN.DepartmentName == "Mathematics"
                join student in students on groupN.GroupNumber equals student.GroupNumber
                select student;
            Console.WriteLine("The students from Mathematics department are:\r\n{0}", string.Join(Environment.NewLine, StudentsMathematicsDepartment));

            Console.WriteLine();

            // Problem 18. Grouped by GroupNumber
            var studentsGroupedByGroupNumber =
                from student in students
                group student by student.GroupNumber into Newgroup
                orderby Newgroup.Key
                select Newgroup;
            Console.WriteLine("Students grouped by GroupNumber using LINQ:");
            foreach (var group in studentsGroupedByGroupNumber)
            {
                Console.WriteLine("Group {0}:", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }

            Console.WriteLine();

            // Problem 19. Grouped by GroupName extensions
            var studentsGroupedByGroupNumberExt = students
                .GroupBy(student => student.GroupNumber)
                .OrderBy(group => group.Key);
            Console.WriteLine("Students grouped by GroupNumber using extensions:");
            foreach (var group in studentsGroupedByGroupNumberExt)
            {
                Console.WriteLine("Group {0}:", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }
        }
    }
}
