using System;

namespace _10primeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (IsNumberPrime(n))
            {
                Console.WriteLine($"{n} is prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number.");
            }
        }

        private static bool IsNumberPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
