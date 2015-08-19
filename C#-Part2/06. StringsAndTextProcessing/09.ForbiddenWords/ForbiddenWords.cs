using System;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Please enter the forbidden wors, separated by space: ");
        string[] forbiddenWords = Console.ReadLine().Split(' ');
        Console.Write("Please enter the text: ");
        string text = Console.ReadLine();

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine(text);
    }
}
