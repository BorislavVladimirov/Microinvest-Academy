using System;
using System.Linq;

namespace _03smallestBiggestAndAverageValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = 0;

            if (int.TryParse(Console.ReadLine(), out arrayLength))
            {
                int[] numbers = new int[arrayLength];

                numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int smallestNumber = int.MaxValue;
                int biggestNumber = int.MinValue;
                double sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < smallestNumber)
                    {
                        smallestNumber = numbers[i];
                    }
                    if (numbers[i] > biggestNumber)
                    {
                        biggestNumber = numbers[i];
                    }

                    sum += numbers[i];
                }

                Console.WriteLine($"{smallestNumber}, {biggestNumber}, {sum / numbers.Length}");
            }
        }
    }
}
