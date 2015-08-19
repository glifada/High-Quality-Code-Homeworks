using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class IndividualCustomer : Customer
    {
        private string firstName;
        private string lastName;

        public IndividualCustomer(string firstName, string lastName, string address)
            : base (address)
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
                    throw new ArgumentNullException("The customer first name cannot be empty");
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
                    throw new ArgumentNullException("The customer last name cannot be empty");
                }
                this.lastName = value;
            }
        }
    }
}
