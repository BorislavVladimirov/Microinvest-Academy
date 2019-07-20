using System;
using System.Linq;

namespace _04AsciiValues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] ASCIIRange = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[] chars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if ((int)chars[i] >= ASCIIRange[0] && (int)chars[i] <= ASCIIRange[1])
                {
                    Console.Write(chars[i] + " ");
                }
            }
        }
    }
}
