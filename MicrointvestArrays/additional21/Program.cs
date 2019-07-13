using System;

namespace additional21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];

                GenerateMatrix(matrix, dimention);

                Console.WriteLine(IsMatrixSpecular(matrix));
            }
        }

        private static bool IsMatrixSpecular(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) / 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != matrix[matrix.GetLength(0) - 1 - row,col])
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
