using System;

namespace additional21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] matrix = new int[dimension, dimension];

                GenerateMatrix(matrix, dimension);

                Console.WriteLine(IsMatrixSpecular(matrix));
            }
        }

        private static bool IsMatrixSpecular(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) / 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != matrix[matrix.GetLength(0) - 1 - row,matrix.GetLength(1) - 1 - col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void GenerateMatrix(int[,] matrix, int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.WriteLine("Enter number");

                    int number = 0;

                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        matrix[i, j] = number;
                    }
                }
            }
        }
    }
}
