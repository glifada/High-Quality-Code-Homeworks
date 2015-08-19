using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class CompanyCustomer : Customer
    {
        private string name;

        public CompanyCustomer(string name, string address)
            : base (address)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentNullException("The company name cannot be empty");
                }
                this.name = value;
            }
        }
    }
}
