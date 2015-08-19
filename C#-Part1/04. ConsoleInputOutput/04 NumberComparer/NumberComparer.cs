using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double result = (firstNum > secondNum) ? firstNum : secondNum;
        Console.WriteLine("The greater number is: {0}", result);
    }
}

