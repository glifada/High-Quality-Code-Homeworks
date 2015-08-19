using System;
using System.Collections.Generic;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Please choose which task you want to solve!");
        Console.WriteLine(@"Press 1 to reverse the digits of a number;
Press 2 to calculate the average of a sequence of integers;
Press 3 to solve a linear equation a * x + b = 0");
        int key = int.Parse(Console.ReadLine());
        while (key < 1 || key > 3)
        {
            Console.WriteLine("Please choose which task you want to solve!");
            Console.WriteLine(@"Press 1 to reverse the digits of a number;
Press 2 to calculate the average of a sequence of integers;
Press 3 to solve a linear equation a * x + b = 0");
            key = int.Parse(Console.ReadLine());
        }

        switch (key)
        {
            case 1: ReverseDigits(); break;
            case 2: CalculateAverage(); break;
            case 3: SolveEquation(); break;
        }
    }

    static void ReverseDigits()
    {
        Console.WriteLine("You chose to reverse the digits of a number!");
        Console.Write("Please enter non-negative decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        while(number < 0)
        {
            Console.Write("Please enter non-negative decimal number: ");
            number = decimal.Parse(Console.ReadLine());
        }
        string numberStr = Convert.ToString(number);
        string reversedStr = string.Empty;
        foreach (char digit in numberStr)
        {
            reversedStr = digit + reversedStr;
        }
        Console.WriteLine("The revered digits of a number {0} are: {1}", number, decimal.Parse(reversedStr));
    }

    static void CalculateAverage()
    {
        Console.WriteLine("You chose to calculate the average of a sequence of integers!");
        Console.Write("Please enter a sequence of integer numbers, separated by space: ");
        string numbersStr = Console.ReadLine();
        while (numbersStr.Length == 0)
        {
            Console.WriteLine("The sequence of numbers should not be empty!");
            Console.Write("Please enter a new sequence of integer numbers, separated by space: ");
            numbersStr = Console.ReadLine();
        }
        int[] numbers = numbersStr.Split(' ').Select(int.Parse).ToArray();
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        decimal average = (decimal)sum / (numbers.Length);
        Console.WriteLine("The average of the entered sequence of integers is: {0}", average);
    }

    static void SolveEquation()
    {
        Console.WriteLine("Please enter the coeficients of a linear equation a * x + b = 0!");
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("The coeficient a can not be 0!!! Please enter a new value!");
            Console.Write("a = ");
            a = decimal.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal x = - b / a;
        Console.WriteLine("The result is x = {0}", x);
    }
}
