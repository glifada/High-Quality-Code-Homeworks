using System;

class DevideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Please enter a number for check:");
        int number = Int32.Parse(Console.ReadLine());
        bool check = (number % 7 == 0) && (number % 5 == 0);
        if (number == 0)
        {
            Console.WriteLine("The input number {0} can't be divided by 7 and 5 at the same time.", number);
        }
        else
        {
            if (check)
            {
                Console.WriteLine("The input number {0} can be divided by 7 and 5 at the same time.", number);
            }
            else
            {
                Console.WriteLine("The input number {0} can't be divided by 7 and 5 at the same time.", number);
            }
        }
    }
}
