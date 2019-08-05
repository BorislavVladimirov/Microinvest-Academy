using System;

namespace Task04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            //THE TASK IS NOT FINISHED
            if (int.TryParse(Console.ReadLine(), out number))
            {
                LengthCheck(number);

                int[] resultArray = new int[GetLengthForResultArray(number)];

                int maxLength = 0;
                GeneratePermutations(resultArray, number, maxLength);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        private static int GetLengthForResultArray(int number)
        {
            int factorial = number;

            for (int i = number; i > 1; i--)
            {
                factorial *= i - 1;
            }

            return factorial;
        }

        private static string GeneratePermutations(int[] resultArray, int number, int maxLength)
        {
            if (maxLength == number)
            {
                return string.Join(" ", resultArray);
            }
            else if (maxLength == number.ToString().Length - 1)
            {
                return string.Join(" ", resultArray);
            }
            else
            {
                int currentDigit = int.Parse(number.ToString()[maxLength].ToString());

                SwapElements(number, maxLength);


                return GeneratePermutations(resultArray, number, maxLength + 1);
            }
        }

        private static void SwapElements(int number, int index)
        {
            for (int i = index + 1; i < number.ToString().Length - 1; i++)
            {

            }
        }

        private static void LengthCheck(int number)
        {
            string numberToString = number.ToString();

            if (numberToString.Length > 5)
            {
                Console.WriteLine("Number should contain maximum 5 digits.");
            }
            else if (numberToString.Length == 1)
            {
                Console.WriteLine(number);
                return;
            }
        }
    }
}
