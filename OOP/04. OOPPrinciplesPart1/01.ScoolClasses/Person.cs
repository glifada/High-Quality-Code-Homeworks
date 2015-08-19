using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class Person : IComment
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.lastName = lastName;
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

        public List<string> Comment { get; set; }

        public void Add(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
