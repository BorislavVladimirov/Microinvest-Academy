using System;
using System.Linq;

namespace additional02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = 0;

            if (int.TryParse(Console.ReadLine(), out arrayLength))
            {
                int[] array = new int[arrayLength];
                int index = -1;

                array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < arrayLength; i++)
                {
                    int maxValue = int.MinValue;

                    for (int j = i; j < arrayLength; j++)
                    {
                        if (array[j] > maxValue)
                        {
                            maxValue = array[j];
                            index = j;
                        }
                    }

                    array[index] = array[i];
                    array[i] = maxValue;
                }

                Console.WriteLine(string.Join(" ", array));

            }
        }
    }
}
