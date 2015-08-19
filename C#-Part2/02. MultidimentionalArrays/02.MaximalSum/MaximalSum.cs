using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the number of rows in the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns in the matrix: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        int maxSum = int.MinValue;
        int maxRow = -1;
        int maxCol = -1;

        while(rows < 3 || cols < 3)
        {
            Console.WriteLine("Please enter bigger matrix!");
            Console.Write("Please enter the number of rows in the matrix: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of columns in the matrix: ");
            cols = int.Parse(Console.ReadLine());
            matrix = new int[rows, cols];
        }
        
        //Read matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Please enter the {0} row of the matrix with {1} numbers, separated by spaces: ", row, cols);
            string line = Console.ReadLine();
            string[] cells = line.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(cells[col]);
            }
        }

        //Pritn matrix
        Console.WriteLine("The entered matrix is:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Find maxSum
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        //Print maxSum and square
        Console.WriteLine("The maximal sum is: {0}", maxSum);
        Console.WriteLine("The square 3x3 is:");
        for (int row = maxRow; row < 3; row++)
        {
            for (int col = maxCol; col < 3; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
