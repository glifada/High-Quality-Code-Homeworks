using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Please enter a text:");
        string text = Console.ReadLine();
        Console.Write("Please enter a word to find:");
        string word = Console.ReadLine();
        word = " " + word + " ";
        int index = -1;
        int indexStart = -1;
        int indexEnd = -1;
        string sentence = string.Empty;
        string newText = string.Empty;
        while (true)
        {
            index = text.IndexOf(word, index + 1);
            if (index == -1)
            {
                break;
            }
            indexStart = text.LastIndexOf('.', index);
            indexEnd = text.IndexOf('.', index + 1);
            sentence = text.Substring(indexStart + 1, indexEnd - indexStart);
            newText += sentence;
        }
        Console.WriteLine(newText);
    }
}