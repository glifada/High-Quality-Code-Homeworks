using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    class Person
    {
        private string name;
        private byte? age;

        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, byte age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The name cannot be null or empty!");
                }
                this.name = value;
            }
        }
        public byte? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative value!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}, Age: unspecified", this.Name);
            }
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
        }
    }
}
