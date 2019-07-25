using System;
using System.Linq;
using System.Text;

namespace Task01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string firstString = input[0];
            string secondString = input[1];

            if (AreStringsValid(firstString, secondString))
            {
                Console.WriteLine(PrintResult(firstString, secondString));
            }
        }

        private static StringBuilder PrintResult(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(firstString.ToUpper() + " ");
            stringBuilder.Append(firstString.ToLower() + " ");
            stringBuilder.Append(secondString.ToUpper() + " ");
            stringBuilder.Append(secondString.ToLower() + " ");

            return stringBuilder;
        }

        private static bool AreStringsValid(string firstString, string secondString)
        {

            if (firstString.Length > 40 || secondString.Length > 40)
            {
                Console.WriteLine("Invalid string length!");

                return false;
            }

            for (int i = 0; i < firstString.Length; i++)
            {
                if (!char.IsLetter(firstString[i]))
                {
                    Console.WriteLine("Invalid string format!");
                    return false;
                }
            }

            for (int i = 0; i < secondString.Length; i++)
            {
                if (!char.IsLetter(secondString[i]))
                {
                    Console.WriteLine("Invalid string format!");
                    return false;
                }
            }

            return true;
        }
    }
}
