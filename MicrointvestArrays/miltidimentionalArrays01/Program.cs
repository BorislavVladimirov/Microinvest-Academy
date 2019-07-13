using System;

namespace miltidimentionalArrays01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int dimention))
            {
                int[,] matrix = new int[dimention, dimention];
                int biggestNum = int.MinValue;

                for (int i = 0; i < dimention; i++)
                {
                    for (int j = 0; j < dimention; j++)
                    {
                        Console.WriteLine("Enter number");
                        int.TryParse(Console.ReadLine(), out int number);

                        matrix[i, j] = number;

                        if (matrix[i, j] > biggestNum)
                        {
                            biggestNum = matrix[i, j];
                        }
                    }
                }

                Console.WriteLine(biggestNum);
            }
        }
    }
}
