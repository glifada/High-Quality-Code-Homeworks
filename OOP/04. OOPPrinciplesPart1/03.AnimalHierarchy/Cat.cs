using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Myau");
        }
    }
}
