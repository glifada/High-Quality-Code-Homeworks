using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the number of rows in the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns in the matrix: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        //Read matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Please enter the {0} row of the matrix with {1} strings, separated by spaces: ", row, cols);
            string line = Console.ReadLine();
            string[] cells = line.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = cells[col];
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

        int maxCounter = 0;
        string element = string.Empty;
        string maxElement = string.Empty;
        int counter = 1;

        //Counter for rows
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            counter = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                    element = matrix[row, col];
                }
            }
            if (maxCounter < counter)
            {
                maxCounter = counter;
                maxElement = element;
            }
        }

        //Counter for cols
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            counter = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                    element = matrix[row, col];
                }
            }
            if (maxCounter < counter)
            {
                maxCounter = counter;
                maxElement = element;
            }
        }

        //Counter for left diagonal
        counter = 1;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (row == col && matrix[row, col] == matrix[row + 1, col + 1])
                {
                    counter++;
                    element = matrix[row, col];
                }
            }
            if (maxCounter < counter)
            {
                maxCounter = counter;
                maxElement = element;
            }
        }

        //Counter for right diagonal
        counter = 1;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (row == col && matrix[row, col] == matrix[row + 1, col - 1])
                {
                    counter++;
                    element = matrix[row, col];
                }
            }
            if (maxCounter < counter)
            {
                maxCounter = counter;
                maxElement = element;
            }
        }

        //Print result
        Console.WriteLine("The longest sequence of equal strings in matrix is:");
        for (int i = 0; i < maxCounter; i++)
        {
            if (i < maxCounter - 1)
            {
                Console.Write("{0}, ", maxElement);
            }
            else
            {
                Console.Write("{0}", maxElement);
            }
        }
        Console.WriteLine();
    }
}
