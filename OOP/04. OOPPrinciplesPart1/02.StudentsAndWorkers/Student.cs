using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade 
        {
            get { return this.grade; }
            set 
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("The grade has to be beetween 1 and 12!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + ", grade " + this.Grade);
        }
    }
}
