using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Please enter the start number: ");
        int startNum = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the end number: ");
        int endNum = Int32.Parse(Console.ReadLine());
        uint count = 0;
        while ((startNum < 0) || (endNum < 0))
        {
            Console.WriteLine("Please enter the start number: ");
            startNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the end number: ");
            endNum = Int32.Parse(Console.ReadLine());
        }
        for (int i=startNum; i<=endNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
                count = count + 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Between {0} and {1} there are {2} numbers that can be devided by 5.", startNum, endNum, count);
    }
}
