using System;
using System.Collections.Generic;
using System.Drawing;

namespace additional20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 3;

            int[,] matrix = new int[dimension, dimension];

            GenerateMatrix(matrix, dimension);

            GetTriangleWithSmallestSum(matrix);
        }

        private static void GetTriangleWithSmallestSum(int[,] matrix)
        {
            int leftDownTriangleSum = 0;
            int rightDownTriangleSum = 0;
            int leftUpTriangleSum = 0;
            int rightUpTriangleSum = 0;

            int startingCol = matrix.GetLength(1) - 1;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = startingCol; col >= 0; col--)
                {
                    leftDownTriangleSum += matrix[row, col];
                }

                startingCol--;
            }

            startingCol = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = startingCol; col < matrix.GetLength(1); col++)
                {
                    rightDownTriangleSum += matrix[row, col];
                }

                startingCol++;
            }

            startingCol = matrix.GetLength(1) - 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = startingCol; col >= 0; col--)
                {
                    leftUpTriangleSum += matrix[row, col];
                }

                startingCol--;
            }

            startingCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = startingCol; col < matrix.GetLength(1); col++)
                {
                    rightUpTriangleSum += matrix[row, col];
                }

                startingCol++;
            }
            
            ModifyMatrix(matrix, leftDownTriangleSum, rightDownTriangleSum, leftUpTriangleSum, rightUpTriangleSum);
        }

        private static void ModifyMatrix(int[,] matrix, 
            int leftDownTriangleSum, 
            int rightDownTriangleSum,
            int leftUpTriangleSum, 
            int rightUpTriangleSum)
        {
            if (leftDownTriangleSum < rightUpTriangleSum
                && leftDownTriangleSum < leftUpTriangleSum
                && leftDownTriangleSum < rightUpTriangleSum)
            {
                matrix[0, 1] = 0;
                matrix[0, 2] = 0;
                matrix[1, 2] = 0;
            }
            else if (rightDownTriangleSum < leftDownTriangleSum
                && rightDownTriangleSum < leftUpTriangleSum
                && rightDownTriangleSum < rightUpTriangleSum)
            {
                matrix[0, 0] = 0;
                matrix[0, 1] = 0;
                matrix[1, 0] = 0;
            }
            else if (leftUpTriangleSum < leftDownTriangleSum
                && leftUpTriangleSum < rightDownTriangleSum
                && leftUpTriangleSum < rightUpTriangleSum)
            {
                matrix[1, 2] = 0;
                matrix[2, 1] = 0;
                matrix[2, 2] = 0;
            }
            else
            {
                matrix[1, 0] = 0;
                matrix[2, 0] = 0;
                matrix[2, 1] = 0;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
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
