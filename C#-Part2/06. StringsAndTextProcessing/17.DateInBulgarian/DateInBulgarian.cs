using System;
using System.Threading;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Please enter date and time in format day.month.year hour:minute:second: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime newDate = date.AddHours(6).AddMinutes(30);

        Console.WriteLine("After 6 hours and 30 minutes will be {0:d.MM.yyyy dddd HH:mm:ss}", newDate);
    }
}
