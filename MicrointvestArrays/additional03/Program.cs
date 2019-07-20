﻿using System;
using System.Linq;

namespace additional03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = 0;

            if (int.TryParse(Console.ReadLine(), out arrayLength))
            {
                double[] array = new double[arrayLength];
                int index = -1;

                array = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                for (int i = 0; i < arrayLength; i++)
                {
                    double minValue = double.MaxValue;

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

                for (int i = 0; i < array.Length / 2; i++)
                {
                    double tempNumber = array[i];

                    int indexToSwap = array.Length - 1 - i;
                    array[i] = array[indexToSwap];
                    array[indexToSwap] = tempNumber;
                }

                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
