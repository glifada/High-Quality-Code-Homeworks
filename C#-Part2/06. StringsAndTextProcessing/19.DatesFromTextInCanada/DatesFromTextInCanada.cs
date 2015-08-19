using System;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.WriteLine("Please enter a text:");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        string patern = @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}";

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        Console.WriteLine("Dates: ");
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], patern))
            {
                DateTime date = DateTime.ParseExact(words[i], "d.M.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}

