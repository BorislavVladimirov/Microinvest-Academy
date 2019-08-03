using System;

namespace Task02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;

            while (true)// to be easier to test 
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == 2)
                    {
                        Console.WriteLine("True");
                    }
                    else if (number % 2 == 0 || number < 2)
                    {
                        Console.WriteLine("False");
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
        }

        private static bool IsPrimeNumber(int boundary, int number)
        {
            if (boundary < 3)
            {
                return true;
            }
            if (number % boundary == 0)
            {
                return false;
            }

            if (boundary % 2 == 0)
            {
                return IsPrimeNumber(boundary - 1, number);
            }
            else
            {
                return IsPrimeNumber(boundary - 2, number);
            }
        }
    }
}
