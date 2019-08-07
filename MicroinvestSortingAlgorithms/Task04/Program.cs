using System;
using System.Text;

namespace Task04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                ValidateLength(number);

                GeneratePermutations("", number.ToString());
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        private static void GeneratePermutations(string prefix, string number)
        {
            int length = number.Length;

            if (length == 0)
            {
                PrintResultPermutations(prefix);
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    string currrentNumberAsString = number[i].ToString();
                    string remainingNumbersAsString = number.Substring(0, i) + number.Substring(i + 1, length - (i + 1));

                    GeneratePermutations(prefix + currrentNumberAsString, remainingNumbersAsString);
                }
            }
        }

        private static void PrintResultPermutations(string prefix)
        {
            Console.Write(prefix + " ");
        }

        private static void ValidateLength(int number)
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
