using System;

namespace _25multiplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            int count = 1;

            do
            {
                sum *= count;

                count ++;

            } while (count <= n);

            Console.WriteLine(sum);
        }
    }
}
