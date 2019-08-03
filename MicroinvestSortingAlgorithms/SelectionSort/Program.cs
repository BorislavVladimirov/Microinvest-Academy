using System;
using System.Linq;

namespace SelectionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int smallestNumber = int.MaxValue;
                int index = -1;
                int tempNumber = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < smallestNumber)
                    {
                        smallestNumber = numbers[j];
                        index = j;
                    }
                }

                tempNumber = numbers[i];
                numbers[i] = smallestNumber;
                numbers[index] = tempNumber;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
