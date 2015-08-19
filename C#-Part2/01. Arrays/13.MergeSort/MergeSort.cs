using System;

class MergeSort
{
    void mergeArray(int[] arr, int start, int mid, int end)
    {
        /* Create a temporary array for string merged array (Length of temp array will be 
            * sum of size of both array to be merged)*/
        int[] temp = new int[end - start + 1];
 
        int i = start, j = mid+1, k=0;
        // Now traverse both array simultaniously and store the smallest element of both to temp array
        while (i <= mid && j <= end)
        {
            if (arr[i] < arr[j])
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            else
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
        }
        // If there is any element remain in first array then add it to temp array
        while(i<=mid)
        {
            temp[k] = arr[i];
            k++;
            i++;
        }
        // If any element remain in second array then add it to temp array
        while (j <= end)
        {
            temp[k] = arr[j];
            k++;
            j++;
        }
        // Now temp has merged sorted element of both array
 
        // Traverse temp array and store element of temp array to original array
        k=0;
        i=start;
        while (k < temp.Length && i <= end)
        {
            arr[i] = temp[k];
            i++;
            k++;
        }
    }
    // Recursive Merge Procedure
    void mergesort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (end + start) / 2;
            mergesort(arr, start, mid);
            mergesort(arr, mid + 1, end);
            mergeArray(arr, start, mid, end);
        }
    }
 
    // Main driver function
    static void Main(string[] args)
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
 
        MergeSort merge = new MergeSort();
             
        // Calling Merge Procedure
        merge.mergesort(arr, 0, arr.Length-1);
 
        // Printing Sorted array. after merge sort
        Console.Write("The sorted array is: ");
        foreach (int a in arr)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
    }
}
