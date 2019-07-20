using System;
using System.Linq;

namespace additional05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = 0;

            if (int.TryParse(Console.ReadLine(), out arrayLength))
            {
                int[] array = new int[arrayLength];

                array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                //Console.WriteLine(string.Join(" ", array.Where(x => x % 15 == 0)));

                foreach (var number in array)
                {
                    if (number % 15 == 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
