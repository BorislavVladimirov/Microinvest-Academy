using System;
using System.Text;

namespace task08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            char[] inputString = Console.ReadLine().ToCharArray();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(IsStringPalindrome(inputString));             
        }

        private static string IsStringPalindrome(char[] inputString)
        {
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                {
                    return "Не.";
                }
            }

            return "Да.";
        }
    }
}
