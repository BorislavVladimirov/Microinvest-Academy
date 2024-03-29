﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace additional20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] matrix = new int[dimension, dimension];

                GenerateMatrix(matrix, dimension);

                GetTriangleWithSmallestSum(matrix);
            }
        }

        private static void GetTriangleWithSmallestSum(int[,] matrix)
        {
            int minSum = int.MaxValue;
            List<Point> indexesToPrint = new List<Point>();
            List<Point> tempList = new List<Point>();

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
                    indexesToPrint.Add(new Point(row, col));
                }

                startingCol--;
            }

            if (leftDownTriangleSum < minSum)
            {
                minSum = leftDownTriangleSum;
            }

            startingCol = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = startingCol; col < matrix.GetLength(1); col++)
                {
                    rightDownTriangleSum += matrix[row, col];
                    tempList.Add(new Point(row, col));
                }

                startingCol++;
            }

            if (rightDownTriangleSum < minSum)
            {
                minSum = rightDownTriangleSum;
                indexesToPrint = new List<Point>(tempList);
            }

            startingCol = matrix.GetLength(1) - 1;
            tempList = new List<Point>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = startingCol; col >= 0; col--)
                {
                    leftUpTriangleSum += matrix[row, col];
                    tempList.Add(new Point(row, col));
                }

                startingCol--;
            }

            if (leftUpTriangleSum < minSum)
            {
                minSum = leftUpTriangleSum;
                indexesToPrint = new List<Point>(tempList);
            }

            startingCol = 0;
            tempList = new List<Point>();
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = startingCol; col < matrix.GetLength(1); col++)
                {
                    rightUpTriangleSum += matrix[row, col];
                    tempList.Add(new Point(row, col));
                }

                startingCol++;
            }

            if (rightUpTriangleSum < minSum)
            {
                minSum = rightUpTriangleSum;
                indexesToPrint = new List<Point>(tempList);
            }

            PrintMatrix(matrix, indexesToPrint);
        }

        private static void PrintMatrix(int[,] matrix, List<Point> indexesToPrint)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Point currentPoint = new Point(row, col);

                    if (indexesToPrint.Contains(currentPoint))
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(0 + " ");
                    }
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
