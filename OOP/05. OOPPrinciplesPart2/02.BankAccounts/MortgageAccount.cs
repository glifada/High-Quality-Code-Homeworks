using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (months <= 6)
                {
                    return 0;
                }
                months -= 6;
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return 0.5M * base.CalculateInterestAmount(months);
                }
                decimal result = 0.5M * base.CalculateInterestAmount(12);
                result += base.CalculateInterestAmount(months - 12);
                return result;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
