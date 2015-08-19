using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentClass
{
    public enum Universities { SU, TU, UNSS};
    public enum Faculties { EMF, TF, SF}
    public enum Specialties { Economics, Engineering, Art, Mathematics, Law}

    class Student : ICloneable, IComparable<Student>
    {
        private string name;

        public Student(string firstName, string middleName, string lastName, int ssn, string address, 
            string phone, string email, int course, Specialties specialty, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name 
        {
            get { return this.name; }
            private set { this.name = string.Format("{0} {1} {2}, {3}", this.FirstName, this.MiddleName, this.LastName); }
        }
        public int Ssn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.Ssn != student.Ssn)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} {2}, {3}", this.FirstName, this.MiddleName, this.LastName, this.Ssn);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Ssn.GetHashCode();
        }

        public static bool operator ==(Student a, Student b)
        {
            if ((a == null) || (b == null))
            {
                return false;
            }

            return a.Ssn == b.Ssn;
        }

        public static bool operator !=(Student a, Student b)
        {
            if ((a == null) || (b == null))
            {
                return false;
            }

            return a.Ssn != b.Ssn;
        }

        public object Clone()
        {
            var newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address,
                this.Phone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
            return newStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            return this.Ssn.CompareTo(other.Ssn);
        }
    }
}
