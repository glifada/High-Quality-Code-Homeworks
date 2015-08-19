using System;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Please enter a word you want to translate:");
        string word = Console.ReadLine();
        string explanation = string.Empty;

        switch (word)
        {
            case ".NET": explanation = "platform for applications from Microsoft"; break;
            case "CLR": explanation = "managed execution environment for .NET"; break;
            case "namespace": explanation = "hierarchical organization of classes"; break;
            default: explanation = "There is no such a word in the dictionary!"; break;
        }
        Console.WriteLine("{0, -20} {1}", word, explanation);
    }
}
