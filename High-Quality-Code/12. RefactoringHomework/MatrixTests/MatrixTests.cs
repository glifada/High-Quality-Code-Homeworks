using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Matrix;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void FillMatrix_SixDimensionalMatrix_ShouldFillCorrectMatrix()
        {
            // Arrange
            using (var sr = new StringReader("6"))
            {
                Console.SetIn(sr);

                // Act
                int[,] actual = RotatingWalkInMatrix.FillMatrix(6);
                int[,] expected = new int[,] {
                {1, 16, 17, 18, 19, 20},
                {15, 2, 27, 28, 29, 21},
                {14, 31, 3, 26, 30, 22},
                {13, 36, 32, 4, 25, 23},
                {12, 35, 34, 33, 5, 24},
                {11, 10, 9, 8, 7, 6}
            };

                // Assert
                CollectionAssert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FillMatrix_ThreeDimensionalMatrix_ShouldFillCorrectMatrix()
        {
            // Arrange
            using (var sr = new StringReader("3"))
            {
                Console.SetIn(sr);

                // Act
                int[,] actual = RotatingWalkInMatrix.FillMatrix(3);
                int[,] expected = new int[,] {
                {1, 7, 8},
                {6, 2, 9},
                {5, 4, 3}
            };

                // Assert
                CollectionAssert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FillMatrix_TwoDimensionalMatrix_ShouldFillCorrectMatrix()
        {
            // Arrange
            using (var sr = new StringReader("6"))
            {
                Console.SetIn(sr);

                // Act
                int[,] actual = RotatingWalkInMatrix.FillMatrix(2);
                int[,] expected = new int[,] {
                {1, 4},
                {3, 2}
            };

                // Assert
                CollectionAssert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void PrintMatrix_SixDimensionalMatrix_ShouldPrintCorrectMatrix()
        {
            // Arrange
            using (var sr = new StringReader("6"))
            {
                using (var sw = new StringWriter())
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);

                    // Act
                    RotatingWalkInMatrixMain.Main();
                    string expected = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n",
                "  1 16 17 18 19 20",
                " 15  2 27 28 29 21",
                " 14 31  3 26 30 22",
                " 13 36 32  4 25 23",
                " 12 35 34 33  5 24",
                " 11 10  9  8  7  6");

                    // Assert
                    Assert.IsTrue(sw.ToString().Contains(expected));
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "CurrentPosition should throw exception")]
        public void CurrentPosition_InValidInputX_ShouldTrowException()
        {
            CurrentPosition currentPosition = new CurrentPosition(-1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "CurrentPosition should throw exception")]
        public void CurrentPosition_InValidInputY_ShouldTrowException()
        {
            CurrentPosition currentPosition = new CurrentPosition(2, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "CurrentDirection should throw exception")]
        public void CurrentDirection_InValidInputX_ShouldTrowException()
        {
            CurrentDirection currentDirection = new CurrentDirection(-2, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "CurrentDirection should throw exception")]
        public void CurrentDirection_InValidInputY_ShouldTrowException()
        {
            CurrentDirection currentDirection = new CurrentDirection(1, 2);
        }

        [TestMethod]
        public void ChangeDirection_Direction11_ShouldReturnNextDirection()
        {
            // Arrange
            CurrentDirection direction = new CurrentDirection(1, 1);

            // Act
            Directions.ChangeDirection(direction);
            CurrentDirection expectedDirection = new CurrentDirection(1, 0);

            // Assert
            Assert.IsTrue(expectedDirection.X == direction.X && expectedDirection.Y == direction.Y);
        }
    }
}