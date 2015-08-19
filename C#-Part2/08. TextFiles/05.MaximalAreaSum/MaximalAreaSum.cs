using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader ("matrix.txt"))
        {
            int length = int.Parse(reader.ReadLine());
            int[,] numbers = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                string[] lineStr = reader.ReadLine().Split(' ');
                int[] line = lineStr.Select(int.Parse).ToArray();
                for (int j = 0; j < length; j++)
                {
                    numbers[i, j] = line[j];
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    sum = numbers[i, j] + numbers[i, j + 1] + numbers[i + 1, j] + numbers[i + 1, j + 1];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                writer.WriteLine(maxSum);
            }
        }
    }
}
