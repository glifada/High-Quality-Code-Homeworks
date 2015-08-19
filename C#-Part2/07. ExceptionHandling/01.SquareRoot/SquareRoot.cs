using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please, enter an integer number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square number of {0} is {1}", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
