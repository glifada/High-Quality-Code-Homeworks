using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class RotatingWalkInMatrix
    {
        public static bool CheckForEmptyCellInCurrentDirection(int[,] matrix, CurrentPosition currentPosition)
        {
            Directions direction = new Directions();
            int DIRECTIONS_COUNT = 8;

            for (int i = 0; i < DIRECTIONS_COUNT; i++)
            {
                if (currentPosition.X + direction.X[i] >= matrix.GetLength(0) || currentPosition.X + direction.X[i] < 0)
                {
                    direction.X[i] = 0;
                }

                if (currentPosition.Y + direction.Y[i] >= matrix.GetLength(1) || currentPosition.Y + direction.Y[i] < 0)
                {
                    direction.Y[i] = 0;
                }
            }

            for (int i = 0; i < DIRECTIONS_COUNT; i++)
            {
                if (matrix[currentPosition.X + direction.X[i], currentPosition.Y + direction.Y[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindEmptyCell(int[,] matrix, CurrentPosition currentPosition)
        {
            currentPosition.X = 0;
            currentPosition.Y = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        currentPosition.X = i;
                        currentPosition.Y = j;
                        return;
                    }
                }
            }
        }

        public static int[,] FillMatrix(int matrixDimension)
        {
            int[,] matrix = new int[matrixDimension, matrixDimension];
            int fillingNumber = 1;
            CurrentPosition currentPosition = new CurrentPosition(0, 0);
            CurrentDirection currentDirection = new CurrentDirection(1, 1);
            while (true)
            {
                matrix[currentPosition.X, currentPosition.Y] = fillingNumber;

                if (!CheckForEmptyCellInCurrentDirection(matrix, currentPosition))
                {
                    FindEmptyCell(matrix, currentPosition);

                    // Break if no more empty cells
                    if (currentPosition.X == 0 && currentPosition.Y == 0)
                    {
                        return matrix;
                    }
                    // Will be positioned in the empty cell after the update
                    currentPosition.X--;
                    currentPosition.Y--;
                    currentDirection.X = 1;
                    currentDirection.Y = 1;
                }

                bool isInBoundariesX = 0 <= currentPosition.X + currentDirection.X && currentPosition.X + currentDirection.X < matrixDimension;
                bool isInBoundariesY = 0 <= currentPosition.Y + currentDirection.Y && currentPosition.Y + currentDirection.Y < matrixDimension;
                while (!isInBoundariesX || !isInBoundariesY || matrix[currentPosition.X + currentDirection.X, currentPosition.Y + currentDirection.Y] != 0)
                {
                    Directions.ChangeDirection(currentDirection);
                    isInBoundariesX = 0 <= currentPosition.X + currentDirection.X && currentPosition.X + currentDirection.X < matrixDimension;
                    isInBoundariesY = 0 <= currentPosition.Y + currentDirection.Y && currentPosition.Y + currentDirection.Y < matrixDimension;
                }
                currentPosition.X += currentDirection.X;
                currentPosition.Y += currentDirection.Y;
                fillingNumber++;
            }
        }

        internal static void PrintMatrix(int[,] matrix)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write("{0,3}", matrix[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
