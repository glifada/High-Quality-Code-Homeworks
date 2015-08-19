using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to print: ");
        uint count = uint.Parse(Console.ReadLine());
        uint a = 0;
        uint b = 1;
        uint number = 0; 
        Console.WriteLine("the first {0} numbers of the Fibonacci sequense are:", count);
        if (count==1)
        {
            Console.Write("{0}", a);
        }
        else
        {
            Console.Write("{0}, {1}", a, b);
            for (int i = 2; i < count; i++)
            {
                number = a + b;
                Console.Write(", " + number);
                a = b;
                b = number;
            }
        }
        Console.WriteLine();
    }
}
