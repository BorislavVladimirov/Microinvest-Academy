using System;
using System.Collections.Generic;

namespace _16mAndN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            if (IsInRange(firsNumber, secondNumber))
            {
                for (int i = secondNumber; i >= firsNumber; i--)
                {
                    if (i % 50 == 0)
                    {
                        result.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(",",result));
        }

        private static bool IsInRange(int firsNumber, int secondNumber)
        {
            if (firsNumber >= 10 && firsNumber <= 5555
                && secondNumber >= 10 && secondNumber <= 5555)
            {
                return true;
            }

            return false;
        }
    }
}
