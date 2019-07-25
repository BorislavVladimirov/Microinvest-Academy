using System;
using System.Collections.Generic;

namespace fibonachi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int indexOfSequence = 0;

            if (int.TryParse(Console.ReadLine(), out indexOfSequence))
            {
                FindFibonachi(indexOfSequence);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        private static void FindFibonachi(int indexOfSequence)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 1; i < indexOfSequence - 1; i++)
            {
                firstNumber = secondNumber - firstNumber;
                secondNumber = firstNumber + secondNumber;
            }

            Console.WriteLine(secondNumber);
        }
    }
}
