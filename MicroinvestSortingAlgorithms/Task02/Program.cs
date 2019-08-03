using System;

namespace Task02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number < 2)
                {
                    Console.WriteLine("False");
                }
                if (number == 2 || number == 3)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    int boundary = (int)Math.Floor(Math.Sqrt(number));
                    Console.WriteLine(IsPrimeNumber(boundary, number));
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        private static bool IsPrimeNumber(int boundary, int number)
        {
            if (number % boundary == 0)
            {
                return false;
            }

            if (boundary < 3)
            {
                return true;
            }

            return IsPrimeNumber(boundary - 1, number);
        }
    }
}
