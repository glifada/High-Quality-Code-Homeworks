using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Account : IDepositAble
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
	    {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
	    }

        public Customer Customer 
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance cannot be negative value!");
                }
                this.balance = value; 
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public void Deposit(decimal instalment)
        {
            if (instalment < 0)
            {
                throw new ArgumentOutOfRangeException("The instalment cannot be negative value!");
            }
            this.Balance += instalment;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 1)
            {
                throw new ArgumentOutOfRangeException("The period of months cannot be less than 1!");
            }
            return months * this.InterestRate;
        }
    }
}
