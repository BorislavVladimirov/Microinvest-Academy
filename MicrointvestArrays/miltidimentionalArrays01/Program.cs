using System;

namespace miltidimentionalArrays01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 0;

            if (int.TryParse(Console.ReadLine(), out dimension))
            {
                int[,] matrix = new int[dimension, dimension];
                int biggestNum = int.MinValue;

                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        Console.WriteLine("Enter number");

                        int number = 0;
                        int.TryParse(Console.ReadLine(), out number);

                        matrix[row, col] = number;

                        if (matrix[row, col] > biggestNum)
                        {
                            biggestNum = matrix[row, col];
                        }
                    }
                }

                Console.WriteLine(biggestNum);
            }
        }
    }
}
