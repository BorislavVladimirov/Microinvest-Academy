using System;
using System.Linq;

namespace additional01
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
                    int minValue = int.MaxValue;

                    for (int j = i; j < arrayLength; j++)
                    {
                        if (array[j] < minValue)
                        {
                            minValue = array[j];
                            index = j;
                        }
                    }

                    array[index] = array[i];
                    array[i] = minValue;
                }

                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
