using System;
using System.Linq;

namespace additional16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();

            if (IsValidChar(inputString))
            {
                char[] sortedInput = inputString.ToCharArray();

                SortArray(sortedInput);

                Console.WriteLine(string.Join("", sortedInput));
            }            
        }

        private static void SortArray(char[] sortedInput)
        {
            for (int i = 0; i < sortedInput.Length; i++)
            {
                int index = -1;
                int minValue = int.MaxValue;

                for (int j = i; j < sortedInput.Length; j++)
                {
                    int currentChar = (int)sortedInput[j];

                    if (currentChar < minValue)
                    {
                        minValue = currentChar;
                        index = j;
                    }
                }

                sortedInput[index] = sortedInput[i];
                sortedInput[i] = (char)minValue;
            }
        }

        private static bool IsValidChar(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int currentAsciiSymbol = (int)input[i];

                if (currentAsciiSymbol < 97 || currentAsciiSymbol > 122)
                {
                    Console.WriteLine("Invalid character");
                    return false;
                }
            }

            return true;
        }
    }
}
