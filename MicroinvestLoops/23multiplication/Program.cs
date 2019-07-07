using System;

namespace _23multiplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            while (i < 10)
            {
                for (i = 1; i < 10; i++)
                {
                    for (int j = i; j <= 9; j++)
                    {
                        Console.Write($"{i}*{j};");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
