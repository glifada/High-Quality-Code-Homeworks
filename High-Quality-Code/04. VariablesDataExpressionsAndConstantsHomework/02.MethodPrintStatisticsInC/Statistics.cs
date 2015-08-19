//Refactor the following code to apply variable usage and naming best practices:

using System;

namespace _02.MethodPrintStatisticsInC
{
    class Statistics
    {
        public void PrintStatistics(double[] numbers)
        {
            PrintMax(numbers);
                        
            PrintMin(numbers);

            PrintAvg(numbers);
        }

        private void PrintMax(double[] numbers)
        {
            double max = numbers [0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("The maximal element is: {0}", max);
        }

        private void PrintMin(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("The minimal element is: {0}", min);
        }

        private void PrintAvg(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Length;
            Console.WriteLine("The average is: {0}", average);
        }
    }
}
