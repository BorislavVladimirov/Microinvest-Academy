using System;
using System.Linq;

namespace MicroinvestStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            double[,,] matrix = new double[3, 3, 3];

            PrintArray(matrix);
        }

        private static void PrintArray(double[,,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int depth = 0; depth < matrix.GetLength(2); depth++)
                    {
                        Console.WriteLine(matrix[row,col,depth] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
