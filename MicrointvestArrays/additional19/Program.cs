using System;

namespace additional19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];

                GenerateMatrix(matrix, dimention);

                GetRowWithOnes(matrix);
            }
        }

        private static void GetRowWithOnes(int[,] matrix)
        {
            int rowIndex = 0;
            int highestCountOfOnes = 0;

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                int currentRowcountOfOnes = 0;

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currentRowcountOfOnes++;
                    }
                }

                if (currentRowcountOfOnes > highestCountOfOnes)
                {
                    highestCountOfOnes = currentRowcountOfOnes;
                    rowIndex = row;
                }
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
