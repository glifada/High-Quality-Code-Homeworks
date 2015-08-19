using System;

class EnterNumbers
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(1, 100);
        }
    }

    static void ReadNumber (int start, int end)
    {
        Console.Write("Please, enter an integer number in a range [{0}...{1}]:", start, end);
        
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (start < number && number < end)
            {
                Console.WriteLine("The entered number {0} is correct!", number);
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException are)
        {
            Console.WriteLine(are.Message);
        }
    }
}
