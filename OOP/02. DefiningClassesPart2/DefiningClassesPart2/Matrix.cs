using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Matrix<T>
    {
        private T[,] matrixElements;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.MatrixElements = new T[this.Rows, this.Cols];
        }

        public T[,] MatrixElements { get; set; }
        public int Rows
        {
            get { return this.rows; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("The number of rows must be more than 0!");
                }
                this.rows = value;
            }
        }
        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("The number of columns must be more than 0!");
                }
                this.cols = value;
            }
        }

        // Matrix indexer
        public T this[int row, int col]
        {
            get
            {
                return this.MatrixElements[row, col];
            }
            set
            {
                if (row < 0 || this.Rows <= row || col < 0 || this.Cols <= col)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range!");
                }
                this.MatrixElements[row, col] = value;
            }
        }

        // Matrix operation +
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows && matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("The matrices is not of the same size");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }
            return resultMatrix;
        }

        // Matrix operation -
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows && matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("The matrices is not of the same size");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }
            return resultMatrix;
        }

        // Matrix operation *
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols)
            {
                throw new ArgumentException("The matrices cannot be multiplied! Number of rows of the first matrix  is not equal to number of columns of the second matrix !");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        resultMatrix[i, j] += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return resultMatrix;
        }

        // Check for non-zero elements
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    result.Append(string.Format("{0, 5}", this[i, j]));
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }
    }
}
