using System;

namespace CountingSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSort = { 2, 6, 6, 10, 10, 3 };
            int[] sorted = CountingSort(arrayToSort);

            Console.WriteLine(string.Join(" ", sorted));
        }

        private static int[] CountingSort(int[] array)
        {
            int[] count = new int[11];

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                count[value]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            int[] sorted = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int value = array[i];
                int position = count[value] - 1;
                sorted[position] = value;

                count[value]--;
            }

            return sorted;
        }
    }
}
