using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareSimpleMaths
{
    class CompareSimpleMaths
    {
        static void Main(string[] args)
        {
            // Performance for int values
            TestIntPerformance();

            // Performance for long values
            TestLongPerformance();

            // Performance for float values
            TestFloatPerformance();

            // Performance for double values
            TestDoublePerformance();

            // Performance for decimal values
            TestDecimalPerformance();
        }

        static void TestIntPerformance()
        {
            Console.WriteLine("Performance for int values:");
            //Performance of add
            Stopwatch sw = Stopwatch.StartNew();
            int[] arr = new int[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j + j;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of add: {0}", sw.Elapsed);

            //Performance of substract
            sw = Stopwatch.StartNew();
            int[] arr1 = new int[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = i - j;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of substract: {0}", sw.Elapsed);

            //Performance of increment
            sw = Stopwatch.StartNew();
            int[] arr2 = new int[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j]++;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of increment: {0}", sw.Elapsed);

            //Performance of multiply
            sw = Stopwatch.StartNew();
            int[] arr3 = new int[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    arr3[j] = j * j;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of multiply: {0}", sw.Elapsed);

            //Performance of divide
            sw = Stopwatch.StartNew();
            int[] arr4 = new int[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr4.Length; j++)
                {
                    arr4[j] = j / 5;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of divide: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestLongPerformance()
        {
            Console.WriteLine("Performance for long values:");
            //Performance of add
            Stopwatch sw = Stopwatch.StartNew();
            long[] arr = new long[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j + 2147483648;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of add: {0}", sw.Elapsed);

            //Performance of substract
            sw = Stopwatch.StartNew();
            long[] arr1 = new long[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = i - 2147483648;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of substract: {0}", sw.Elapsed);

            //Performance of increment
            sw = Stopwatch.StartNew();
            long[] arr2 = new long[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j]++;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of increment: {0}", sw.Elapsed);

            //Performance of multiply
            sw = Stopwatch.StartNew();
            long[] arr3 = new long[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    arr3[j] = j * 2147483648;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of multiply: {0}", sw.Elapsed);

            //Performance of divide
            sw = Stopwatch.StartNew();
            long[] arr4 = new long[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr4.Length; j++)
                {
                    arr4[j] = 2147483648 / 5;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of divide: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestFloatPerformance()
        {
            Console.WriteLine("Performance for float values:");
            //Performance of add
            Stopwatch sw = Stopwatch.StartNew();
            float[] arr = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j + 0.1f;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of add: {0}", sw.Elapsed);

            //Performance of substract
            sw = Stopwatch.StartNew();
            float[] arr1 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = i - 0.1f;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of substract: {0}", sw.Elapsed);

            //Performance of increment
            sw = Stopwatch.StartNew();
            float[] arr2 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j]++;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of increment: {0}", sw.Elapsed);

            //Performance of multiply
            sw = Stopwatch.StartNew();
            float[] arr3 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    arr3[j] = j * 0.1f;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of multiply: {0}", sw.Elapsed);

            //Performance of divide
            sw = Stopwatch.StartNew();
            float[] arr4 = new float[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr4.Length; j++)
                {
                    arr4[j] = j / 0.1f;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of divide: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestDoublePerformance()
        {
            Console.WriteLine("Performance for double values:");
            //Performance of add
            Stopwatch sw = Stopwatch.StartNew();
            double[] arr = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j + 0.1d;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of add: {0}", sw.Elapsed);

            //Performance of substract
            sw = Stopwatch.StartNew();
            double[] arr1 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = i - 0.1d;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of substract: {0}", sw.Elapsed);

            //Performance of increment
            sw = Stopwatch.StartNew();
            double[] arr2 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j]++;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of increment: {0}", sw.Elapsed);

            //Performance of multiply
            sw = Stopwatch.StartNew();
            double[] arr3 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    arr3[j] = j * 0.1d;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of multiply: {0}", sw.Elapsed);

            //Performance of divide
            sw = Stopwatch.StartNew();
            double[] arr4 = new double[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr4.Length; j++)
                {
                    arr4[j] = j / 0.1d;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of divide: {0}", sw.Elapsed);
            Console.WriteLine();
        }

        static void TestDecimalPerformance()
        {
            Console.WriteLine("Performance for decimal values:");
            //Performance of add
            Stopwatch sw = Stopwatch.StartNew();
            decimal[] arr = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j + 0.1m;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of add: {0}", sw.Elapsed);

            //Performance of substract
            sw = Stopwatch.StartNew();
            decimal[] arr1 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr1[j] = i - 0.1m;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of substract: {0}", sw.Elapsed);

            //Performance of increment
            sw = Stopwatch.StartNew();
            decimal[] arr2 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j]++;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of increment: {0}", sw.Elapsed);

            //Performance of multiply
            sw = Stopwatch.StartNew();
            decimal[] arr3 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    arr3[j] = j * 0.1m;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of multiply: {0}", sw.Elapsed);

            //Performance of divide
            sw = Stopwatch.StartNew();
            decimal[] arr4 = new decimal[100];
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < arr4.Length; j++)
                {
                    arr4[j] = j / 0.1m;
                }
            }
            sw.Stop();
            Console.WriteLine("The performance of divide: {0}", sw.Elapsed);
            Console.WriteLine();
        }
    }
}
