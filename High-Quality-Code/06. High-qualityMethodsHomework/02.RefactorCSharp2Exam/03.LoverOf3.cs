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
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int moves = int.Parse(Console.ReadLine());
        string lineCodes = Console.ReadLine();
        string[] codesAsStr = lineCodes.Split(' ');
        int[] codes = new int[codesAsStr.Length];
        for (int i = 0; i < codesAsStr.Length; i++)
        {
            codes[i] = int.Parse(codesAsStr[i]);
        }

        BigInteger[,] matrix = new BigInteger[rows, cols];

        // fill matrix
        for (int i = rows - 1; i >= 0; i--)
        {
            matrix[i, 0] = (BigInteger)Math.Pow(2, rows - 1 - i);
            for (int j = 0; j < cols; j++)
            {
                matrix[rows - 1, j] = (BigInteger)Math.Pow(2, j);
            }
        }
        for (int i = rows - 2; i >= 0; i--)
        {
            for (int j = 1; j < cols; j++)
            {
                matrix[i, j] = matrix[i, j - 1] + matrix[i + 1, j];
            }
        }

        int devider = Math.Max(rows, cols);
        BigInteger sum = 0;

        int currentRow = rows - 1;
        int currentCol = 0;
        for (int i = 0; i < codes.Length; i++)
        {
            int row = codes[i] / devider;
            int col = codes[i] % devider;

            if (currentRow > row)
            {
                for (int r = currentRow; r >= row; r--)
                {
                    sum += matrix[r, currentCol];
                    matrix[r, currentCol] = 0;
                }
                currentRow = row;
            }
            else
            {
                for (int r = currentRow; r <= row; r++)
                {
                    sum += matrix[r, currentCol];
                    matrix[r, currentCol] = 0;
                }
                currentRow = row;
            }
            if (currentCol > col)
            {
                for (int c = currentCol; c >= col; c--)
                {
                    sum += matrix[currentRow, c];
                    matrix[currentRow, c] = 0;
                }
                currentCol = col;
            }
            else
            {
                for (int c = currentCol; c <= col; c++)
                {
                    sum += matrix[currentRow, c];
                    matrix[currentRow, c] = 0;
                }
                currentCol = col;
            }
        }
        Console.WriteLine(sum);
    }
}
