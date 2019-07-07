using System;

namespace _18twoNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (IsInRange(firstNumber, secondNumber))
            {
                for (int i = 1; i <= firstNumber; i++)
                {
                    for (int j = 1; j <= secondNumber; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j};");
                    }
                }
            }
        }

        private static bool IsInRange(int firstNumber, int secondNumber)
        {
            if (firstNumber >= 1 && firstNumber <= 9 && secondNumber >= 1 && secondNumber <= 9)
            {
                return true;
            }

            return false;
        }
    }
}
