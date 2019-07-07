using System;

namespace _03OddNumsFrom_10To10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = -10; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
