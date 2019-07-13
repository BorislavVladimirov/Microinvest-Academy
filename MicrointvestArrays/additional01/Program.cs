using System;
using System.Linq;

namespace additional01
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

                int[] sorted = array.OrderBy(x => x).ToArray();

                Console.WriteLine(string.Join(" ", sorted));
            }
        }
    }
}
