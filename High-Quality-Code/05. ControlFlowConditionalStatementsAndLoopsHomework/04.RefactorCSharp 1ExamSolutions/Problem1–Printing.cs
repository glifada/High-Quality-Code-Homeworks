using System;

class Printing
{
    static void Main()
    {
        int numberStudents = int.Parse(Console.ReadLine());
        int numberPaperSheets = int.Parse(Console.ReadLine());
        decimal realmPrice = decimal.Parse(Console.ReadLine());
        int SHEETS_IN_REALM = 500;

        decimal totalAmount = 0;
        totalAmount = ((numberStudents * numberPaperSheets) / SHEETS_IN_REALM) * realmPrice;        
        Console.WriteLine("{0:F2}", totalAmount);
    }
}