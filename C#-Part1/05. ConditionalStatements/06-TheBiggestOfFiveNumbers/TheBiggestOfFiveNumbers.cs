using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Plese enter five numbers!");
        Console.Write("Plese enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the fourth number: ");
        double fourthNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine());
        double biggest = firstNum;
        if (biggest <= secondNum)
        {
            biggest = secondNum;
        }
        if (biggest <= thirdNum)
        {
            biggest = thirdNum;
        }
        if (biggest <= fourthNum)
        {
            biggest = fourthNum;
        }
        if (biggest <= fifthNum)
        {
            biggest = fifthNum;
        }
        Console.WriteLine("The biggest number is {0}.", biggest);
    }
}
