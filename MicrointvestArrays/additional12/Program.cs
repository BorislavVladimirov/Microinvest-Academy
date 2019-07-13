using System;

namespace additional12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] firstMatrix = new int[dimention, dimention];
                int[,] secondMatrix = new int[dimention, dimention];

                GenerateMatrix(firstMatrix, dimention);
                GenerateMatrix(secondMatrix, dimention);

                Console.WriteLine(GetSum(firstMatrix, secondMatrix)); 
            }
        }

        private static int GetSum(int[,] firstMatrix, int[,] secondMatrix)
        {
            int firstSum = 0;
            int secondSum = 0;

            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.GetLength(1); col++)
                {
                    firstSum += firstMatrix[row, col];
                }
            }

            for (int row = 0; row < secondMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < secondMatrix.GetLength(1); col++)
                {
                    secondSum += secondMatrix[row, col];
                }
            }

            return firstSum + secondSum;
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
