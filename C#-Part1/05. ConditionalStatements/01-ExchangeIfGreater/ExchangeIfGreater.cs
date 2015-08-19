using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double firstNum = Double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double secondNum = Double.Parse(Console.ReadLine());
        double bufferNum;
        if (firstNum == secondNum)
        {
            Console.WriteLine("Tne entered numbers {0} and {1} are equal", firstNum, secondNum);
        }
        else
        {
            if (firstNum > secondNum)
            {
                bufferNum = firstNum;
                firstNum = secondNum;
                secondNum = bufferNum;
            }
            Console.WriteLine("Tne entered numbers are: {0} {1}", firstNum, secondNum);
        }
    }
}
