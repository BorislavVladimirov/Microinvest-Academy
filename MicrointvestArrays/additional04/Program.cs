using System;
using System.Linq;

namespace additional04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                double[] array = new double[n];

                double[] input = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                array = input;

                double[] sorted = array.OrderBy(x => x).ToArray();
                double[] sortedByDescending = array.OrderByDescending(x => x).ToArray();

                Console.Write(string.Join(" ", sortedByDescending) + " ");
                Console.WriteLine(string.Join(" ", sorted));
            }
        }
    }
}
