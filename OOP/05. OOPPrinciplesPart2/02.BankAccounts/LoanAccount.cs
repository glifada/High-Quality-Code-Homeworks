using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 1)
            {
                throw new ArgumentOutOfRangeException("The period of months cannot be less than 1!");
            }
            if (this.Customer is IndividualCustomer)
            {
                if (months <= 3)
                {
                    return 0;
                }
                months -= 3;
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months <= 2)
                {
                    return 0;
                }
                months -= 2;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
