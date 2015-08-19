using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer number beteen 0 and 500: ");
        int intNum = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point number: ");
        float floatNumA = float.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point number: ");
        float floatNumB = float.Parse(Console.ReadLine());
        string bitInt = Convert.ToString(intNum, 2).PadLeft(10, '0');
        Console.WriteLine("{0,-10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", intNum, bitInt, floatNumA, floatNumB);
    }
}
