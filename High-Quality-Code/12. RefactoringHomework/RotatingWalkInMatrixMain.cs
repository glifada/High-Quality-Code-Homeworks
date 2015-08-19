using System;

namespace Matrix
{
    public class RotatingWalkInMatrixMain
    {
        public static void Main()
        {
            Console.WriteLine( "Enter a positive integer number " );
            string input = Console.ReadLine();
            int matrixDimension = 0;
            while (!int.TryParse(input, out matrixDimension) || matrixDimension < 1 || matrixDimension > 100)
            {
                Console.WriteLine( "You haven't entered a correct positive integer number" );
                input = Console.ReadLine();
            }
            int[,] matrix = RotatingWalkInMatrix.FillMatrix(matrixDimension);
            RotatingWalkInMatrix.PrintMatrix(matrix);
        }
    }
}
