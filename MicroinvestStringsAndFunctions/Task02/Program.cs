using System;
using System.Linq;

namespace Task02
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

            if (IsInputValidLength(firstString, secondString))
            {
                int longerStringLength = Math.Max(firstString.Length, secondString.Length);

                if (firstString.Length >= secondString.Length)
                {
                    string replacingString = secondString.Substring(0, 5);
                    string stringToReplace = firstString.Substring(0, 5);

                    firstString = firstString.Replace(stringToReplace, replacingString);

                    Console.WriteLine($"{longerStringLength} {firstString}");
                }
                else
                {
                    string replacingString = firstString.Substring(0, 5);
                    string stringToReplace = secondString.Substring(0, 5);

                    secondString = secondString.Replace(stringToReplace, replacingString);
                    Console.WriteLine($"{longerStringLength} {secondString}");
                }
            }
        }

        private static bool IsInputValidLength(string firstString, string secondString)
        {
            int fullInputLength = firstString.Length + secondString.Length;

            if (firstString.Length < 5 || secondString.Length < 5)// escaping OutOfRangeException if 
            {                                                     //one of the words's length is less than 5
                Console.WriteLine("One of the words is too short!");
                return false;
            }

            if (fullInputLength < 10 || fullInputLength > 20)
            {
                Console.WriteLine("Invalid string length! String should be between 10 and 20 characters long!");

                return false;
            }

            return true;
        }
    }
}
