using System;
using System.Linq;
using System.Text;

namespace task07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int longestWordLength = int.MinValue;

            GetLongestWord(ref longestWordLength, inputString);

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"{inputString.Length} думи, най-дългата е с {longestWordLength} символа.");
        }

        private static int GetLongestWord(ref int longestWordLength, string[] inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                string currentWord = inputString[i];

                if (currentWord.Length > longestWordLength)
                {
                    longestWordLength = currentWord.Length;
                }
            }

            return longestWordLength; 
        }
    }
}
