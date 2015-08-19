using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Please enter the current time in format hh:mm tt: ");
        string strTime = Console.ReadLine();
        DateTime time;
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime stop = DateTime.Parse("3:00 AM");
        if (DateTime.TryParse(strTime, out time))
        {
            if ((time >= stop) && (time < start))
            {
                Console.WriteLine("Non beer time!");
            }
            else 
            {
                Console.WriteLine("Beer time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }
    }
}
