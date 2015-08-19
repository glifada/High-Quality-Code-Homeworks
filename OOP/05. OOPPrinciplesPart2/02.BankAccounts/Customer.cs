using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Customer
    {
        private string address;

        public Customer(string address)
        {
            this.Address = address;
        }

        public string Address
        {
            get { return this.address;}
            set 
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The customer address cannot be empty");
                }
                this.address = value;
            }
        }
    }
}
