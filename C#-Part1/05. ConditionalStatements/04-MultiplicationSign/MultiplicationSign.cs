using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Plese enter three real numbers!");
        Console.Write("Plese enter the first real number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the second real number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the third real number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        char sign;
        if ((firstNum == 0) || (secondNum == 0) || (thirdNum == 0))
        {
            sign = '0';
        }
        else if (firstNum <0)
        {
            if (secondNum < 0)
            {
                if (thirdNum < 0)
                {
                    sign = '-';
                }
                else 
                {
                    sign = '+';
                }
            }
            else if (thirdNum < 0)
                {
                    sign = '+';
                }
                else 
                {
                    sign = '-';
                }
        }
        else
        {
            if (secondNum < 0)
            {
                if (thirdNum < 0)
                {
                    sign = '+';
                }
                else 
                {
                    sign = '-';
                }
            }
            else if (thirdNum < 0)
                {
                    sign = '-';
                }
                else 
                {
                    sign = '+';
                }
        }
        Console.WriteLine("The sign of the product of the three real numbers is \"{0}\".", sign);
    }
}
