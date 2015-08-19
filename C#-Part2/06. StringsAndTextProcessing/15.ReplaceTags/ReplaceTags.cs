using System;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Please enter the text:");
        string text = Console.ReadLine();

        text = text.Replace(@"<a href=""", "[URL=").Replace(@""">", "]").Replace("</a>", "[/URL]");
        Console.WriteLine(text);
    }
}
