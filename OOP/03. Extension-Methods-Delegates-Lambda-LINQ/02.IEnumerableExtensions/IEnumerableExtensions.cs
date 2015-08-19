using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> numbers)
        {
            T sum = (dynamic)0;
            foreach (T number in numbers)
            {
                sum += (dynamic)number;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
            T product = (dynamic)1;
            foreach (T number in numbers)
            {
                product *= (dynamic)number;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            List<T> listNumbers = numbers.ToList();
            T min = listNumbers[0];
            for (int i = 1; i < listNumbers.Count; i++)
            {
                if (listNumbers[i].CompareTo(min) < 0)
                {
                    min = listNumbers[i];
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            List<T> listNumbers = numbers.ToList();
            T max = listNumbers[0];
            for (int i = 1; i < listNumbers.Count; i++)
            {
                if (listNumbers[i].CompareTo(max) > 0)
                {
                    max = listNumbers[i];
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> numbers)
        {
            List<T> listNumbers = numbers.ToList();
            decimal average = Convert.ToDecimal(numbers.Sum<T>()) / listNumbers.Count;
            return average;
        }

        static void Main()
        {
            double[] numbers = new double[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum: {0}", numbers.Sum());
            Console.WriteLine("Product: {0}", numbers.Product());
            Console.WriteLine("Min: {0}", numbers.Min());
            Console.WriteLine("Max: {0}", numbers.Max());
            Console.WriteLine("Average: {0}", numbers.Average());
        }
    }
}
