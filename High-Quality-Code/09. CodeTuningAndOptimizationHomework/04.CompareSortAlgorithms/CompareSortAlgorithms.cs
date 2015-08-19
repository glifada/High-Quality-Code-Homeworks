using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    class CompareSortAlgorithms
    {
        static void Main(string[] args)
        {
            // Performance for int values
            int[] arr = new int[] { 6, 78, 32, 25, 90, 567, 5, 89, 95, 4 };
            Console.WriteLine("Performance for int values:");
            TestInsertionSortPerformance(arr);
            TestSelectionSortPerformance(arr);
            TestQuickSortPerformance(arr);
            Console.WriteLine();

            // Performance for random values
            Random rnd = new Random();
            int[] arr3 = new int[10];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = rnd.Next(100);
            }
            Console.WriteLine("Performance for random int values:");
            TestInsertionSortPerformance(arr3);
            TestSelectionSortPerformance(arr3);
            TestQuickSortPerformance(arr3);
            Console.WriteLine();

            // Performance for sorted values
            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Performance for sorted int values:");
            TestInsertionSortPerformance(arr4);
            TestSelectionSortPerformance(arr4);
            TestQuickSortPerformance(arr4);
            Console.WriteLine();

            // Performance for values sorted in reversed order
            int[] arr5 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Performance for sorted in reversed order int values:");
            TestInsertionSortPerformance(arr5);
            TestSelectionSortPerformance(arr5);
            TestQuickSortPerformance(arr5);
            Console.WriteLine();

            // Performance for double values
            double[] arr1 = new double[] { 6.8, 78.4, 32.1, 25.4, 90.9, 567.7, 5.1, 89.8, 95.4, 4.3 };
            Console.WriteLine("Performance for double values:");
            TestInsertionSortPerformance(arr1);
            TestSelectionSortPerformance(arr1);
            TestQuickSortPerformance(arr1);
            Console.WriteLine();

            // Performance for string values
            string[] arr2 = new string[] { "sort", "swap", "algorithm", "number", "add", "string", "array", "double", "quick", "select" };
            Console.WriteLine("Performance for string values:");
            TestInsertionSortPerformance(arr2);
            TestSelectionSortPerformance(arr2);
            TestQuickSortPerformance(arr2);
            Console.WriteLine();
        }

        static void TestInsertionSortPerformance<T>(T[] arr) where T : IComparable<T>
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                InsertionSort(arr);
            }
            sw.Stop();
            Console.WriteLine("The performance of Insertion Sort Algorithm: {0}", sw.Elapsed);
        }

        static void TestSelectionSortPerformance<T>(T[] arr) where T : IComparable<T>
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                SelectionSort(arr);
            }
            sw.Stop();
            Console.WriteLine("The performance of Selection Sort Algorithm: {0}", sw.Elapsed);
        }

        static void TestQuickSortPerformance<T>(T[] arr) where T : IComparable<T>
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                QuickSort(arr, 0, arr.Length - 1);
            }
            sw.Stop();
            Console.WriteLine("The performance of Quick Sort Algorithm: {0}", sw.Elapsed);
        }

        private static void InsertionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is not initialized!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int j = index + 1;

                while (j > 0)
                {
                    if (arr[j - 1].CompareTo(arr[j]) < 0)
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                    }
                    j--;
                }
            }
        }

        private static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is not initialized!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is not initialized!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "Invalid start index!");
            Debug.Assert(0 <= endIndex && endIndex <= arr.Length - 1, "Invalid end index!");
            Debug.Assert(startIndex <= endIndex, "Start index must be smaller than end index!");
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static void QuickSort<T>(T[] arr, int left, int right) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is not initialized!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        private static int Partition<T>(T[] arr, int left, int right) where T : IComparable<T>
        {
            T pivot = arr[left];
            while (true)
            {
                while (arr[left].CompareTo(pivot) < 0)
                    left++;

                while (arr[right].CompareTo(pivot) > 0)
                    right--;

                if (left < right)
                {
                    Swap(ref arr[left], ref arr[right]);
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
