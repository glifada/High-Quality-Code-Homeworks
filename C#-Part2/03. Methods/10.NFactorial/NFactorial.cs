using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        for (int number = 1; number <= 100; number++)
        {
            Console.WriteLine("The factorial of {0} is {1}", number, CalculateFactorial(number));
        }
    }
  
    static BigInteger CalculateFactorial (int number)
    {
        BigInteger factorial = 1;
        for (int i = 2; i <= number; i++)
			{
			    factorial *= i;
			}
        return factorial;
    }
}