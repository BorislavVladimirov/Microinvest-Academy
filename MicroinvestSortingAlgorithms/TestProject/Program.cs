using System;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //double result = (1.0 / 3.0) * 3;
            //decimal secondResult = (1 / 3m) * 3;

            //Console.WriteLine(result);
            //Console.WriteLine(secondResult);


            int[,] matrix = new int[3, 3];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                        int number = int.Parse(Console.ReadLine());
                    matrix[row, col] = number;
                }
            }


            //firstDiagonalSum
            int firstDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    firstDiagonalSum += matrix[row, col];
                    row++;
                }
            }

            //secondDiagonalSum 
            int secondDiagonalSum = 0;

            for (int row = matrix.GetLength(0) - 1; row > 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    secondDiagonalSum += matrix[row, col];
                    row--;
                }
            }

            Console.WriteLine(firstDiagonalSum);
            Console.WriteLine(secondDiagonalSum);
        }
    }
}
