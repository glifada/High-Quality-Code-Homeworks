﻿using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today is {0}", date.DayOfWeek);
    }
}
