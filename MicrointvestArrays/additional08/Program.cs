using System;

namespace additional08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];

                GenerateMatrix(matrix, dimention);

                Console.WriteLine(GetRightDiagonalSum(matrix));
            }
        }

        private static int GetRightDiagonalSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    sum += matrix[row, col];
                    row++;
                }
            }

            return sum;
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
