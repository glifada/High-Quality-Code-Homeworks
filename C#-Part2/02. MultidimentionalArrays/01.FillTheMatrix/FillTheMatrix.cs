using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter the size of matrix: n = ");
        int n = int.Parse(Console.ReadLine());
        
        // matrixA
        int[,] matrixA = new int[n, n];

        Console.WriteLine();
        Console.WriteLine("a)");
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            matrixA [row, 0] = row + 1;
            for (int col = 1; col < matrixA.GetLength(1); col++)
            {
                matrixA [row, col] = matrixA [row, col - 1] + n;
            }
        }

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(0); col++)
            {
                Console.Write("{0, 4} ", matrixA [row, col]);
            }
            Console.WriteLine();
        }

        // matrixB
        int[,] matrixB = new int[n, n];

        Console.WriteLine();
        Console.WriteLine("b)");
        for (int row = 0; row < matrixB.GetLength(0); row++)
        {
            matrixB[row, 0] = row + 1;
            matrixB[row, 1] = 2 * matrixB.GetLength(0) - row;
            for (int col = 2; col < matrixB.GetLength(1); col++)
            {
                matrixB[row, col] = matrixB[row, col - 2] + 2 * n;
            }
        }

        for (int row = 0; row < matrixB.GetLength(0); row++)
        {
            for (int col = 0; col < matrixB.GetLength(0); col++)
            {
                Console.Write("{0, 4} ", matrixB[row, col]);
            }
            Console.WriteLine();
        }

        // matrixC
        int[,] matrixC = new int[n, n];
        int count = 0;

        Console.WriteLine();
        Console.WriteLine("c)");
        for (int row = 0; row < matrixC.GetLength(0); row++, count++)
        {
            int i = 0;
            matrixC[row, row] = row + (matrixC.GetLength(0) * matrixC.GetLength(1) - n) / 2 + 1;
            for (int col = row + 1; col < matrixC.GetLength(1); col++)
            {
                matrixC[row, col] = matrixC[row, col - 1] + n - i;
                i++;
            }
        }
        for (int row = 1; row < matrixC.GetLength(0); row++, count++)
        {
            int i = 0;
            for (int col = row - 1; col >= 0; col--)
            {
                matrixC[row, col] = matrixC[row, col + 1] - n + i;
                i++;
            }
        }


        for (int row = 0; row < matrixC.GetLength(0); row++)
        {
            for (int col = 0; col < matrixC.GetLength(0); col++)
            {
                Console.Write("{0, 4} ", matrixC[row, col]);
            }
            Console.WriteLine();
        }

        // matrixD
        int[,] matrixD = new int[n, n];

        Console.WriteLine();
        Console.WriteLine("d)");
        int j = 0;
        for (int col = 0; col < matrixD.GetLength(1) / 2; col++)
        {
            for (int row = 0; row < matrixD.GetLength(0); row++)
            {
                j++;
                matrixD[row, col] = j;
            }
        }

        for (int row = 0; row < matrixD.GetLength(0); row++)
        {
            for (int col = 0; col < matrixD.GetLength(0); col++)
            {
                Console.Write("{0, 4} ", matrixD[row, col]);
            }
            Console.WriteLine();
        }
    }
}