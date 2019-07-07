using System;

namespace microinvest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i > 51 && i < 71)
                {
                    continue;
                }

                sum += 1;
            }

            Console.WriteLine(sum);
        }
    }
}
