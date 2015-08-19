using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class DepositAccount : Account, IDrawAble
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            
        }

        public void Draw(decimal drawAmount)
        {
            if (drawAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The draw money cannot be negative value!");
            }
            if (drawAmount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("The draw money cannot be more than the balance!");
            }
            this.Balance -= drawAmount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (0 < this.Balance && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
