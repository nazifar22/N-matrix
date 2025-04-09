using System;

namespace oop_nazifa
{
    public class Matrix
    {

        public class negativeException : Exception { };
        public class differentException : Exception { };
        public class notnumberException : Exception { };
        public class invalidIndexException : Exception { };
        public class emptyArrayException : Exception { };

        public List<List<int>> matrix;

        public Matrix(int size)
        {
            if (size < 0) { throw new negativeException(); }
            if (size % 1 != 0)
            {
                throw new ArgumentException("Size must be an integer.");
            }
            matrix = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < size; j++)
                {
                    matrix[i].Add(0);
                }
            }
        }

        public Matrix(int size, int[] first, int[] second, int[] third)
        {
            int size2 = 0;
            if (size < 0) { throw new negativeException(); }
            else if ((first.Length) == 0 || (second.Length) == 0 || (third.Length) == 0) { throw new emptyArrayException(); }
            else if (!(size == first.Length) || !(size == second.Length) || !(size == third.Length)) { throw new differentException(); }
            matrix = new List<List<int>>();

            for (int i = 0; i < size; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < size; j++)
                {
                    if ((j == 0) || (j == size - 1) || (i == j && j != 0))
                    {
                        if (j == 0 && i != j)
                        {
                            matrix[i].Add(second[i]);
                        }
                        else if (j == size - 1 && i != j)
                        {
                            matrix[i].Add(third[i]);
                        }
                        else if (i == j)
                        {
                            matrix[i].Add(first[i]);
                        }
                    }
                    else
                    {
                        matrix[i].Add(0);
                    }
                }
            }
        }

        public int GetValue(int rowIndex, int colIndex)
        {
            if (rowIndex>matrix.Count || colIndex > matrix[0].Count) { throw new invalidIndexException(); }
            else if (rowIndex<0 || colIndex<0) { throw new negativeException(); };
            return matrix[rowIndex - 1][colIndex - 1];
        }

        public Matrix Add(Matrix other)
        {
            if (matrix.Count != other.matrix.Count || matrix[0].Count != other.matrix[0].Count)
            {
                throw new ArgumentException("Matrices must have the same rows and coloumns.");
            }

            Matrix result = new Matrix(matrix.Count);

            for (int i = 0; i < matrix.Count; i++)
            {
                //List<int> row = new List<int>();
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    result.matrix[i][j] = matrix[i][j] + other.matrix[i][j];
                }
            }

            return result;
        }


        public Matrix Multiply(Matrix other)
        {
            if (matrix[0].Count != other.matrix.Count)
            {
                throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix");
            }

            Matrix result = new Matrix(matrix.Count);

            for (int i = 0; i < matrix.Count; i++)
            {
                //for (int j = 0; j < other.matrix[0].Count; j++)
                for(int j = 0; j < matrix.Count; j++)
                {
                    int sum = 0;
                    //for (int k = 0; k < matrix[i].Count; k++)
                    for(int k = 0; k < matrix.Count; k++)
                    {
                        sum += matrix[i][k] * other.matrix[k][j];
                    }
                    result.matrix[i][j] = sum;
                }
            }

            return result;
        }

        public void PrintMatrix()
        {
            for(int i = 0; i < matrix.Count; i++)
            {
                for(int j = 0; j < matrix.Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        #region helper
        public void setNum(int row, int col, int num)
        {
            matrix[row][col] = num;
        }
        #endregion 
    }
}