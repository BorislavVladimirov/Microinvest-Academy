using System;
using System.Linq;

namespace CountingSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSort = { 2, 6, 6, 10, 10, 3 ,0, -2};
            int[] sorted = CountingSort(arrayToSort);

            Console.WriteLine(string.Join(" ", sorted));
        }

        private static int[] CountingSort(int[] array)
        {
            int maxLength = GetBiggestElement(array);

            int[] countArray = new int[maxLength + 1];

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                countArray[value]++;
            }

            int[] sorted = new int[array.Length];
            int indexOfSortedArray = 0;

            for (int i = 0; i < countArray.Length; i++)
            {
                if (countArray[i] != 0)
                {
                    for (int j = 0; j < countArray[i]; j++)
                    {
                        sorted[indexOfSortedArray] = i;
                        indexOfSortedArray++;
                    }
                }
            }

            return sorted;
        }

        private static int GetBiggestElement(int[] array)
        {
            int biggestElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestElement)
                {
                    biggestElement = array[i];
                }
            }

            return biggestElement;
        }
    }
}
