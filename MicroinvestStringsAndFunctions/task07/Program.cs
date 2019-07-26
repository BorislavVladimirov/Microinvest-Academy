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
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.OutputEncoding = Encoding.Unicode;
            int logestWordLength = int.MinValue;

            for (int i = 0; i < inputString.Length; i++)
            {
                string currentWord = inputString[i];

                if (currentWord.Length > logestWordLength)
                {
                    logestWordLength = currentWord.Length;
                }
            }
            Console.WriteLine($"{inputString.Length} думи, най-дългата е с {logestWordLength} символа.");
        }
    }
}
