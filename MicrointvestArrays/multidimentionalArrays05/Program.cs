using System;

namespace multidimentionalArrays05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] matrix = new int[dimension, dimension]; ;

                GenerateMatrix(matrix, dimension);

                GetRowWithOnes(matrix);
            }
        }

        private static void GetRowWithOnes(int[,] matrix)
        {
            int rowIndex = 0;
            int highestCountOfOnes = 0;

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                int currentRowCountOfOnes = 0;

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currentRowCountOfOnes++;
                    }
                }

                if (currentRowCountOfOnes > highestCountOfOnes)
                {
                    highestCountOfOnes = currentRowCountOfOnes;
                    rowIndex = row;
                }
            }

            PrintResult(rowIndex, matrix);          
        }

        private static void PrintResult(int rowIndex, int[,] matrix)
        {
            for (int row = rowIndex; row < rowIndex + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
            }
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
