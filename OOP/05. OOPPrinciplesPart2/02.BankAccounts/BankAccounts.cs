using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class BankAccounts
    {
        static void Main()
        {
            CompanyCustomer aries = new CompanyCustomer("Aries", "Sofia");
            List<Account> ariesAccounts = new List<Account>()
            {
                new DepositAccount(aries, 15000, 0.3M),
                new LoanAccount (aries, 12000, 0.01M),
                new MortgageAccount (aries, 10000, 0.02M)
            };

            ariesAccounts[0].Deposit(1000);
            Console.WriteLine("Ballance of the Aries' deposit account: {0}", ariesAccounts[0].Balance);
            Console.WriteLine("Ballance of the Aries' accounts:\r\nDeposit: {0}\r\nLoan: {1}\r\nMortgage: {0}", ariesAccounts[0].Balance, ariesAccounts[1].Balance, ariesAccounts[2].Balance);

            Console.WriteLine();

            IndividualCustomer gosho = new IndividualCustomer("Georgi", "Georgiev", "Varna");
            DepositAccount goshoDeposit = new DepositAccount(gosho, 2000, 0.03M);

            goshoDeposit.Draw(500);
            Console.WriteLine("Ballance of Georgi Georgiev's deposit account: {0}", goshoDeposit.Balance);
            Console.WriteLine("The interest of Georgi Georgiev's deposit account for the first 3 months: {0}", goshoDeposit.CalculateInterestAmount(3));
        }
    }
}
