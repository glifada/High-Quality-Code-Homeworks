using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentClass
{
    class StudentClassMain
    {
        static void Main()
        {
            Student firstStudent = new Student("Pesho", "Peshev", "Peshev", 123456789, "Sofia", "0888736728",
                "pesho@abv.bg", 2, Specialties.Law, Universities.SU, Faculties.SF);
            Student secondStudent = new Student("Ivan", "Ivanov", "Ivanov", 124564789, "Varna", "0888678728",
                "ivan@abv.bg", 2, Specialties.Law, Universities.SU, Faculties.SF);
            Student thirdStudent = (Student)firstStudent.Clone();

            Console.WriteLine("Compare {0} and {1}: {2}", firstStudent.ToString(), secondStudent.ToString(), firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Compare {0} and {1}: {2}", firstStudent.ToString(), thirdStudent.ToString(), firstStudent.CompareTo(thirdStudent));

            thirdStudent.Ssn = 123456790;
            Console.WriteLine("Compare {0} and {1} with different SSN: {2}", firstStudent.ToString(), thirdStudent.ToString(), firstStudent.CompareTo(thirdStudent));
        }
    }
}
