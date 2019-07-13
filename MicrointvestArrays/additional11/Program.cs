using System;

namespace additional11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];

            GenerateMatrix(matrix, 2);

            //only for 2x2 matrix
            Console.WriteLine(GetDeterminant(matrix));
        }

        private static int GetDeterminant(int[,] matrix)
        {
            int leftDiagonaleSum = 1;
            int rightDiagonaleSum = 1;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    rightDiagonaleSum *= matrix[row, col];
                    row--;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    leftDiagonaleSum *= matrix[row, col];
                    row++;                        
                }
            }

            return leftDiagonaleSum - rightDiagonaleSum;
        }

        private static void GenerateMatrix(int[,] matrix, int dimention)
        {
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    Console.WriteLine("Enter number");

                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        matrix[i, j] = number;
                    }
                }
            }
        }
    }
}
