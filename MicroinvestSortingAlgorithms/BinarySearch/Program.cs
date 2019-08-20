using System;
using System.Linq;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberToFind = 0;

            int[] array = Enumerable.Range(0, 1000000).ToArray();

            if (int.TryParse(Console.ReadLine(), out numberToFind))
            {
                if (numberToFind < array[0] || numberToFind > array[array.Length - 1])
                {
                    Console.WriteLine("The array doesn't contain the number!");
                    return;
                }

                int startingIndex = 0;
                int endingIndex = array.Length - 1;

                Console.WriteLine(FindNumberBinary(numberToFind, array, startingIndex, endingIndex));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        private static int FindNumberBinary(int numberToFind, int[] array, int startingIndex, int endingIndex)
        {
            int middleIndex = (startingIndex + endingIndex) / 2;

            if (array[middleIndex] == numberToFind)
            {
                return array[middleIndex];
            }

            if (numberToFind < array[middleIndex])
            {
                return FindNumberBinary(numberToFind, array, startingIndex, middleIndex - 1);
            }

            return FindNumberBinary(numberToFind, array, middleIndex + 1, endingIndex);
        }
    }
}
