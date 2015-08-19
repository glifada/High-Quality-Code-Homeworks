using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The discipline name can not be null or empty!");
                }
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException ("The number of lectures must be positive value!");
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of exercises must be positive value!");
                }
                this.numberOfExercises = value;
            }
        }

        public List<string> Comment { get; set; }

        public void Add(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return string.Format(this.name);
        }
    }
}
