using System;
using System.Collections.Generic;

namespace _22first10Nums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] resultNubers = new int[10];

            if (IsInRange(number))
            {
                int count = 0;

                while (count < 10)
                {
                    if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
                    {
                        resultNubers[count] = number;
                        count++;
                    }

                    number++;
                }

                for (int i = 0; i < 10; i++)
                {
                    if (i == 9) //escape printing additional ";" at the end of the result line
                    {
                        Console.Write($"{i + 1}:{resultNubers[i]}");
                    }
                    else
                    {
                        Console.Write($"{i + 1}:{resultNubers[i]}; ");
                    }
                }
            }
        }

        private static bool IsInRange(int number)
        {
            if (number >= 1 && number <= 999)
            {
                return true;
            }

            return false;
        }
    }
}
