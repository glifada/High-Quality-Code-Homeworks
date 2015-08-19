using System;

class GetLargerNumber
{
    static void Main()
    {
        int largestNum = int.MinValue;
        Console.WriteLine("Please enter 3 integer numbers: ");
        Console.Write("number1 = ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("number2 = ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("number3 = ");
        int number3 = int.Parse(Console.ReadLine());
        largestNum = GetMax(number1, number2);
        largestNum = GetMax(largestNum, number3);
        Console.WriteLine("The largest number is: {0}", largestNum);
    }

    static int GetMax (int number1, int number2)
    {
        int largerNum = number1;
        if (largerNum < number2)
        {
            largerNum = number2;
        }
        return largerNum;
    }
}
