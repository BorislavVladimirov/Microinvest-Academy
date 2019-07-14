using System;
using System.Collections.Generic;
using System.Linq;

namespace additional22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 4, 7, 9 };
            IEnumerable<int> result = Enumerable.Range(0, 10).Except(list);
            Console.WriteLine(string.Join(" ", result));

            //generating array with numbers from 0 to 1 000 000
            int[] array = Enumerable.Range(0, 1000000).ToArray();

            //generatiog random number to remove from the array
            Random random = new Random();
            int indexToRemove = random.Next(0, 1000001);

            //removing random number from the array
            List<int> tempList = array.ToList();
            tempList.RemoveAt(indexToRemove);
            array = tempList.ToArray();

            //shuffle the array
            ShuffleArray(array);

            //ordering the array by ascending
            int[] sorted = array.OrderBy(x => x).ToArray();

            //finding the missing number
            Console.WriteLine(sorted.FirstOrDefault(x => sorted[x] + 1 != sorted[x + 1]) + 1);

            //Time Complexity O(n)
            //it will cause integer overflow with big integers

            //int sum = 0;
            //int total = sorted.Length * (sorted.Length + 1) / 2;
            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    sum += sorted[i];
            //}
            //Console.WriteLine(total - sum);

            //for (int i = 0; i <= sorted.Length / 2; i++)
            //{
            //    if (sorted[i + 1] != i + 1)
            //    {
            //        Console.WriteLine(i + 1);
            //        break;
            //    }
            //    if (sorted[sorted.Length - 1 - i] != sorted[sorted.Length - 1 - i - 1] + 1)
            //    {
            //        Console.WriteLine(array[array.Length - 1 - i] - 1);
            //        break;
            //    }
            //}
        }

        private static void ShuffleArray(int[] array)
        {
            for (int i = 0; i < 30; i++)
            {
                Random index = new Random();

                int firstIndexToSwap = index.Next(0, 1000000);
                int secondIndexToSwap = index.Next(0, 1000000);

                int temp = array[firstIndexToSwap];
                array[firstIndexToSwap] = array[secondIndexToSwap];
                array[secondIndexToSwap] = temp;
            }
        }
    }
}
