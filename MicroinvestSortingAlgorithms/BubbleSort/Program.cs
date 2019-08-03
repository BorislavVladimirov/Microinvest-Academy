using System;
using System.Linq;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" ", SortArray(arrayOfNumbers)));
        }

        private static int[] SortArray(int[] array)
        {
            bool IsElementSwapped = true;

            while (IsElementSwapped)
            {
                IsElementSwapped = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        array[i] = array[i] + array[i + 1];
                        array[i + 1] = array[i] - array[i + 1];
                        array[i] = array[i] - array[i + 1];

                        IsElementSwapped = true;
                    }
                }
            }

            return array;
        }
    }
}
