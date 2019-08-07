using System;
using System.Linq;

namespace CountingSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSort = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int positiveNumbersCount = 0;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                if (arrayToSort[i] >= 0)
                {
                    positiveNumbersCount++;
                }
            }

            int[] positiveNumbers = new int[positiveNumbersCount];
            int[] negativeNumbers = new int[arrayToSort.Length - positiveNumbersCount];

            int indexOfArrayOfPositiveNumber = 0;
            int indexOfArrayOfNegative = 0;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int currentNumber = arrayToSort[i];

                if (currentNumber >= 0)
                {
                    positiveNumbers[indexOfArrayOfPositiveNumber++] = currentNumber;
                }
                else
                {
                    negativeNumbers[indexOfArrayOfNegative++] = currentNumber;
                }
            }

            int[] sortedPositiveNumbers = CountingSort(positiveNumbers);
            int[] sortedNegativeNumbers = CountingSort(negativeNumbers);

            ReverseArrayWihtNegativeNumbers(sortedNegativeNumbers);

            Console.Write("-");
            Console.Write(string.Join(" -", sortedNegativeNumbers) + " ");
            Console.Write(string.Join(" ", sortedPositiveNumbers));
        }

        private static void ReverseArrayWihtNegativeNumbers(int[] sortedNegativeNumbers)
        {
            for (int i = 0; i < sortedNegativeNumbers.Length /2; i++)
            {
                int tempElement = sortedNegativeNumbers[i];
                int indexFromBack = sortedNegativeNumbers.Length - 1 - i;

                sortedNegativeNumbers[i] = sortedNegativeNumbers[indexFromBack];
                sortedNegativeNumbers[indexFromBack] = tempElement;
            }
        }

        private static int[] CountingSort(int[] array)
        {
            int maxLength = (GetBiggestElement(array));
            int[] countArray = new int[maxLength + 1];

            for (int i = 0; i < array.Length; i++)
            {
                int value = Math.Abs(array[i]);
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
                int currentNumber = Math.Abs(array[i]);

                if (currentNumber > biggestElement)
                {
                    biggestElement = currentNumber;
                }
            }

            return biggestElement;
        }
    }
}
