using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class SchoolMain
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Ivanov", 3);
            Student student2 = new Student("Andrey", "Andreev", 1);
            Student student3 = new Student("Georgi", "Georgiev", 2);
            Student student4 = new Student("Peter", "Petrov", 1);
            Student student5 = new Student("Yavor", "Ivanov", 2);

            Teacher teacher1 = new Teacher("Ginka", "Ivanova", new List<Discipline>() { new Discipline("Mathematics", 10, 10) });
            Teacher teacher2 = new Teacher("Mitko", "Ivanov", new List<Discipline>() { new Discipline("Literature", 8, 10) });

            Class class12A = new Class ("12A", new List<Student>() {student1, student2, student3}, new List<Teacher>() {teacher1});
            Class class12B = new Class ("12B", new List<Student>() {student4, student5}, new List<Teacher>() {teacher2});

            School mySchool = new School(new List<Class>() {class12A, class12B});

            Console.WriteLine(mySchool.ToString());
        }
    }
}
