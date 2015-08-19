using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class AnimalHierarchyMain
    {
        static void Main()
        {
            Cat[] cats = new Cat[]
            {
                new Cat (2, "Puhi", "female"),
                new Cat (1, "Chernio", "male"),
                new Cat (3, "Choki", "female")
            };

            Dog[] dogs = new Dog[]
            {
                new Dog (3, "Sharo", "male"),
                new Dog (1, "Chernio", "male"),
                new Dog (3, "Sasho", "male")
            };

            Frog[] frogs = new Frog[]
            {
                new Frog (1, "Kio", "male"),
                new Frog (1, "Kao", "female"),
                new Frog (1, "Mao", "female"),
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten (2, "Mio"),
                new Kitten (2, "Kio")
            };
            
            Tomcat[] tomcats = new Tomcat[] 
            {
                new Tomcat (3, "Tao"),
                new Tomcat (3, "Vao")
            };

            Console.WriteLine("The average age of cats is: {0}", Math.Round(Animal.CalculateAverageAge(cats), 2));
            Console.WriteLine("The average age of dogs is: {0}", Math.Round(Animal.CalculateAverageAge(dogs), 2));
            Console.WriteLine("The average age of frogs is: {0}", Math.Round(Animal.CalculateAverageAge(frogs), 2));
            Console.WriteLine("The average age of kittens is: {0}", Math.Round(Animal.CalculateAverageAge(kittens), 2));
            Console.WriteLine("The average age of tomcats is: {0}", Math.Round(Animal.CalculateAverageAge(tomcats), 2));

            Console.Write("Cats say: ");
            cats[0].Sound();
            Console.Write("Dogs say: ");
            dogs[0].Sound();
            Console.Write("Frogs say: ");
            frogs[0].Sound();
        }
    }
}
