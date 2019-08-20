using System;
using System.Linq;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };

            int lowIndex = 0;
            int highIndex = array.Length - 1;

            QuickSortArray(array, lowIndex, highIndex);

            Console.WriteLine(string.Join(", ", array));
        }

        private static void QuickSortArray(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex)
            {
                return;
            }

            int index = Partition(array, lowIndex, highIndex);

            QuickSortArray(array, lowIndex, index - 1);
            QuickSortArray(array, index + 1, highIndex);
        }

        private static int Partition(int[] array, int lowIndex, int highIndex)
        {
            int pivot = array[highIndex];

            int storedIndex = lowIndex - 1;

            for (int i = lowIndex; i < highIndex; i++)
            {
                if (array[i] <= pivot)
                {
                    storedIndex++;

                    Swap(array, storedIndex, i);
                }
            }

            Swap(array, storedIndex + 1, highIndex);

            return storedIndex + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int tempElement = array[j];

            array[j] = array[i];
            array[i] = tempElement;
        }
    }
}
