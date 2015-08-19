using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Plese enter three numbers!");
            Console.Write("Plese enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Plese enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Plese enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            double biggest = firstNum;
            if (biggest <= secondNum)
            {
                biggest = secondNum;
            }
            if (biggest <= thirdNum)
            {
                biggest = thirdNum;
            }
            Console.WriteLine("The biggest number is {0}.", biggest);
        }
    }
