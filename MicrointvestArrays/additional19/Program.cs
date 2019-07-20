using System;

namespace additional19
{
    public class Program
    {
        private const double index = 0.5;

        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] matrix = new int[dimension, dimension];

                GenerateMatrix(matrix, dimension);

                Console.WriteLine(IsMatrixSparse(matrix));
            }
        }

        private static bool IsMatrixSparse(int[,] matrix)
        {
            double totalElementsCount = matrix.GetLength(0) * matrix.GetLength(1);
            double zerosCounter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 0)
                    {
                        zerosCounter++;
                    }
                }
            }

            if (zerosCounter / totalElementsCount > index)
            {
                return true;
            }

            return false;
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
