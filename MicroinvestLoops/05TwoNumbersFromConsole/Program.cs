using System;

namespace _05TwoNumbersFromConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
