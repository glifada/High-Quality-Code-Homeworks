using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] arr = new char[26];
        for (int i = 0; i < 26; i++)
        {
            arr[i] = Convert.ToChar(i + 65);
        }

        Console.Write("Please write a word with capital letters: ");
        string word = Console.ReadLine();
        foreach (char symbol in word)
        {
            int index = Array.BinarySearch(arr, symbol);
            Console.WriteLine("The symbol {0} has index {1} in the array.", symbol, index);
        }
    }
}