using System;

namespace _20squareOfNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    if (j == 10)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(k + " ");
                        }
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
