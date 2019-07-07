using System;

namespace _11triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowLenght = 1;
            int emptySpacesCount = n;

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= emptySpacesCount - 1; k++)
                {
                    Console.Write(" ");
                }

                emptySpacesCount--;

                for (int j = 1; j <= rowLenght; j++)
                { 
                    Console.Write("*");
                }

                rowLenght += 2;

                Console.WriteLine();
            }
        }
    }
}
