using System;

class Sort3NumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Plese enter three numbers!");
            Console.Write("Plese enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Plese enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Plese enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("The numbers sorted in descending order are: {0} {1} {2}.", firstNum, secondNum, thirdNum);
                }
                else if (firstNum > thirdNum)
                {
                    Console.WriteLine("The numbers sorted in descending order are: {0} {2} {1}.", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("The numbers sorted in descending order are: {2} {0} {1}.", firstNum, secondNum, thirdNum);
                }
            }
            else if (secondNum < thirdNum)
            {
                Console.WriteLine("The numbers sorted in descending order are: {2} {1} {0}.", firstNum, secondNum, thirdNum);
            }
            else if (firstNum < thirdNum)
            {
                Console.WriteLine("The numbers sorted in descending order are: {1} {2} {0}.", firstNum, secondNum, thirdNum);
            }
            else
            {
                Console.WriteLine("The numbers sorted in descending order are: {1} {0} {2}.", firstNum, secondNum, thirdNum);
            }
        }
    }
}
