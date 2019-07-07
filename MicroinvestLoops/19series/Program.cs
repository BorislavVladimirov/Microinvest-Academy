using System;

namespace _19series
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int previousNumber = number;
            double result = 0;

            if (IsInRange(number))
            {
                while (previousNumber != 1)
                {
                    if (previousNumber % 2 == 0)
                    {
                        result = previousNumber * 0.5;
                        Console.Write(result + " ");
                    }
                    else
                    {
                        result = previousNumber * 3 + 1;
                        Console.Write(result + " ");
                    }

                    previousNumber = (int)result;
                }
            }
        }

        private static bool IsInRange(int number)
        {
            if (number >= 10 && number <= 99)
            {
                return true;
            }

            return false;
        }
    }
}
