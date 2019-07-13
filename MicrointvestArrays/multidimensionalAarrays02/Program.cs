using System;

namespace multidimensionalAarrays02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];

                GenerateMatrix(matrix, dimention);

                Console.WriteLine(GetSum(matrix));
            }
        }

        private static int GetSum(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
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
