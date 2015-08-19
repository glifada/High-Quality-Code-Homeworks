using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Please enter the text:");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        string patern = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

        Console.WriteLine("E-mail addresses: ");
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], patern))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}