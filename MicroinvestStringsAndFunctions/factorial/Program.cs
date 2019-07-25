using System;
using System.Numerics;

namespace factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(Factorial(number)); 
                Console.WriteLine(GetFactorial(number));

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }

        private static int Factorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        // tested and works with 25206
        private static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = number;

            for (int i = number; i > 1; i--)
            {
                factorial *= i - 1;
            }

            return factorial;
        }
    }
}
