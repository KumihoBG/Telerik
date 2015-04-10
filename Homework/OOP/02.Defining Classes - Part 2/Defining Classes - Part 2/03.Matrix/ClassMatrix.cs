//-----------------------------------------------------------------------
// <copyright file="GenericClass.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _03.Matrix
    {
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A class Matrix
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T>
        where T : IComparable
        {
        private int rows;
        private int cols;
        private T[,] matrix;

        /// <summary>
        /// Initializes a new instances of the Matrix class
        /// </summary>
        /// <param name="rowCout">rows</param>
        /// <param name="colCount">cols</param>
        public Matrix(int rowCout, int colCount)
            {
            this.Rows = rowCout;
            this.Cols = colCount;
            this.matrix = new T[rowCout, colCount];
            }

        /// <summary>
        /// Gets or sets the properties of the class Matrix
        /// </summary>
        public int Rows
            {
            get
                {
                return this.rows;
                }

            private set
                {
                if (value < 1)
                    {
                    throw new ArgumentOutOfRangeException("rows count", "The matrix must have at least one row.");
                    }

                this.rows = value;
                }
            }

        public int Cols
            {
            get
                {
                return this.cols;
                }

            private set
                {
                if (value < 1)
                    {
                    throw new ArgumentOutOfRangeException("columns count", "The matrix must have at least one column.");
                    }

                this.cols = value;
                }
            }

        public T this[int row, int col]
            {
            get
                {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                    {
                    throw new IndexOutOfRangeException();
                    }

                return this.matrix[row, col];
                }

            set
                {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                    {
                    throw new IndexOutOfRangeException();
                    }

                this.matrix[row, col] = value;
                }
            }

        /// <summary>
        /// Overloading the + operator
        /// </summary>
        /// <param name="a">matrix a</param>
        /// <param name="b">matrix b</param>
        /// <returns></returns>
        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
            {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
                {
                throw new Exception("Addition cannot be applied to matrices with different dimensions.");
                }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
                {
                for (int col = 0; col < a.Cols; col++)
                    {
                    result[row, col] = (dynamic)a[row, col] + b[row, col];
                    }
                }

            return result;
            }

        /// <summary>
        /// Overloading the - operator
        /// </summary>
        /// <param name="a">matrix a</param>
        /// <param name="b">matrix b</param>
        /// <returns></returns>
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
            {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
                {
                throw new Exception("Substraction cannot be applied to matrices with different dimensions.");
                }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
                {
                for (int col = 0; col < a.Cols; col++)
                    {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                    }
                }

            return result;
            }

        /// <summary>
        /// Overloading the * operator
        /// </summary>
        /// <param name="a">matrix a</param>
        /// <param name="b">matrix b</param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
            {
            if (a.Cols != b.Rows)
                {
                throw new Exception("The matrices cannot be multiplied.");
                }

            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);
            T temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
                {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                    {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                        {
                        temp += (dynamic)a[matrixRow, index] * b[index, matrixCol];
                        }

                    result[matrixRow, matrixCol] = (dynamic)temp;
                    }
                }

            return result;
            }

        /// <summary>
        /// Overloading the true and false operators
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool operator true(Matrix<T> matrix)
            {
            return OverloadBool(matrix);
            }

        public static bool operator false(Matrix<T> matrix)
            {
            return OverloadBool(matrix);
            }

        /// <summary>
        /// To string overriding
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
                {
                for (int col = 0; col < this.Cols; col++)
                    {
                    result.Append(this.matrix[row, col] + "\t");
                    }

                result.AppendLine();
                }

            return result.ToString();
            }

        private static bool OverrideBool(Matrix<T> matrix)
            {
            for (int row = 0; row < matrix.Rows; row++)
                {
                for (int col = 0; col < matrix.Cols; col++)
                    {
                    if (matrix[row, col] != (dynamic)0)
                        {
                        return true;
                        }
                    }
                }

            return false;
            }
        }
    }
