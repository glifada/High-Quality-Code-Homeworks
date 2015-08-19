using System;
using System.Globalization;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        double distance = (secondDate - firstDate).TotalDays;
        Console.WriteLine("Distance: {0}", distance);
    }
}
