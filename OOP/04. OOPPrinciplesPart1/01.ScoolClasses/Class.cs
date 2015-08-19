using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ScoolClasses
{
    class Class : IComment
    {
        private string classIdentifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string classIdentifier, List<Student> students, List<Teacher> teachers)
        {
            this.ClassIdentifier = classIdentifier;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string ClassIdentifier 
        {
            get { return this.classIdentifier; }
            set 
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The clas indentifier can not be null or empty!");
                }
                this.classIdentifier = value;
            }
        }
        public List<Student> Students 
        {
            get { return this.students; }
            set 
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The list of students can not be empty!");
                }
                this.students = value;
            }
        }
        public List<Teacher> Teachers 
        {
            get { return this.teachers; }
            set 
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The list of teachers can not be empty!");
                }
                this.teachers = value;
            }
        }

        public List<string> Comment { get; set; }

        void IComment.Add(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder toPrint = new StringBuilder();
            toPrint.AppendLine();
            toPrint.AppendFormat("Class {0}:", this.ClassIdentifier);
            toPrint.AppendLine();
            toPrint.AppendFormat("Teachers:\r\n{0}", string.Join(Environment.NewLine, this.Teachers));
            toPrint.AppendLine();
            toPrint.AppendFormat("Students:\r\n{0}", string.Join(Environment.NewLine, this.Students));

            return toPrint.ToString();
        }
    }
}
