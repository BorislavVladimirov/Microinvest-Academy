using System;

namespace multidimentionalArrays04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];

                GenerateMatrix(matrix, dimention);

                GetColSum(matrix);
            }
        }

        private static void GetColSum(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                
                Console.WriteLine(sum);
            }
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
