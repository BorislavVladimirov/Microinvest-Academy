using System;

namespace Task01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(GetSum(number, sum));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        private static int GetSum(int number, int sum)
        {
            if (number == 1)
            {
                return sum + number;
            }

            sum += number;
            return GetSum(number - 1, sum);
        }
    }
}
