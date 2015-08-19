using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class DecreasingAbsoluteDifference
{
    static void Main()
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            throw new ArgumentException("The number of lines must be a positive number!");
        }

        if(number <= 0){
            throw new ArgumentException("The number of lines must be a positive number!");
        }

        List<bool> DAD = new List<bool>();

        for (int i = 0; i < number; i++)
        {
            string lineAsStr = Console.ReadLine();
            List<decimal> differences = CalculateAbsoluteDifferences(lineAsStr);
            bool isDAD = CheckAbsoluteDifferencesIncreasing(differences);
            DAD.Add(isDAD);
        }
        foreach (bool item in DAD)
        {
            Console.WriteLine(item);
        }
    }

    static List<decimal> CalculateAbsoluteDifferences(string lineAsStr)
    {
        List<string> line = new List<string>();
        List<BigInteger> lineNum = new List<BigInteger>();

        line = lineAsStr.Split(' ').ToList();
        for (int j = 0; j < line.Count; j++)
        {
            try
            {
                lineNum.Add(BigInteger.Parse(line[j]));
            }
            catch (Exception)
            {
                throw new ArgumentException("The elements of entered sequence must be number!");
            }
        }

        List<decimal> differences = new List<decimal>();
        for (int j = 0; j < lineNum.Count - 1; j++)
        {
            decimal difference = Math.Abs((decimal)(lineNum[j] - lineNum[j + 1]));
            differences.Add(difference);
        }
        return differences;
    }

    static bool CheckAbsoluteDifferencesIncreasing(List<decimal> differences)
    {
        bool isDAD = true;
        for (int j = 0; j < differences.Count - 1; j++)
        {
            if ((differences[j] < differences[j + 1]) || (differences[j] - differences[j + 1]) > 1)
            {
                isDAD = false;
                break;
            }
        }
        return isDAD;
    }
}
