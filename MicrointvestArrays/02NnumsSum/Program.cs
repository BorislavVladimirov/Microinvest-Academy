using System;
using System.Linq;

namespace _02NnumsSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
