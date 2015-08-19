using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set 
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentNullException("The first name can not be null or empty!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentNullException("The last name can not be null or empty!");
                }
                this.lastName = value;
            }
        }
        public int Age 
        {
            get { return this.age; }
            set 
            {
                if (value < 6 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException("The age is out of range!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName);
        }

        public static void FirstBeforeLastName(Student[] students)
        {
            var result =
                from student in students
                where (student.FirstName[0]).CompareTo(student.LastName[0]) < 0
                select student;
            Console.WriteLine("First name before last name: {0}", string.Join(", ", result).ToString());
        }

        public static void AgeRange(Student[] students)
        {
            var result =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            Console.WriteLine("Age between 18 and 24: {0}", string.Join(", ", result).ToString());
        }

        public static void OrderStudents(Student[] students)
        {
            var result = students
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
            Console.WriteLine("Sort descending with extension metods: {0}", string.Join(", ", result).ToString());

            Console.WriteLine();

          result =
                from student in students
                orderby student.FirstName descending,
                student.LastName descending
                select student;
            Console.WriteLine("Sort descending with LINQ: {0}", string.Join(", ", result).ToString());
        }
    }
}
