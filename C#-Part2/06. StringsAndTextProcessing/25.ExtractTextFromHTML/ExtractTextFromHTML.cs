using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Please enter the HTML:");
        string text = Console.ReadLine();

        string title = Regex.Match(text, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
        title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
        title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);
        if (title != string.Empty)
        {
            Console.WriteLine("Title: {0}", title.Trim());
        }

        string body = Regex.Match(text, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
        body = Regex.Replace(body, @"<.*?>", String.Empty);
        Console.WriteLine("Text: {0}", body.Trim());
    }
}
