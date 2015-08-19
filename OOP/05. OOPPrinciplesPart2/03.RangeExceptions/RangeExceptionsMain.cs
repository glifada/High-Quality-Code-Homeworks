using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class RangeExceptionsMain
    {
        static void Main()
        {
            Console.Write("Please enter integer number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 1 || 100 < number)
                {
                    throw new InvalidRangeException<int>("The entered number is out of range [1..100]!", 1, 100);
                }
            }
            catch (InvalidRangeException<int>)
            {
                Console.WriteLine("You entered wrong number! The number is out of range [1..100]!");
            }
            

            Console.Write("Please enter date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            try
            {
                if (date < startDate || endDate < date)
                {
                    throw new InvalidRangeException<DateTime>("The entered date is out of range [1.1.1980...31.12.2013]!", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime>)
            {
                Console.WriteLine("You entered wrong date! The date is out of range [1.1.1980...31.12.2013]!");
            }
        }
    }
}
