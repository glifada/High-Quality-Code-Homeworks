using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of words, separated by space:");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');

        Array.Sort(words);

        Console.WriteLine("The list of words in alphabetical order is:");

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
