using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class LoverOf3
{
    static void Main()
    {
        int rows, cols, moves;
        int[] codes;

        ValidateInputData(out rows, out cols, out moves, out codes);
                
        BigInteger[,] matrix = FillMatrix(rows, cols);
        
        Console.WriteLine(CalcualateSum(matrix, moves, codes));
    }

    static void ValidateInputData(out int rows, out int cols, out int moves, out int [] codes)
    {
        try
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            moves = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            throw new ArgumentException("The rows, colums and moves must be positive numbers!");
        }
        if (rows <= 0 || cols <= 0 || moves <= 0)
        {
            throw new ArgumentException("The rows, columns and moves must be positive numbers!");
        }

        string lineCodes = Console.ReadLine();
        if (lineCodes == string.Empty)
        {
            throw new ArgumentNullException("The codes cannot be empty string!");
        }
        string[] codesAsStr = lineCodes.Split(' ');
        codes = new int[moves];
        for (int i = 0; i < codes.Length; i++)
        {
            try
            {
                codes[i] = int.Parse(codesAsStr[i]);
            }
            catch (Exception)
            {
                throw new ArgumentException("The codes must be a number!");
            }
        }
    }
    static BigInteger[,] FillMatrix(int rows, int cols)
    {
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
        return matrix;
    }

    static BigInteger CalcualateSum(BigInteger[,] matrix, int moves, int[] codes)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
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
        return sum;
    }
}
