using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareAdvancedMaths
{
    class CompareAdvancedMaths
    {
        static void Main(string[] args)
        {
            // Performance for float values
            TestFloatPerformance();

            // Performance for double values
            TestDoublePerformance();

            // Performance for decimal values
            TestDecimalPerformance();
        }

        static void TestFloatPerformance()
        {
            Console.WriteLine("Performance for float values:");
            //Performance of square root
            Stopwatch sw = Stopwatch.StartNew();
            float[] arr = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = (float)Math.Sqrt(0.1f);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of square root: {0}", sw.Elapsed);

            //Performance of natural logarithm
            sw = Stopwatch.StartNew();
            float[] arr1 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = (float)Math.Sin(0.1f);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of natural logarithm: {0}", sw.Elapsed);

            //Performance of sinus
            sw = Stopwatch.StartNew();
            float[] arr2 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = (float)Math.Log(0.1f);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of sinus: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestDoublePerformance()
        {
            Console.WriteLine("Performance for double values:");
            //Performance of square root
            Stopwatch sw = Stopwatch.StartNew();
            double[] arr = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = (double)Math.Sqrt(0.1d);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of square root: {0}", sw.Elapsed);

            //Performance of natural logarithm
            sw = Stopwatch.StartNew();
            double[] arr1 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = (double)Math.Sin(0.1d);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of natural logarithm: {0}", sw.Elapsed);

            //Performance of sinus
            sw = Stopwatch.StartNew();
            double[] arr2 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = (double)Math.Log(0.1d);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of sinus: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestDecimalPerformance()
        {
            Console.WriteLine("Performance for decimal values:");
            //Performance of square root
            Stopwatch sw = Stopwatch.StartNew();
            decimal[] arr = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = (decimal)Math.Sqrt(0.1);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of square root: {0}", sw.Elapsed);

            //Performance of natural logarithm
            sw = Stopwatch.StartNew();
            decimal[] arr1 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = (decimal)Math.Sin(0.1);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of natural logarithm: {0}", sw.Elapsed);

            //Performance of sinus
            sw = Stopwatch.StartNew();
            decimal[] arr2 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = (decimal)Math.Log(0.1);
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of sinus: {0}", sw.Elapsed);
            Console.WriteLine();
        }
    }
}
