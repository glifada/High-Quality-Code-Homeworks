using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : base (firstName, lastName)
        {
            this.disciplines = disciplines;
        }

        public List<Discipline> Disciplines 
        {
            get { return this.disciplines; }
            set 
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The set of disciplines can not be empty!");
                }
                this.Disciplines = value;
            }
        }

        public void Add(Discipline item)
        {
            this.Disciplines.Add(item);
        }

        public void Remove(Discipline item)
        {
            this.Disciplines.Remove(item);
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0} {1}, Disciplines: {2}", 
                this.FirstName, this.LastName, string.Join(", ", this.Disciplines));
        }
    }
}
