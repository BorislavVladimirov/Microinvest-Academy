using System;

namespace _15doWhileLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            do
            {
                sum += n;
                n--;
            } while (n > 0);

            Console.WriteLine(sum);
        }
    }
}
