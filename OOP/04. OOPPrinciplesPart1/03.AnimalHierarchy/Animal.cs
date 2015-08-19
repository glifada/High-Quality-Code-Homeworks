using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    abstract class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age 
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can not be negative value!");
                }
                this.age = value;
            }
        }
        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The name can not be null or empty!");
                }
                foreach (char symbol in value)
                {
                    if (!char.IsLetter(symbol))
                    {
                        throw new ArgumentOutOfRangeException("The name is invalid!");
                    }
                }
                this.name = value;
            }
        }
        public string Sex 
        {
            get { return this.sex; }
            set 
            {
                if (value != "female" && value != "male")
                {
                    throw new ArgumentOutOfRangeException("The sex must be female or male!");
                }
                this.sex = value;
            }
        }

        public abstract void Sound();

        public static double CalculateAverageAge(Animal[] animals)
        {
            double averageAge =
                (from animal in animals
                 select animal.Age)
                .Average();
            return averageAge;
        }
    }
}
