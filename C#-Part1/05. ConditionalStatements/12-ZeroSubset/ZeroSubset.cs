using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Write a first number: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        Console.Write("Write a second number: ");
        int secondNum = Int32.Parse(Console.ReadLine());
        Console.Write("Write a third number: ");
        int thirdNum = Int32.Parse(Console.ReadLine());
        Console.Write("Write a fourt number: ");
        int fourthNum = Int32.Parse(Console.ReadLine());
        Console.Write("Write a fift number: ");
        int fiftNum = Int32.Parse(Console.ReadLine());
        bool hasSubset = false;

        if (firstNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, secondNum);
            hasSubset = true;
        }
        if (firstNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, thirdNum);
            hasSubset = true;
        }
        if (firstNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fourthNum);
            hasSubset = true;
        }
        if (firstNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, thirdNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fourthNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, thirdNum, fourthNum);
            hasSubset = true;
        }
        if (firstNum + thirdNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, thirdNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fourthNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + thirdNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, thirdNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNum, secondNum, thirdNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, thirdNum);
            hasSubset = true;
        }
        if (secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fourthNum);
            hasSubset = true;
        }
        if (secondNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fiftNum);
            hasSubset = true;
        }
        if (secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fourthNum);
            hasSubset = true;
        }
        if (secondNum + thirdNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fiftNum);
            hasSubset = true;
        }
        if (secondNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (secondNum + thirdNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNum, thirdNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fourthNum);
            hasSubset = true;
        }
        if (thirdNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fiftNum);
            hasSubset = true;
        }
        if (thirdNum + fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, fourthNum, fiftNum);
            hasSubset = true;
        }
        if (fourthNum + fiftNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNum, fiftNum);
            hasSubset = true;
        }
        if (!hasSubset)
        {
            Console.WriteLine("No zero subset.");
        }
    }
}
