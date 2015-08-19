using System;

class Program
{
    static void Main()
    {
        int nunbersCount = int.Parse(Console.ReadLine());
        string stringNumber = "";

        for (int i = 0; i < nunbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string stringNewNumber = Convert.ToString(number, 2).PadLeft(30, '0');
            stringNumber += stringNewNumber;
        }

        int counterZeros = 0;
        int counterOnes = 0;
        int numberZeros = 0;
        int numberOnes = 0;
        foreach (char symbol in stringNumber)
        {
            if (symbol == '1')
            {
                counterZeros = 0;
                counterOnes++;
            }
            else
            {
                counterOnes = 0;
                counterZeros++;
            }
            if (numberZeros < counterZeros)
            {
                numberZeros = counterZeros;
            }
            if (numberOnes < counterOnes)
            {
                numberOnes = counterOnes;
            }
        }
                
        Console.WriteLine(numberZeros);            
        Console.WriteLine(numberOnes);
    }
}
