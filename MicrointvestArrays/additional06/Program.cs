using System;
using System.Linq;

namespace additional06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[] array = new int[n];

                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                array = input;

                Console.WriteLine(string.Join(" ", array.Where(x => x > array.Average() && x < (array.Average() * 2))));
            }
        }
    }
}
