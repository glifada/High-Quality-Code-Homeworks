using System;

class RandomNumbers
{
    static void Main()
    {
        int min = 100;
        int max = 200;
        Random randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNumber.Next(100, 200));
        }
    }
}
