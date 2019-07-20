using System;

namespace multidimentionalArrays03
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

                GetRowSum(matrix);
            }
        }

        private static void GetRowSum(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row,col];
                }

                Console.WriteLine(sum);
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

