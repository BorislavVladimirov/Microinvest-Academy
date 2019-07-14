﻿using System;
using System.Linq;

namespace _03smallestBiggestAndAverageValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // HAshset
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //double minValue = numbers.Min();
            //double maxValue = numbers.Max();

            int smallestNumber = int.MaxValue;
            int biggestNumber = int.MinValue;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }

                sum += numbers[i];
            }
                                //minValue          //maxValue
            Console.WriteLine($"{smallestNumber}, {biggestNumber}, {sum / numbers.Length}");

        }
    }
}