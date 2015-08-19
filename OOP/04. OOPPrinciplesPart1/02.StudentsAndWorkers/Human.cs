using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The first name can not be null or empty!");
                }
                foreach (char symbol in value)
                {
                    if (!char.IsLetter(symbol))
                    {
                        throw new ArgumentOutOfRangeException("The first name is invalid!");
                    }
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The first name can not be null or empty!");
                }
                foreach (char symbol in value)
                {
                    if (!char.IsLetter(symbol))
                    {
                        throw new ArgumentOutOfRangeException("The first name is invalid!");
                    }
                }
                this.lastName = value;
            }
        }

    }
}
