using System;

namespace _14numsFrom10To200
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 10 && n <= 200)
            {
                for (int i = n ; i >= 0; i--)
                {
                    if (i % 7 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
