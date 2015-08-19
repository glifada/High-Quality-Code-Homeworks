using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.Classes = new List<Class>();
            this.Classes = classes;
        }

        public List<Class> Classes 
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }

        public void Add (Class item)
        {
            this.Classes.Add(item);
        }

        public void Remove (Class item)
        {
            this.Classes.Remove(item);
        }

        public override string ToString()
        {
            return string.Format("Classes: {0}", string.Join(Environment.NewLine, this.Classes));
        }
    }
}
