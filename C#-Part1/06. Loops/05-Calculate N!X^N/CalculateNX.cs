using System;

class CalculateNX
{
    static void Main()
    {
        Console.Write("Plese enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Plese enter an integer number x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int fac = 1;
        for (int i = 1; i <= n; i++)
        {
            fac *= i;
            sum += fac / Math.Pow(x, i);
        }
        Console.WriteLine("The sum is {0:0.00000}.", sum);
    }
}
