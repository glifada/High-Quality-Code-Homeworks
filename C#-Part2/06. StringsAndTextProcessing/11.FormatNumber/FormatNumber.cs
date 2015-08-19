using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        string decimalNumber = number.ToString("D");
        Console.WriteLine("{0,-20} {1, 15}","Decimal number:", decimalNumber);
        string hexadecimalNumber = number.ToString("X");
        Console.WriteLine("{0,-20} {1, 15}", "Hexadecimal number:", hexadecimalNumber);
        string percentageNumber = number.ToString("P");
        Console.WriteLine("{0,-20} {1, 15}", "Percentage:", percentageNumber);
        string scientificNumber = number.ToString("E");
        Console.WriteLine("{0,-20} {1, 15}", "Scientific notation:", scientificNumber);
    }
}
