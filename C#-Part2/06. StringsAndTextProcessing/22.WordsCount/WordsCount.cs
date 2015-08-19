using System;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string str = Console.ReadLine();
        str = str.ToLower();
        List<string> words = str.Split(' ').ToList();

        for (int i = 0; i < words.Count; i++)
        {
            words[i] = words[i].TrimEnd('.');
            int counter = 1;
            for (int j = i + 1; j < words.Count; j++)
            {
                if (words[i] == words[j])
                {
                    counter++;
                    words.RemoveAt(j);
                }
            }
            Console.WriteLine("Word \"{0}\" is found {1} times.", words[i], counter);
        }
    }
}
