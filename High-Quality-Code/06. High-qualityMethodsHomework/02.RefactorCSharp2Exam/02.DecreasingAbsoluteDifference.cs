using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<string> line = new List<string>();
        List<BigInteger> lineNum = new List<BigInteger>();
        List<decimal> differences = new List<decimal>();

        List<bool> DAD = new List<bool>();

        for (int i = 0; i < number; i++)
        {
            string lineAsStr = Console.ReadLine();
            line = lineAsStr.Split(' ').ToList();
            for (int j = 0; j < line.Count; j++)
            {
                lineNum.Add(BigInteger.Parse(line[j]));
            }

            for (int j = 0; j < lineNum.Count - 1; j++)
            {
                decimal difference = Math.Abs((decimal)(lineNum[j] - lineNum[j + 1]));
                differences.Add(difference);
            }
            bool isDAD = true;
            for (int j = 0; j < differences.Count - 1; j++)
            {
                if ((differences[j] < differences[j + 1]) || (differences[j] - differences[j + 1]) > 1)
                {
                    isDAD = false;
                    break;
                }
            }
            DAD.Add(isDAD);
            lineNum.Clear();
            differences.Clear();
        }
        foreach (bool item in DAD)
        {
            Console.WriteLine(item);
        }
    }
}
