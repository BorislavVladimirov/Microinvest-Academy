using System;

namespace _08Loops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = n;
            int col = n;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(col - 1);
                }

                Console.WriteLine();

                col += 2;
            }
        }
    }
}
