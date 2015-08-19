using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Please enter five numbers, given in a single line, separated by a space: ");
        string[] fiveNum = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum = sum + Convert.ToDouble(fiveNum[i]);
        }
        Console.WriteLine("The sum of entered numbers is {0}.", sum);
    }
}
