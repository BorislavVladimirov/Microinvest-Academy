using System;

namespace additional18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] firstMatrix = new int[dimension, dimension];
                int[,] secondMatrix = new int[dimension, dimension];

                GenerateMatrix(firstMatrix, dimension);
                GenerateMatrix(secondMatrix, dimension);

                Console.WriteLine(Compare(firstMatrix, secondMatrix));
            }
        }

        private static bool Compare(int[,] firstMatrix, int[,] secondMatrix)
        {
            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.GetLength(1); col++)
                {
                    if (firstMatrix[row,col] != secondMatrix[row,col])
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
