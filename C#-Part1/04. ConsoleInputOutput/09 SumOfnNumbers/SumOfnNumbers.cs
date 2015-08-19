using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you will enter for sum: ");
        uint count = uint.Parse(Console.ReadLine());
        double number = 0;
        double sum = 0;
        for (int i=1; i<=count; i++)
        {
            Console.Write("Please enter {0} number: ", i);
            number = double.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of entered {0} numbers is: {1}", count, sum);
    }
}
