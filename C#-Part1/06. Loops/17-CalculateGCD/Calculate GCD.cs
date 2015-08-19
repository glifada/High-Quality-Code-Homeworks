using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Please enter two integers a and b.");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int result = 0;
        int tempA = Math.Abs(a);
        int tempB = Math.Abs(b);

        while (tempA != 0 && tempB != 0)
        {
            if (tempA > tempB)
            {
                tempA %= tempB;
                result = tempA;
            }
            else
            {
                tempB %= tempA;
                result = tempA;
            }
        }

        if (tempA == 0)
        {
            result = tempB;
        }
        else
        {
            result = tempA;

        }

        Console.WriteLine("The greatest common divisor ({0}, {1}): {2}", a, b, result);
    }
}
