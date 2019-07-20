using System;
using System.Linq;

namespace additional06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = 0;

            if (int.TryParse(Console.ReadLine(), out arrayLength))
            {
                double[] array = new double[arrayLength];

                array = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                //Console.WriteLine(string.Join(" ", array.Where(x => x > array.Average() && x < (array.Average() * 2))));

                double sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                double average = sum / array.Length;

                foreach (var number in array)
                {
                    if (number > average && number < average * 2)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
