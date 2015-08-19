using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        int numTransformation = 1;

        while (true)
        {
            if (result < 10)
            {
                Console.WriteLine(numTransformation);
                break;
            }
            else if (numTransformation < 10)
            {
                number = result;
                result = 1;
                while (number > 9)
                {
                    int sum = 0;
                    number /= 10;
                    string stringNum = Convert.ToString(number);
                    for (int i = 0; i < stringNum.Length; i += 2)
                    {
                        sum += stringNum[i] - '0';
                    }
                    result *= sum;
                }
                numTransformation++;
            }
            else break;
        }

        Console.WriteLine(result);
    }
}