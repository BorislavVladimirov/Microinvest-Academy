using System;

namespace Task01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(GetSum(number));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        private static int GetSum(int number)
        {
            if (number == 8888)
            {
                return number;
            }

            return number + GetSum(number - 1);
        }
    }
}
