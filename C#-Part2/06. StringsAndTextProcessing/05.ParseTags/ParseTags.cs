using System;

class ParseTags
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        string startStr = "<upcase>";
        string endStr = "</upcase>";
        int startIndex = -1;
        int endIndex = -1;
        string substringWithTags = string.Empty;
        string substring = string.Empty;
        string upperSubstring = string.Empty;
        
        while (true)
        {
            startIndex = text.IndexOf(startStr, startIndex + 1);
            if (startIndex == -1)
            {
                break;
            }
            endIndex = text.IndexOf(endStr, endIndex + 1);
            substringWithTags = text.Substring(startIndex, endIndex - startIndex + 9);
            substring = text.Substring(startIndex + 8, endIndex - startIndex - 8);
            upperSubstring = substring.ToUpper();
            text = text.Replace(substringWithTags, upperSubstring);
        }
        Console.WriteLine(text);
    }
}