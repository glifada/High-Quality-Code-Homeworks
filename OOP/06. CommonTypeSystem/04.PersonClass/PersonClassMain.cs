using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    class PersonClassMain
    {
        static void Main()
        {
            Person firstPerson = new Person("Stamat Ivanov");
            Person secondPerson = new Person("Pesho Georgiev", 23);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
