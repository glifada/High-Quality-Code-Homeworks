using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class Student : Person
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber 
        {
            get { return this.classNumber; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The class number must be possitive value!");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1}, Class number: {2}",
                this.FirstName, this.LastName, string.Join(", ", this.ClassNumber));
        }
    }
}
