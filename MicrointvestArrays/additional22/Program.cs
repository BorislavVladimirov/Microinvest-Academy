using System;
using System.Linq;

namespace additional22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Enumerable.Range(0, 1000000).ToArray();

            Random random = new Random();
            int indexToRemove = random.Next(0, 1000000);

            array.ToList().RemoveAt(indexToRemove);
            array.ToArray();

            ShuffleArray(array);

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
