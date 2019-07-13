using System;
using System.Linq;

namespace additional16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            if (IsValidChar(input))
            {
                char[] sorted = input.OrderBy(x => x).ToArray();

                Console.WriteLine(string.Join("", sorted));
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
