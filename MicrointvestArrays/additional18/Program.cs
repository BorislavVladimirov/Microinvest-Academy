using System;

namespace additional18
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
