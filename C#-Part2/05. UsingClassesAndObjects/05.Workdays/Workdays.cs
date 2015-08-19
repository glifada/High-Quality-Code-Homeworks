using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        Console.Write("Please enter the date (yyyy/mm/ddd) you want to check to:");
        DateTime date = DateTime.Parse(Console.ReadLine());
        CalculateWorkdays(date);
    }

    static void CalculateWorkdays(DateTime date)
    {
        DateTime today = DateTime.Today;
        DateTime[] publicHolidays = new DateTime[] 
        {
            new DateTime(today.Year,01,01),
            new DateTime(today.Year,03, 03),
            new DateTime(today.Year,04, 10),
            new DateTime(today.Year,04, 13),
            new DateTime(today.Year,05, 01),
            new DateTime(today.Year,05, 06),
            new DateTime(today.Year,09, 22),
            new DateTime(today.Year,12, 24),
            new DateTime(today.Year,12, 25)
        };
        int counter = 0;

        for (DateTime i = today; i <= date; i=i.AddDays(1))
        {
            if (i != publicHolidays[0] && i != publicHolidays[1] && i != publicHolidays[2] && 
                i != publicHolidays[3] && i != publicHolidays[4] && i != publicHolidays[5] &&
                i != publicHolidays[6] && i != publicHolidays[7] && i != publicHolidays[8])
            {
                switch (i.DayOfWeek)
                {
                    case DayOfWeek.Saturday: counter += 0;
                        break;
                    case DayOfWeek.Sunday: counter += 0;
                        break;
                    default: counter += 1;
                        break;
                }
            }
        }
        Console.WriteLine("The number of workdays between today {0} and date {1} is {2}", today.ToString("d"), date.Date.ToString("d"), counter);
    }
}
