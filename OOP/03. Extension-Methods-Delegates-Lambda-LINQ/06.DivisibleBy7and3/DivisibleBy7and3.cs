using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7and3
{
    class DivisibleBy7and3
    {
        public static void PrintDivisibleBy7and3(int[] numbers)
        {
            var result =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;
            Console.WriteLine("The result from expresions: {0}", string.Join(", ", result));
            Console.WriteLine();
            result = numbers
                .Where(number => number % 7 == 0 && number % 3 == 0)
                .Select(number => number);
            Console.WriteLine("The result from expresions: {0}", string.Join(", ", result));
        }

        static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            Console.WriteLine("Numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine();
            PrintDivisibleBy7and3(numbers);
        }
    }
}
