using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace additional22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] list = new int[] { 1, 2, 4, 7, 9 };
            //int[] result = Enumerable.Range(0, 10).Except(list).ToArray();
            //Console.WriteLine(string.Join(" ", result));

            //generating array with numbers from 0 to 1 000 000
            int[] array = Enumerable.Range(0, 1000001).ToArray();

            //generating random number to remove from the array
            Random random = new Random();
            int indexToRemove = random.Next(0, 1000001);

            //removing random number from the array
            List<int> tempList = array.ToList();
            tempList.RemoveAt(indexToRemove);
            array = tempList.ToArray();

            //shuffle the array
            ShuffleArray(array);
            
            int[] sorted = array.OrderBy(x => x).ToArray();
            Console.WriteLine(sorted.FirstOrDefault(x => sorted[x] + 1 != sorted[x + 1]) + 1);

            long sum = 0;
            long initialSum = (long)array.Length * ((long)array.Length + 1) / 2;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(initialSum - sum);
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
