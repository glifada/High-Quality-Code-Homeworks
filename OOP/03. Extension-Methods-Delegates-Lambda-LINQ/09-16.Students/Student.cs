using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _09_19.Students
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string fakNum;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, string fakNum, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FakNum = fakNum;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name can not be null or empty!");
                }
                foreach (var symbol in value)
	            {
		            if (!char.IsLetter(symbol))
	                {
		                throw new ArgumentException("The first name has to contain letters only!");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name can not be null or empty!");
                }
                foreach (var symbol in value)
	            {
		            if (!char.IsLetter(symbol))
	                {
		                throw new ArgumentException("The last name has to contain letters only!");
	                }
	            }
                this.lastName = value;
            }
        }
        public string FakNum 
        {
            get { return this.fakNum; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The faculty number can not be null or empty!");
                }
                foreach (var symbol in value)
	            {
		            if (!char.IsDigit(symbol))
	                {
                        throw new ArgumentException("The faculty number has to contain digits only!");
	                }
	            }
                this.fakNum = value;
            }
        }
        public string Tel{
            get { return this.tel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The telefone number can not be null or empty!");
                }
                if (value[0] != '0' && value[0] != '+')
                {
                    throw new ArgumentException("The telefone number has to start with 0 or +!");
                }
                for (int i = 1; i < value.Length; i++)
	            {
		            if (!char.IsDigit(value[i]))
	                {
		                throw new ArgumentException("The telefone number has to contain digits only!");
	                }
	            }
                this.tel = value;
            }
        }
        public string Email{
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The email address can not be null or empty!");
                }
                if (!Regex.IsMatch(value, 
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + 
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", 
                      RegexOptions.IgnoreCase))
	            {
		            throw new ArgumentException("The email address is not in valid format!");
	            }
                this.email = value;
            }
        }
        public List<int> Marks 
        {
            get { return this.marks; }
            set
            {
                foreach (var mark in value)
	            {
		            if (mark < 2 || 6 < mark)
	                {
		                throw new ArgumentOutOfRangeException("The entered mark is not valid!");
	                }
	            }
                this.marks = value;
            }
        }
        public int GroupNumber {
            get { return this.groupNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The group number is not valid!");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName);
            //return string.Format("\r\nName: {0} {1}\r\nFaculty number: {2}\r\nTel: {3}\r\nEmail: {4}\r\nMarks: {5}\r\nGroup number: {6}",
            //    this.FirstName, this.LastName, this.FakNum, this.Tel, this.Email, string.Join(", ", this.Marks), this.GroupNumber);
        }
    }
}
