using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to enter: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter {0} numbers, separated by a space: ", n);
        string[] numbers = Console.ReadLine().Split(' ');
        int odd_product = 1;
        int even_product = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                odd_product *= int.Parse(numbers[i]);
            }
            else
            {
                even_product *= int.Parse(numbers[i]);
            }
        }
        if (odd_product == even_product)
        {
            Console.WriteLine("The product of the odd elements is equal to the product of the even elements!");
            Console.WriteLine("product = {0}", odd_product);
        }
        else
        {
            Console.WriteLine("The product of the odd elements is not equal to the product of the even elements!");
            Console.WriteLine("Odd product = {0}", odd_product);
            Console.WriteLine("Even product = {0}", even_product);
        }
    }
}
