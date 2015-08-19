using System;

class AgeAfter10Years
{
    static void Main()
    {
        int y;
        Console.WriteLine("Your birth year is: ");
        bool check = int.TryParse(Console.ReadLine(), out y);
        while (check == false)
        {
            Console.WriteLine("Please, enter a valid birth year: ");
            check = int.TryParse(Console.ReadLine(), out y);
        }
        Console.WriteLine("Now you are " + (2015-y) + " years old." );
        Console.WriteLine("After 10 years you will be " + (2025 - y) + " years old.");
    }
}
