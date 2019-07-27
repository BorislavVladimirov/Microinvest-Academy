using System;

namespace fibonachiWithRecursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int indexOfSequence = 0;

            if (int.TryParse(Console.ReadLine(), out indexOfSequence))
            {
                int currentIndex = 1;
                int firstNumber = 0;
                int secondNumber = 1;

                Console.WriteLine(FindFibonachi(ref firstNumber, ref secondNumber, indexOfSequence, currentIndex));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        private static int FindFibonachi(ref int firstNumber, ref int secondNumber, int indexOfSequence, int currentIndex)
        {
            firstNumber = secondNumber - firstNumber;
            secondNumber = firstNumber + secondNumber;

            if (indexOfSequence == 1 || indexOfSequence == 2)
            {
                return 1;
            }
            if (indexOfSequence - 2 == currentIndex)
            {
                return secondNumber;
            }
            else
            {
                return FindFibonachi(ref firstNumber, ref secondNumber, indexOfSequence, currentIndex + 1);
            }
        }
    }
}
