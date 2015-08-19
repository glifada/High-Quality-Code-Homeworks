using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter the year you want to check: ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
